/*
 * Created by SharpDevelop.
 * User: ARTHHUNA
 * Date: 08-08-2020
 * Time: 01.29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SystemFontFinder
{
	partial class MainForm
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
			this.container = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// container
			// 
			this.container.AutoScroll = true;
			this.container.Dock = System.Windows.Forms.DockStyle.Fill;
			this.container.Location = new System.Drawing.Point(0, 0);
			this.container.Name = "container";
			this.container.Size = new System.Drawing.Size(1370, 749);
			this.container.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1370, 749);
			this.Controls.Add(this.container);
			this.Name = "MainForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.FlowLayoutPanel container;
	}
}
