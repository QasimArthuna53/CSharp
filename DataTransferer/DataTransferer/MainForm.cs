using System;
using System.Net.NetworkInformation;

namespace DataTransferer
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void isAnonymousCheckCheckedChanged(object sender, EventArgs e)
		{
			credentials.Visible=!isAnonymousCheck.Checked;
		}
		
		void connectClick(object sender, EventArgs e)
		{
			NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
			foreach (NetworkInterface adapter in adapters)
			{
				foreach (GatewayIPAddressInformation address in adapter.GetIPProperties().GatewayAddresses)
				{
					string addressString = address.Address.ToString();
					if(addressString.Contains(".")){
						System.Diagnostics.Process.Start("explorer.exe" , @"ftp://"+(isAnonymousCheck.Checked?"":usernameText.Text+":"+passwordText.Text+"@")+addressString+":"+portText.Text);
						break;
					}
				}
			}
			Dispose();
		}
	}
}
