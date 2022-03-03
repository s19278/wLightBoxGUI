using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wLightBoxGUI.wLightBoxLib.Models;

namespace wLightBoxGUI
{
	public partial class SettingsWindow : Form
	{
		private wLightBoxController _lb = null;
		private RootRgbw _settings;
		private Boolean firstIni = true;
		private System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
		public SettingsWindow(wLightBoxController lb)
		{
			_lb = lb;
			InitializeComponent();
			this.informationBox.Controls[1].Text = lb.device.deviceName;
			this.informationBox.Controls[2].Text = lb.device.product;
			this.informationBox.Controls[3].Text = lb.device.type;
			this.informationBox.Controls[4].Text = lb.device.ip;
			this.informationBox.Controls[5].Text = lb.device.id;
			timer.Interval = 1000;
			timer.Tick += autoSettingsRefresh;
			timer.Start();

		}
		private async void autoSettingsRefresh(object sender, EventArgs e)
		{
			timer.Stop();
			try
			{
				await _lb.GetExtState();
			}
			catch (Exception)
			{
				
				var info = MessageBox.Show("Lost connection to device.", "", MessageBoxButtons.OK, MessageBoxIcon.None);
				
				if (info == DialogResult.OK)
				{
					this.Dispose();
					Application.Exit();
				}

			}
			if (firstIni) {
				_settings = _lb.settings;
				comboBox1.DataSource = new BindingSource(_settings.rgbw.effectNames, null);
				comboBox1.DisplayMember = "Value";
				comboBox1.ValueMember = "Key";
				comboBox1.SelectedIndex = -1;
				firstIni = false;

			}
			var temp = HextoDec();
			this.currentColourBox.BackColor = Color.FromArgb(temp[0], temp[1], temp[2]);
			this.currentModeLabel.Text = _lb.settings.rgbw.effectNames[_lb.settings.rgbw.effectID];
			timer.Start();

		}
		private async Task settingsRefresh()
		{

			var temp = HextoDec();
			this.currentColourBox.BackColor = Color.FromArgb(temp[0], temp[1], temp[2]);
			this.currentModeLabel.Text = _lb.settings.rgbw.effectNames[_lb.settings.rgbw.effectID];

		}
		private async void applyButton_Click(object sender, EventArgs e)
		{
			if (comboBox1.SelectedIndex != -1)
			{
				_settings.rgbw.effectID = comboBox1.SelectedIndex;
				comboBox1.SelectedIndex = -1;
			}
			_settings.rgbw.desiredColor = targetColourBox.BackColor.R.ToString("X2") + targetColourBox.BackColor.G.ToString("X2") + targetColourBox.BackColor.B.ToString("X2") + "0000";
			Boolean result = false;
			int failMessage = 0;
			try
			{
				result = await _lb.UpdateSettings(_settings);
			}
			catch (Exception)
			{
				failMessage = 1;
				

			}
			
			if (result)
			{

				MessageBox.Show("Updated successfully", "", MessageBoxButtons.OK, MessageBoxIcon.None);
				_settings = _lb.settings;
				await settingsRefresh();

			}
			else
			{
				if(failMessage == 0)
				{
					MessageBox.Show("Update failed, try again", "", MessageBoxButtons.OK, MessageBoxIcon.None);
				}
			}
			this.Refresh();
		}

		private void targetColourBox_Click(object sender, EventArgs e)
		{
			ColorDialog MyDialog = new ColorDialog();
			MyDialog.AllowFullOpen = true;
			MyDialog.ShowHelp = true;
			MyDialog.Color = targetColourBox.BackColor;
			if (MyDialog.ShowDialog() == DialogResult.OK)
				targetColourBox.BackColor = MyDialog.Color;
		}

		private  int[] HextoDec()
		{

			var red = Convert.ToInt32(_lb.settings.rgbw.currentColor.Substring(0, 2), 16);
			var green = Convert.ToInt32(_lb.settings.rgbw.currentColor.Substring(2, 2), 16);
			var blue = Convert.ToInt32(_lb.settings.rgbw.currentColor.Substring(4, 2), 16);
			int[] colors = { red, green, blue };
			return colors;
		}
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
			base.OnFormClosing(e);
			this.Dispose();
			timer.Stop();
			Application.Exit();
		}

	}

}
