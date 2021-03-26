using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace SystemFontFinder
{
	public partial class Form1 : Form
	{
		List<string> allTagsToApply;
		List<string> availableFonts;
		public static HashSet<string> uniqueTags
		{ get; set; }
		public static IDictionary<string, string[]> FontTagPair
		{ get; set; }
		public Form1()
		{
			InitializeComponent();
			try{
				List<string> allFontsNames = new List<string>();
				uniqueTags = new HashSet<string>();
				allTagsToApply = new List<string>();
				string[] loadTagsWithFonts=File.ReadAllLines("FontsWithTags.sfff");
				using(InstalledFontCollection fontFamilies = new InstalledFontCollection())
					foreach (var fontFamilyName in fontFamilies.Families)
						allFontsNames.Add(fontFamilyName.Name);
				availableFonts=new List<string>(allFontsNames);
				foreach (var fonts in loadTagsWithFonts) {
					string fontName=fonts.Split(':')[0];
					if(allFontsNames.Contains(fontName))
						allFontsNames.Remove(fontName);
				}
				if(allFontsNames.Count>0){
					List<string> tagsWithFonts=new List<string>();
					foreach (var restOfFonts in allFontsNames)
						tagsWithFonts.Add(restOfFonts+":None");
					File.AppendAllLines("FontsWithTags.sfff",tagsWithFonts.ToArray());
				}
				loadTagsWithFonts=File.ReadAllLines("FontsWithTags.sfff");
				FontTagPair = new Dictionary<string, string[]>();
				foreach (var fontsData in loadTagsWithFonts) {
					string[] fontSeperate=fontsData.Split(':');
					FontTagPair.Add(fontSeperate[0],fontSeperate[1].Split(','));
				}
				foreach (var tagName in FontTagPair.Values)
					foreach (var tag in tagName)
						uniqueTags.Add(tag);
				foreach (var uniqueTag in uniqueTags) {
					CheckBox tagsName=new CheckBox(){
						Text=uniqueTag,
						Font=new Font("Microsoft Sans Serif",12)
					};
					toolTip1.SetToolTip(tagsName,tagsName.Text);
					tagsPanel.Controls.Add(tagsName);
					tagsName.CheckedChanged+=(se,ev)=>{
						CheckBox checkbox=(CheckBox)se;
						if(checkbox.Checked)
							allTagsToApply.Add(checkbox.Text);
						else
							allTagsToApply.Remove(checkbox.Text);
					};
				}
			}
			catch(System.IO.FileNotFoundException){
				MessageBox.Show("FontWithTags.sfff Is Missing","System Font Finder",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		
		void EnterButtonClick(object sender, EventArgs e)
		{
			List<string> beforeBroadcast = new List<string>();
			HashSet<string> fontsToBroadcast=new HashSet<string>();
			string Seperator=" , ";
			if(allTagsToApply.Count==0)
				foreach (var checkbox in tagsPanel.Controls)
					((CheckBox)checkbox).Checked=true;
			if(inputText.Text=="")
				inputText.Text="A";
			foreach (var tag in allTagsToApply)
				foreach(KeyValuePair<string, string[]> fontTag in FontTagPair)
					if(fontTag.Value.Contains(tag) && availableFonts.Contains(fontTag.Key))
						beforeBroadcast.Add(fontTag.Key);
			HashSet<string> uniqueBeforeBroadcast=new HashSet<string>(beforeBroadcast);
			if(AndFilter.Checked){
				foreach (var uniqueFonts in uniqueBeforeBroadcast){
					if(beforeBroadcast.Count(fontName=>fontName==uniqueFonts)==allTagsToApply.Count)
						fontsToBroadcast.Add(uniqueFonts);
				}
				Seperator=" And ";
			}
			else
				fontsToBroadcast=new HashSet<string>(uniqueBeforeBroadcast);
			uniqueTags.Remove("None");
			new MainForm(inputText.Text,fontsToBroadcast){
				Text=fontsToBroadcast.Count+" Fonts Scanned For "+String.Join(Seperator,allTagsToApply.ToArray())
			}.Show();
		}
		
		void Form1FormClosing(object sender, FormClosingEventArgs e)
		{
			string finalData="";
			foreach(KeyValuePair<string, string[]> data in FontTagPair.OrderBy(key=>key.Key))
				finalData+=data.Key+":"+String.Join(",",data.Value)+"\n";
			File.WriteAllText("FontsWithTags.sfff",finalData);
		}
	}
}
