using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using System.IO;

namespace SystemFontFinder{
	public partial class MainForm : Form{
		public MainForm(string textInput,HashSet<string> fontsWithTags){
			InitializeComponent();
			try{
				foreach (var fontFamily in fontsWithTags){
					Label fontStyle=new Label(){
						Text=textInput,
						Font=new Font(fontFamily,24),
						AutoSize=true,
						TextAlign= ContentAlignment.MiddleCenter
					};
					Panel fontStyleContainer=new Panel(){
						AutoScroll=true,
						Location=new Point(10,30),
						Height=100
					};
					FlowLayoutPanel tagsContainer=new FlowLayoutPanel(){
						AutoScroll=true,
						Location=new Point(10,150),
						WrapContents=false,
						Height=50
					};
					GroupBox fontContainer=new GroupBox(){
						Text=fontFamily,
						Font=new Font("Microsoft Sans Serif",12),
						Height=210
					};
					fontContainer.Click+=(se,ev)=>Clipboard.SetText(((GroupBox)se).Text);
					fontStyleContainer.Controls.Add(fontStyle);
					fontContainer.Controls.Add(fontStyleContainer);
					AddTags(fontFamily,tagsContainer);
					fontContainer.Controls.Add(tagsContainer);
					container.Controls.Add(fontContainer);
					fontStyle.Click+=(se,ev)=>{
						Label labelObject=((Label)se);
						string fontName=labelObject.Font.Name;
						string[] tagUsed=Form1.FontTagPair[fontFamily];
						TagsApplyDialog tagDailog=new TagsApplyDialog(fontName){
							Text=fontName
						};
						tagDailog.ShowDialog();
						string[] newTags=tagDailog.Tags;
						if(newTags.Length!=0){
							Form1.FontTagPair[fontFamily]=newTags;
							labelObject.BackColor=Color.DarkGray;
							tagsContainer.Controls.Clear();
							AddTags(fontFamily,tagsContainer);
						}
					};
					string[] displaySetting=File.ReadAllLines("DisplaySetting.sfff");
					fontContainer.Width=(fontContainer.Parent.Width+(Int16.Parse(displaySetting[0])))/(Int16.Parse(displaySetting[1]));
					tagsContainer.Width=tagsContainer.Parent.Width-25;
					fontStyleContainer.Width=fontStyleContainer.Parent.Width-25;
				}
			}
			catch(System.IO.FileNotFoundException){
				MessageBox.Show("DisplaySetting.sfff Is Missing","System Font Finder",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
			catch(System.Exception){
				MessageBox.Show("Something Went Wrong, Please Try Again","System Font Finder",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		void AddTags(string fontFamily,FlowLayoutPanel tagsContainer){
			foreach (var allTags in Form1.FontTagPair[fontFamily]) {
				tagsContainer.Controls.Add(new Label(){
				                           	Text="  "+allTags+"  ",
				                           	BackColor=Color.BlueViolet,
				                           	ForeColor=Color.AntiqueWhite,
				                           	AutoSize=true,
				                           	Padding=new Padding(0,5,0,5)
				                           });
			}
		}
	}
}