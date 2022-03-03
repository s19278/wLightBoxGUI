
namespace wLightBoxGUI
{
	partial class SettingsWindow
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
			System.Windows.Forms.Label deviceNameLabel;
			System.Windows.Forms.Label productNameLabel;
			System.Windows.Forms.Label typeNameLabel;
			System.Windows.Forms.Label idLabel;
			System.Windows.Forms.Label ipLabel;
			this.label1 = new System.Windows.Forms.Label();
			this.currentColourBox = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.targetColourBox = new System.Windows.Forms.PictureBox();
			this.applyButton = new System.Windows.Forms.Button();
			this.informationLabel = new System.Windows.Forms.Label();
			this.informationBox = new System.Windows.Forms.GroupBox();
			this.deviceNameContentLabel = new System.Windows.Forms.Label();
			this.productNameContentLabel = new System.Windows.Forms.Label();
			this.typeNameContentLabel = new System.Windows.Forms.Label();
			this.ipcontentLabel = new System.Windows.Forms.Label();
			this.idContentLabel = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.targetModeLabel = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.currentModeLabel = new System.Windows.Forms.Label();
			deviceNameLabel = new System.Windows.Forms.Label();
			productNameLabel = new System.Windows.Forms.Label();
			typeNameLabel = new System.Windows.Forms.Label();
			idLabel = new System.Windows.Forms.Label();
			ipLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.currentColourBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.targetColourBox)).BeginInit();
			this.informationBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// deviceNameLabel
			// 
			deviceNameLabel.AutoSize = true;
			deviceNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			deviceNameLabel.Location = new System.Drawing.Point(30, 55);
			deviceNameLabel.Name = "deviceNameLabel";
			deviceNameLabel.Size = new System.Drawing.Size(49, 16);
			deviceNameLabel.TabIndex = 6;
			deviceNameLabel.Text = "Name";
			// 
			// productNameLabel
			// 
			productNameLabel.AutoSize = true;
			productNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			productNameLabel.Location = new System.Drawing.Point(30, 95);
			productNameLabel.Name = "productNameLabel";
			productNameLabel.Size = new System.Drawing.Size(61, 16);
			productNameLabel.TabIndex = 7;
			productNameLabel.Text = "Product";
			// 
			// typeNameLabel
			// 
			typeNameLabel.AutoSize = true;
			typeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			typeNameLabel.Location = new System.Drawing.Point(30, 135);
			typeNameLabel.Name = "typeNameLabel";
			typeNameLabel.Size = new System.Drawing.Size(44, 16);
			typeNameLabel.TabIndex = 8;
			typeNameLabel.Text = "Type";
			// 
			// idLabel
			// 
			idLabel.AutoSize = true;
			idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			idLabel.Location = new System.Drawing.Point(30, 175);
			idLabel.Name = "idLabel";
			idLabel.Size = new System.Drawing.Size(23, 16);
			idLabel.TabIndex = 9;
			idLabel.Text = "ID";
			// 
			// ipLabel
			// 
			ipLabel.AutoSize = true;
			ipLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			ipLabel.Location = new System.Drawing.Point(30, 215);
			ipLabel.Name = "ipLabel";
			ipLabel.Size = new System.Drawing.Size(22, 16);
			ipLabel.TabIndex = 10;
			ipLabel.Text = "IP";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(403, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Current colour";
			// 
			// currentColourBox
			// 
			this.currentColourBox.BackColor = System.Drawing.Color.White;
			this.currentColourBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.currentColourBox.Location = new System.Drawing.Point(555, 47);
			this.currentColourBox.Name = "currentColourBox";
			this.currentColourBox.Size = new System.Drawing.Size(100, 50);
			this.currentColourBox.TabIndex = 1;
			this.currentColourBox.TabStop = false;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(403, 154);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(115, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Target colour";
			// 
			// targetColourBox
			// 
			this.targetColourBox.BackColor = System.Drawing.Color.White;
			this.targetColourBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.targetColourBox.Location = new System.Drawing.Point(555, 136);
			this.targetColourBox.Name = "targetColourBox";
			this.targetColourBox.Size = new System.Drawing.Size(100, 50);
			this.targetColourBox.TabIndex = 3;
			this.targetColourBox.TabStop = false;
			this.targetColourBox.Click += new System.EventHandler(this.targetColourBox_Click);
			// 
			// applyButton
			// 
			this.applyButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this.applyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.applyButton.Location = new System.Drawing.Point(491, 388);
			this.applyButton.Name = "applyButton";
			this.applyButton.Size = new System.Drawing.Size(75, 23);
			this.applyButton.TabIndex = 4;
			this.applyButton.Text = "Apply";
			this.applyButton.UseVisualStyleBackColor = true;
			this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
			// 
			// informationLabel
			// 
			this.informationLabel.AutoSize = true;
			this.informationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.informationLabel.Location = new System.Drawing.Point(20, 15);
			this.informationLabel.Name = "informationLabel";
			this.informationLabel.Size = new System.Drawing.Size(167, 20);
			this.informationLabel.TabIndex = 5;
			this.informationLabel.Text = "Device informations";
			// 
			// informationBox
			// 
			this.informationBox.Controls.Add(this.informationLabel);
			this.informationBox.Controls.Add(this.deviceNameContentLabel);
			this.informationBox.Controls.Add(this.productNameContentLabel);
			this.informationBox.Controls.Add(this.typeNameContentLabel);
			this.informationBox.Controls.Add(this.ipcontentLabel);
			this.informationBox.Controls.Add(this.idContentLabel);
			this.informationBox.Controls.Add(deviceNameLabel);
			this.informationBox.Controls.Add(productNameLabel);
			this.informationBox.Controls.Add(typeNameLabel);
			this.informationBox.Controls.Add(ipLabel);
			this.informationBox.Controls.Add(idLabel);
			this.informationBox.Location = new System.Drawing.Point(27, 22);
			this.informationBox.Name = "informationBox";
			this.informationBox.Size = new System.Drawing.Size(276, 349);
			this.informationBox.TabIndex = 11;
			this.informationBox.TabStop = false;
			// 
			// deviceNameContentLabel
			// 
			this.deviceNameContentLabel.AutoSize = true;
			this.deviceNameContentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.deviceNameContentLabel.Location = new System.Drawing.Point(135, 55);
			this.deviceNameContentLabel.Name = "deviceNameContentLabel";
			this.deviceNameContentLabel.Size = new System.Drawing.Size(40, 15);
			this.deviceNameContentLabel.TabIndex = 11;
			this.deviceNameContentLabel.Text = "empty";
			// 
			// productNameContentLabel
			// 
			this.productNameContentLabel.AutoSize = true;
			this.productNameContentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.productNameContentLabel.Location = new System.Drawing.Point(135, 95);
			this.productNameContentLabel.Name = "productNameContentLabel";
			this.productNameContentLabel.Size = new System.Drawing.Size(40, 15);
			this.productNameContentLabel.TabIndex = 12;
			this.productNameContentLabel.Text = "empty";
			// 
			// typeNameContentLabel
			// 
			this.typeNameContentLabel.AutoSize = true;
			this.typeNameContentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.typeNameContentLabel.Location = new System.Drawing.Point(135, 135);
			this.typeNameContentLabel.Name = "typeNameContentLabel";
			this.typeNameContentLabel.Size = new System.Drawing.Size(40, 15);
			this.typeNameContentLabel.TabIndex = 13;
			this.typeNameContentLabel.Text = "empty";
			// 
			// ipcontentLabel
			// 
			this.ipcontentLabel.AutoSize = true;
			this.ipcontentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.ipcontentLabel.Location = new System.Drawing.Point(135, 215);
			this.ipcontentLabel.Name = "ipcontentLabel";
			this.ipcontentLabel.Size = new System.Drawing.Size(40, 15);
			this.ipcontentLabel.TabIndex = 15;
			this.ipcontentLabel.Text = "empty";
			// 
			// idContentLabel
			// 
			this.idContentLabel.AutoSize = true;
			this.idContentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.idContentLabel.Location = new System.Drawing.Point(135, 175);
			this.idContentLabel.Name = "idContentLabel";
			this.idContentLabel.Size = new System.Drawing.Size(40, 15);
			this.idContentLabel.TabIndex = 14;
			this.idContentLabel.Text = "empty";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label3.Location = new System.Drawing.Point(403, 234);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(123, 20);
			this.label3.TabIndex = 12;
			this.label3.Text = "Current Effect";
			// 
			// targetModeLabel
			// 
			this.targetModeLabel.AutoSize = true;
			this.targetModeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.targetModeLabel.Location = new System.Drawing.Point(403, 302);
			this.targetModeLabel.Name = "targetModeLabel";
			this.targetModeLabel.Size = new System.Drawing.Size(115, 20);
			this.targetModeLabel.TabIndex = 13;
			this.targetModeLabel.Text = "Target Effect";
			// 
			// comboBox1
			// 
			this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.ImeMode = System.Windows.Forms.ImeMode.On;
			this.comboBox1.Location = new System.Drawing.Point(555, 301);
			this.comboBox1.MaxDropDownItems = 10;
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 23);
			this.comboBox1.TabIndex = 14;
			// 
			// currentModeLabel
			// 
			this.currentModeLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.currentModeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.currentModeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.currentModeLabel.Location = new System.Drawing.Point(555, 234);
			this.currentModeLabel.Name = "currentModeLabel";
			this.currentModeLabel.Size = new System.Drawing.Size(121, 20);
			this.currentModeLabel.TabIndex = 15;
			this.currentModeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// SettingsWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.currentModeLabel);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.targetModeLabel);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.informationBox);
			this.Controls.Add(this.applyButton);
			this.Controls.Add(this.targetColourBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.currentColourBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "SettingsWindow";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SettingsWindow";
			((System.ComponentModel.ISupportInitialize)(this.currentColourBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.targetColourBox)).EndInit();
			this.informationBox.ResumeLayout(false);
			this.informationBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox currentColourBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox targetColourBox;
		private System.Windows.Forms.Button applyButton;
		private System.Windows.Forms.Label informationLabel;
		private System.Windows.Forms.GroupBox informationBox;
		private System.Windows.Forms.Label deviceNameContentLabel;
		private System.Windows.Forms.Label ipcontentLabel;
		private System.Windows.Forms.Label idContentLabel;
		private System.Windows.Forms.Label typeNameContentLabel;
		private System.Windows.Forms.Label productNameContentLabel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label targetModeLabel;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label currentModeLabel;
	}
}