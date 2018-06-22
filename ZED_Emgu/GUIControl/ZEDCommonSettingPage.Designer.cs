namespace CameraRelocationSystem.Device
{
    partial class ZEDCommonSettingPage
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.BrightnessLabel = new System.Windows.Forms.Label();
            this.ContrastLabel = new System.Windows.Forms.Label();
            this.HueLabel = new System.Windows.Forms.Label();
            this.SaturationLabel = new System.Windows.Forms.Label();
            this.AWBlabel = new System.Windows.Forms.Label();
            this.BrightnessTrackBar = new System.Windows.Forms.TrackBar();
            this.ContrastTrackBar = new System.Windows.Forms.TrackBar();
            this.HueTrackBar = new System.Windows.Forms.TrackBar();
            this.SaturationTrackBar = new System.Windows.Forms.TrackBar();
            this.AWBTrackBar = new System.Windows.Forms.TrackBar();
            this.BrightnessTextBox = new System.Windows.Forms.TextBox();
            this.ContrastTextBox = new System.Windows.Forms.TextBox();
            this.HueTextBox = new System.Windows.Forms.TextBox();
            this.SaturationTextBox = new System.Windows.Forms.TextBox();
            this.AWBTextBox = new System.Windows.Forms.TextBox();
            this.AWBAutoCheckBox = new System.Windows.Forms.CheckBox();
            this.Gainlabel = new System.Windows.Forms.Label();
            this.GainTrackBar = new System.Windows.Forms.TrackBar();
            this.GainTextBox = new System.Windows.Forms.TextBox();
            this.GECheckBox = new System.Windows.Forms.CheckBox();
            this.Exposurelabel = new System.Windows.Forms.Label();
            this.ExposureTrackBar = new System.Windows.Forms.TrackBar();
            this.ExposureTextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HueTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaturationTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AWBTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GainTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExposureTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // BrightnessLabel
            // 
            this.BrightnessLabel.AutoSize = true;
            this.BrightnessLabel.Location = new System.Drawing.Point(107, 27);
            this.BrightnessLabel.Name = "BrightnessLabel";
            this.BrightnessLabel.Size = new System.Drawing.Size(71, 12);
            this.BrightnessLabel.TabIndex = 0;
            this.BrightnessLabel.Text = "Brightness:";
            // 
            // ContrastLabel
            // 
            this.ContrastLabel.AutoSize = true;
            this.ContrastLabel.Location = new System.Drawing.Point(107, 78);
            this.ContrastLabel.Name = "ContrastLabel";
            this.ContrastLabel.Size = new System.Drawing.Size(59, 12);
            this.ContrastLabel.TabIndex = 2;
            this.ContrastLabel.Text = "Contrast:";
            // 
            // HueLabel
            // 
            this.HueLabel.AutoSize = true;
            this.HueLabel.Location = new System.Drawing.Point(101, 129);
            this.HueLabel.Name = "HueLabel";
            this.HueLabel.Size = new System.Drawing.Size(29, 12);
            this.HueLabel.TabIndex = 4;
            this.HueLabel.Text = "Hue:";
            // 
            // SaturationLabel
            // 
            this.SaturationLabel.AutoSize = true;
            this.SaturationLabel.Location = new System.Drawing.Point(95, 179);
            this.SaturationLabel.Name = "SaturationLabel";
            this.SaturationLabel.Size = new System.Drawing.Size(71, 12);
            this.SaturationLabel.TabIndex = 5;
            this.SaturationLabel.Text = "Saturation:";
            // 
            // AWBlabel
            // 
            this.AWBlabel.AutoSize = true;
            this.AWBlabel.Location = new System.Drawing.Point(95, 223);
            this.AWBlabel.Name = "AWBlabel";
            this.AWBlabel.Size = new System.Drawing.Size(29, 12);
            this.AWBlabel.TabIndex = 16;
            this.AWBlabel.Text = "AWB:";
            // 
            // BrightnessTrackBar
            // 
            this.BrightnessTrackBar.BackColor = System.Drawing.SystemColors.Control;
            this.BrightnessTrackBar.LargeChange = 3;
            this.BrightnessTrackBar.Location = new System.Drawing.Point(184, 23);
            this.BrightnessTrackBar.Maximum = 8;
            this.BrightnessTrackBar.Name = "BrightnessTrackBar";
            this.BrightnessTrackBar.Size = new System.Drawing.Size(202, 45);
            this.BrightnessTrackBar.TabIndex = 18;
            this.BrightnessTrackBar.TickFrequency = 100;
            this.BrightnessTrackBar.Value = 8;
            this.BrightnessTrackBar.Scroll += new System.EventHandler(this.BrightnessTrackBar_Scroll);
            // 
            // ContrastTrackBar
            // 
            this.ContrastTrackBar.LargeChange = 3;
            this.ContrastTrackBar.Location = new System.Drawing.Point(184, 74);
            this.ContrastTrackBar.Maximum = 8;
            this.ContrastTrackBar.Name = "ContrastTrackBar";
            this.ContrastTrackBar.Size = new System.Drawing.Size(202, 45);
            this.ContrastTrackBar.TabIndex = 19;
            this.ContrastTrackBar.Scroll += new System.EventHandler(this.ContrastTrackBar_Scroll);
            // 
            // HueTrackBar
            // 
            this.HueTrackBar.LargeChange = 3;
            this.HueTrackBar.Location = new System.Drawing.Point(184, 125);
            this.HueTrackBar.Maximum = 11;
            this.HueTrackBar.Name = "HueTrackBar";
            this.HueTrackBar.Size = new System.Drawing.Size(202, 45);
            this.HueTrackBar.TabIndex = 20;
            this.HueTrackBar.Scroll += new System.EventHandler(this.HueTrackBar_Scroll);
            // 
            // SaturationTrackBar
            // 
            this.SaturationTrackBar.LargeChange = 3;
            this.SaturationTrackBar.Location = new System.Drawing.Point(184, 172);
            this.SaturationTrackBar.Maximum = 8;
            this.SaturationTrackBar.Name = "SaturationTrackBar";
            this.SaturationTrackBar.Size = new System.Drawing.Size(202, 45);
            this.SaturationTrackBar.TabIndex = 21;
            this.SaturationTrackBar.Scroll += new System.EventHandler(this.SaturationTrackBar_Scroll);
            // 
            // AWBTrackBar
            // 
            this.AWBTrackBar.Location = new System.Drawing.Point(184, 223);
            this.AWBTrackBar.Maximum = 65;
            this.AWBTrackBar.Minimum = 26;
            this.AWBTrackBar.Name = "AWBTrackBar";
            this.AWBTrackBar.Size = new System.Drawing.Size(202, 45);
            this.AWBTrackBar.TabIndex = 22;
            this.AWBTrackBar.Value = 65;
            this.AWBTrackBar.Scroll += new System.EventHandler(this.AWBTrackBar_Scroll);
            // 
            // BrightnessTextBox
            // 
            this.BrightnessTextBox.Enabled = false;
            this.BrightnessTextBox.Location = new System.Drawing.Point(405, 24);
            this.BrightnessTextBox.Name = "BrightnessTextBox";
            this.BrightnessTextBox.Size = new System.Drawing.Size(41, 21);
            this.BrightnessTextBox.TabIndex = 23;
            this.BrightnessTextBox.Text = "0";
            // 
            // ContrastTextBox
            // 
            this.ContrastTextBox.Enabled = false;
            this.ContrastTextBox.Location = new System.Drawing.Point(405, 75);
            this.ContrastTextBox.Name = "ContrastTextBox";
            this.ContrastTextBox.Size = new System.Drawing.Size(41, 21);
            this.ContrastTextBox.TabIndex = 24;
            this.ContrastTextBox.Text = "0";
            // 
            // HueTextBox
            // 
            this.HueTextBox.Enabled = false;
            this.HueTextBox.Location = new System.Drawing.Point(405, 125);
            this.HueTextBox.Name = "HueTextBox";
            this.HueTextBox.Size = new System.Drawing.Size(41, 21);
            this.HueTextBox.TabIndex = 25;
            this.HueTextBox.Text = "0";
            // 
            // SaturationTextBox
            // 
            this.SaturationTextBox.Enabled = false;
            this.SaturationTextBox.Location = new System.Drawing.Point(405, 176);
            this.SaturationTextBox.Name = "SaturationTextBox";
            this.SaturationTextBox.Size = new System.Drawing.Size(41, 21);
            this.SaturationTextBox.TabIndex = 26;
            this.SaturationTextBox.Text = "0";
            // 
            // AWBTextBox
            // 
            this.AWBTextBox.Enabled = false;
            this.AWBTextBox.Location = new System.Drawing.Point(405, 223);
            this.AWBTextBox.Name = "AWBTextBox";
            this.AWBTextBox.Size = new System.Drawing.Size(41, 21);
            this.AWBTextBox.TabIndex = 27;
            this.AWBTextBox.Text = "0";
            // 
            // AWBAutoCheckBox
            // 
            this.AWBAutoCheckBox.AutoSize = true;
            this.AWBAutoCheckBox.Location = new System.Drawing.Point(456, 225);
            this.AWBAutoCheckBox.Name = "AWBAutoCheckBox";
            this.AWBAutoCheckBox.Size = new System.Drawing.Size(48, 16);
            this.AWBAutoCheckBox.TabIndex = 28;
            this.AWBAutoCheckBox.Text = "Auto";
            this.AWBAutoCheckBox.UseVisualStyleBackColor = true;
            this.AWBAutoCheckBox.CheckedChanged += new System.EventHandler(this.AWBAutoCheckBox_CheckedChanged);
            // 
            // Gainlabel
            // 
            this.Gainlabel.AutoSize = true;
            this.Gainlabel.Location = new System.Drawing.Point(101, 278);
            this.Gainlabel.Name = "Gainlabel";
            this.Gainlabel.Size = new System.Drawing.Size(35, 12);
            this.Gainlabel.TabIndex = 29;
            this.Gainlabel.Text = "Gain:";
            // 
            // GainTrackBar
            // 
            this.GainTrackBar.LargeChange = 30;
            this.GainTrackBar.Location = new System.Drawing.Point(184, 274);
            this.GainTrackBar.Maximum = 100;
            this.GainTrackBar.Name = "GainTrackBar";
            this.GainTrackBar.Size = new System.Drawing.Size(202, 45);
            this.GainTrackBar.SmallChange = 10;
            this.GainTrackBar.TabIndex = 30;
            this.GainTrackBar.Scroll += new System.EventHandler(this.GainTrackBar_Scroll);
            // 
            // GainTextBox
            // 
            this.GainTextBox.Enabled = false;
            this.GainTextBox.Location = new System.Drawing.Point(405, 278);
            this.GainTextBox.Name = "GainTextBox";
            this.GainTextBox.Size = new System.Drawing.Size(41, 21);
            this.GainTextBox.TabIndex = 31;
            this.GainTextBox.Text = "0";
            // 
            // GECheckBox
            // 
            this.GECheckBox.AutoSize = true;
            this.GECheckBox.Location = new System.Drawing.Point(456, 303);
            this.GECheckBox.Name = "GECheckBox";
            this.GECheckBox.Size = new System.Drawing.Size(48, 16);
            this.GECheckBox.TabIndex = 32;
            this.GECheckBox.Text = "Auto";
            this.GECheckBox.UseVisualStyleBackColor = true;
            this.GECheckBox.CheckedChanged += new System.EventHandler(this.GECheckBox_CheckedChanged);
            // 
            // Exposurelabel
            // 
            this.Exposurelabel.AutoSize = true;
            this.Exposurelabel.Location = new System.Drawing.Point(95, 331);
            this.Exposurelabel.Name = "Exposurelabel";
            this.Exposurelabel.Size = new System.Drawing.Size(59, 12);
            this.Exposurelabel.TabIndex = 33;
            this.Exposurelabel.Text = "Exposure:";
            // 
            // ExposureTrackBar
            // 
            this.ExposureTrackBar.LargeChange = 30;
            this.ExposureTrackBar.Location = new System.Drawing.Point(184, 325);
            this.ExposureTrackBar.Maximum = 100;
            this.ExposureTrackBar.Name = "ExposureTrackBar";
            this.ExposureTrackBar.Size = new System.Drawing.Size(202, 45);
            this.ExposureTrackBar.SmallChange = 10;
            this.ExposureTrackBar.TabIndex = 34;
            this.ExposureTrackBar.Scroll += new System.EventHandler(this.ExposureTrackBar_Scroll);
            // 
            // ExposureTextBox
            // 
            this.ExposureTextBox.Enabled = false;
            this.ExposureTextBox.Location = new System.Drawing.Point(405, 331);
            this.ExposureTextBox.Name = "ExposureTextBox";
            this.ExposureTextBox.Size = new System.Drawing.Size(41, 21);
            this.ExposureTextBox.TabIndex = 35;
            this.ExposureTextBox.Text = "0";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(230, 376);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 36;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // ZEDCommonSettingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ExposureTextBox);
            this.Controls.Add(this.ExposureTrackBar);
            this.Controls.Add(this.Exposurelabel);
            this.Controls.Add(this.GECheckBox);
            this.Controls.Add(this.GainTextBox);
            this.Controls.Add(this.GainTrackBar);
            this.Controls.Add(this.Gainlabel);
            this.Controls.Add(this.AWBAutoCheckBox);
            this.Controls.Add(this.AWBTextBox);
            this.Controls.Add(this.SaturationTextBox);
            this.Controls.Add(this.HueTextBox);
            this.Controls.Add(this.ContrastTextBox);
            this.Controls.Add(this.BrightnessTextBox);
            this.Controls.Add(this.AWBTrackBar);
            this.Controls.Add(this.SaturationTrackBar);
            this.Controls.Add(this.HueTrackBar);
            this.Controls.Add(this.ContrastTrackBar);
            this.Controls.Add(this.BrightnessTrackBar);
            this.Controls.Add(this.AWBlabel);
            this.Controls.Add(this.SaturationLabel);
            this.Controls.Add(this.HueLabel);
            this.Controls.Add(this.ContrastLabel);
            this.Controls.Add(this.BrightnessLabel);
            this.Name = "ZEDCommonSettingPage";
            this.Size = new System.Drawing.Size(514, 438);
            ((System.ComponentModel.ISupportInitialize)(this.BrightnessTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContrastTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HueTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SaturationTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AWBTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GainTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExposureTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BrightnessLabel;
        private System.Windows.Forms.Label ContrastLabel;
        private System.Windows.Forms.Label HueLabel;
        private System.Windows.Forms.Label SaturationLabel;
        private System.Windows.Forms.Label AWBlabel;
        private System.Windows.Forms.TrackBar BrightnessTrackBar;
        private System.Windows.Forms.TrackBar ContrastTrackBar;
        private System.Windows.Forms.TrackBar HueTrackBar;
        private System.Windows.Forms.TrackBar SaturationTrackBar;
        private System.Windows.Forms.TrackBar AWBTrackBar;
        private System.Windows.Forms.TextBox BrightnessTextBox;
        private System.Windows.Forms.TextBox ContrastTextBox;
        private System.Windows.Forms.TextBox HueTextBox;
        private System.Windows.Forms.TextBox SaturationTextBox;
        private System.Windows.Forms.TextBox AWBTextBox;
        private System.Windows.Forms.CheckBox AWBAutoCheckBox;
        private System.Windows.Forms.Label Gainlabel;
        private System.Windows.Forms.TrackBar GainTrackBar;
        private System.Windows.Forms.TextBox GainTextBox;
        private System.Windows.Forms.CheckBox GECheckBox;
        private System.Windows.Forms.Label Exposurelabel;
        private System.Windows.Forms.TrackBar ExposureTrackBar;
        private System.Windows.Forms.TextBox ExposureTextBox;
        private System.Windows.Forms.Button ResetButton;
    }
}
