using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wLightBoxGUI
{
	public partial class MainWindow : Form
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void MainWindow_Load(object sender, EventArgs e)
		{

		}
		private async void connectionButton_Click(object sender, EventArgs e)
		{


			wLightBoxController lb = null;
			try
			{
				string connectionString = connectionTextBox.Text;
				lb = await wLightBoxController.wLightBoxConnect(connectionString);
				
			}
			catch (Exception)
			{

			}
			if (lb == null)
			{

				MessageBox.Show("Can't connect to device. Check if ip adress is correct", "", MessageBoxButtons.OK, MessageBoxIcon.None);
			}
			else
			{

				Console.WriteLine(lb.device.deviceName);
				var info = MessageBox.Show("Successfull connected to device.", "", MessageBoxButtons.OK, MessageBoxIcon.None);
				if (info == DialogResult.OK)
				{
					new SettingsWindow(lb).Show();
					this.Hide();
				}
			};


		}
	}
}
