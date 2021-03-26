/*
 * Created by SharpDevelop.
 * User: Qasim Arthuna
 * Date: 16-03-2021
 * Time: 10:52 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SystemFontFinder
{
	partial class Form1
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
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.inputText = new System.Windows.Forms.TextBox();
			this.EnterButton = new System.Windows.Forms.Button();
			this.tagsPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.AndFilter = new System.Windows.Forms.CheckBox();
			this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.SuspendLayout();
			// 
			// inputText
			// 
			this.inputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.inputText.Location = new System.Drawing.Point(13, 13);
			this.inputText.Name = "inputText";
			this.inputText.Size = new System.Drawing.Size(745, 26);
			this.inputText.TabIndex = 0;
			// 
			// EnterButton
			// 
			this.EnterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EnterButton.Location = new System.Drawing.Point(846, 12);
			this.EnterButton.Name = "EnterButton";
			this.EnterButton.Size = new System.Drawing.Size(76, 26);
			this.EnterButton.TabIndex = 2;
			this.EnterButton.Text = "Enter";
			this.EnterButton.UseVisualStyleBackColor = true;
			this.EnterButton.Click += new System.EventHandler(this.EnterButtonClick);
			// 
			// tagsPanel
			// 
			this.tagsPanel.AutoScroll = true;
			this.tagsPanel.Location = new System.Drawing.Point(12, 49);
			this.tagsPanel.Name = "tagsPanel";
			this.tagsPanel.Size = new System.Drawing.Size(910, 252);
			this.tagsPanel.TabIndex = 3;
			// 
			// AndFilter
			// 
			this.AndFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AndFilter.Location = new System.Drawing.Point(774, 12);
			this.AndFilter.Name = "AndFilter";
			this.AndFilter.Size = new System.Drawing.Size(66, 26);
			this.AndFilter.TabIndex = 4;
			this.AndFilter.Text = "And";
			this.AndFilter.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(934, 313);
			this.Controls.Add(this.AndFilter);
			this.Controls.Add(this.tagsPanel);
			this.Controls.Add(this.EnterButton);
			this.Controls.Add(this.inputText);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Form1";
			this.Text = "System Font Finder";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.CheckBox AndFilter;
		private System.Windows.Forms.FlowLayoutPanel tagsPanel;
		private System.Windows.Forms.Button EnterButton;
		private System.Windows.Forms.TextBox inputText;
	}
}
