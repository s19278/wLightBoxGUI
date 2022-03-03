
namespace wLightBoxGUI
{
	partial class MainWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.connectionButton = new System.Windows.Forms.Button();
			this.connectionTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// connectionButton
			// 
			this.connectionButton.BackColor = System.Drawing.SystemColors.Control;
			this.connectionButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.connectionButton.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.connectionButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.connectionButton.Location = new System.Drawing.Point(0, 322);
			this.connectionButton.Name = "connectionButton";
			this.connectionButton.Size = new System.Drawing.Size(425, 39);
			this.connectionButton.TabIndex = 0;
			this.connectionButton.Text = "Connect";
			this.connectionButton.UseVisualStyleBackColor = false;
			this.connectionButton.Click += new System.EventHandler(this.connectionButton_Click);
			// 
			// connectionTextBox
			// 
			this.connectionTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.connectionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.connectionTextBox.Location = new System.Drawing.Point(0, 296);
			this.connectionTextBox.MaxLength = 50;
			this.connectionTextBox.Name = "connectionTextBox";
			this.connectionTextBox.Size = new System.Drawing.Size(425, 26);
			this.connectionTextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.DarkGray;
			this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(0, 266);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(425, 30);
			this.label1.TabIndex = 2;
			this.label1.Text = "Enter a correct ip adress:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(425, 250);
			this.label2.TabIndex = 3;
			this.label2.Text = "wLightBox control tool";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ClientSize = new System.Drawing.Size(425, 361);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.connectionTextBox);
			this.Controls.Add(this.connectionButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainWindow";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "LightBox Settings";
			this.Load += new System.EventHandler(this.MainWindow_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button connectionButton;
		private System.Windows.Forms.TextBox connectionTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
	}
}

