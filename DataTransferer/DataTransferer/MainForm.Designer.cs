namespace DataTransferer
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.isAnonymousCheck = new System.Windows.Forms.CheckBox();
			this.credentials = new System.Windows.Forms.Panel();
			this.passwordText = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.usernameText = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.portText = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.connect = new System.Windows.Forms.Button();
			this.credentials.SuspendLayout();
			this.SuspendLayout();
			// 
			// isAnonymousCheck
			// 
			this.isAnonymousCheck.Checked = true;
			this.isAnonymousCheck.CheckState = System.Windows.Forms.CheckState.Checked;
			this.isAnonymousCheck.Location = new System.Drawing.Point(12, 10);
			this.isAnonymousCheck.Name = "isAnonymousCheck";
			this.isAnonymousCheck.Size = new System.Drawing.Size(110, 24);
			this.isAnonymousCheck.TabIndex = 0;
			this.isAnonymousCheck.Text = "Anonymous Login";
			this.isAnonymousCheck.UseVisualStyleBackColor = true;
			this.isAnonymousCheck.CheckedChanged += new System.EventHandler(this.isAnonymousCheckCheckedChanged);
			// 
			// credentials
			// 
			this.credentials.Controls.Add(this.passwordText);
			this.credentials.Controls.Add(this.label2);
			this.credentials.Controls.Add(this.usernameText);
			this.credentials.Controls.Add(this.label1);
			this.credentials.Location = new System.Drawing.Point(12, 51);
			this.credentials.Name = "credentials";
			this.credentials.Size = new System.Drawing.Size(382, 25);
			this.credentials.TabIndex = 1;
			this.credentials.Visible = false;
			// 
			// passwordText
			// 
			this.passwordText.Location = new System.Drawing.Point(262, 0);
			this.passwordText.Name = "passwordText";
			this.passwordText.PasswordChar = '*';
			this.passwordText.Size = new System.Drawing.Size(114, 20);
			this.passwordText.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(201, 3);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 21);
			this.label2.TabIndex = 2;
			this.label2.Text = "Password";
			// 
			// usernameText
			// 
			this.usernameText.Location = new System.Drawing.Point(65, 0);
			this.usernameText.Name = "usernameText";
			this.usernameText.Size = new System.Drawing.Size(114, 20);
			this.usernameText.TabIndex = 1;
			this.usernameText.Text = "user";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(4, 3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Username";
			// 
			// portText
			// 
			this.portText.Location = new System.Drawing.Point(162, 12);
			this.portText.Name = "portText";
			this.portText.Size = new System.Drawing.Size(114, 20);
			this.portText.TabIndex = 5;
			this.portText.Text = "12345";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(130, 15);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 21);
			this.label3.TabIndex = 4;
			this.label3.Text = "Port";
			// 
			// connect
			// 
			this.connect.Location = new System.Drawing.Point(287, 12);
			this.connect.Name = "connect";
			this.connect.Size = new System.Drawing.Size(101, 21);
			this.connect.TabIndex = 7;
			this.connect.Text = "Connect";
			this.connect.UseVisualStyleBackColor = true;
			this.connect.Click += new System.EventHandler(this.connectClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(395, 89);
			this.Controls.Add(this.connect);
			this.Controls.Add(this.portText);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.credentials);
			this.Controls.Add(this.isAnonymousCheck);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "MainForm";
			this.Text = "DataTransferer";
			this.credentials.ResumeLayout(false);
			this.credentials.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button connect;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox portText;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox usernameText;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox passwordText;
		private System.Windows.Forms.Panel credentials;
		private System.Windows.Forms.CheckBox isAnonymousCheck;
	}
}
