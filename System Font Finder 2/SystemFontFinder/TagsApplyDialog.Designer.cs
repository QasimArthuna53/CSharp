/*
 * Created by SharpDevelop.
 * User: Qasim Arthuna
 * Date: 18-03-2021
 * Time: 03:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SystemFontFinder
{
	partial class TagsApplyDialog
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
//		private void InitializeComponent()
//		{
//			// 
//			// TagsApplyDialog
//			// 
//			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//			this.Text = "TagsApplyDialog";
//			this.Name = "TagsApplyDialog";
//		}
			private void InitializeComponent()
		{
				this.ApplyTags = new System.Windows.Forms.Button();
				this.TagsToApply = new System.Windows.Forms.CheckedListBox();
				this.NewTag = new System.Windows.Forms.TextBox();
				this.AddTag = new System.Windows.Forms.Button();
				this.SuspendLayout();
				// 
				// ApplyTags
				// 
				this.ApplyTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.ApplyTags.Location = new System.Drawing.Point(11, 476);
				this.ApplyTags.Name = "ApplyTags";
				this.ApplyTags.Size = new System.Drawing.Size(94, 29);
				this.ApplyTags.TabIndex = 1;
				this.ApplyTags.Text = "Apply";
				this.ApplyTags.UseVisualStyleBackColor = true;
				this.ApplyTags.Click += new System.EventHandler(this.ApplyTagsClick);
				// 
				// TagsToApply
				// 
				this.TagsToApply.CheckOnClick = true;
				this.TagsToApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.TagsToApply.FormattingEnabled = true;
				this.TagsToApply.Location = new System.Drawing.Point(12, 12);
				this.TagsToApply.Name = "TagsToApply";
				this.TagsToApply.Size = new System.Drawing.Size(223, 403);
				this.TagsToApply.TabIndex = 2;
				// 
				// NewTag
				// 
				this.NewTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.NewTag.Location = new System.Drawing.Point(11, 433);
				this.NewTag.Name = "NewTag";
				this.NewTag.Size = new System.Drawing.Size(224, 26);
				this.NewTag.TabIndex = 3;
				// 
				// AddTag
				// 
				this.AddTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
				this.AddTag.Location = new System.Drawing.Point(131, 476);
				this.AddTag.Name = "AddTag";
				this.AddTag.Size = new System.Drawing.Size(104, 29);
				this.AddTag.TabIndex = 4;
				this.AddTag.Text = "Add";
				this.AddTag.UseVisualStyleBackColor = true;
				this.AddTag.Click += new System.EventHandler(this.AddTagClick);
				// 
				// TagsApplyDialog
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(247, 513);
				this.Controls.Add(this.AddTag);
				this.Controls.Add(this.NewTag);
				this.Controls.Add(this.TagsToApply);
				this.Controls.Add(this.ApplyTags);
				this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
				this.Name = "TagsApplyDialog";
				this.ResumeLayout(false);
				this.PerformLayout();
		}
		private System.Windows.Forms.Button AddTag;
		private System.Windows.Forms.TextBox NewTag;
		private System.Windows.Forms.CheckedListBox TagsToApply;
		private System.Windows.Forms.Button ApplyTags;
	}
}
