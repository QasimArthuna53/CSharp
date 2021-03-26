using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace SystemFontFinder
{
	public partial class TagsApplyDialog : Form
	{
		public string[] Tags
		{ get; set; }
		public TagsApplyDialog(string fontName)
		{
			InitializeComponent();
			Tags=new string[]{};
			HashSet<string> uniqueTags=new HashSet<string>(Form1.uniqueTags);
			foreach (var tag in Form1.FontTagPair[fontName]) {
				if(uniqueTags.Contains(tag)){
					TagsToApply.Items.Add(tag,true);
					uniqueTags.Remove(tag);
				}
			}
			foreach (var notUsedTag in uniqueTags)
				TagsToApply.Items.Add(notUsedTag);
		}
		void ApplyTagsClick(object sender, EventArgs e)
		{
			if(TagsToApply.CheckedItems.Count>0){
				List<string> tagsList=new List<string>();
				foreach (var checkedItem in TagsToApply.CheckedItems)
					tagsList.Add(checkedItem.ToString());
				Tags=tagsList.ToArray();
			}
			else
				Tags=new string[]{"None"};
			Close();
		}
		void AddTagClick(object sender, EventArgs e)
		{
			if(NewTag.Text!="" && NewTag.Text!=" "){
				TagsToApply.Items.Add(new CultureInfo("en").TextInfo.ToTitleCase(NewTag.Text),true);
				NewTag.Text="";
			}
		}
	}
}
