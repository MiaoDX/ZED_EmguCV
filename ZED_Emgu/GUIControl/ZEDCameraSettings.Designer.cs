namespace CameraRelocationSystem.Device
{
    partial class ZEDCameraSettings
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
            this.CommonSettingsTabPage = new System.Windows.Forms.TabPage();
            this.ZEDSettingsTabControl = new System.Windows.Forms.TabControl();
            this.ZEDSettingsTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // CommonSettingsTabPage
            // 
            this.CommonSettingsTabPage.BackColor = System.Drawing.Color.White;
            this.CommonSettingsTabPage.Location = new System.Drawing.Point(154, 4);
            this.CommonSettingsTabPage.Name = "CommonSettingsTabPage";
            this.CommonSettingsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CommonSettingsTabPage.Size = new System.Drawing.Size(626, 538);
            this.CommonSettingsTabPage.TabIndex = 0;
            this.CommonSettingsTabPage.Text = "CommonSettings";
            // 
            // ZEDSettingsTabControl
            // 
            this.ZEDSettingsTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.ZEDSettingsTabControl.Controls.Add(this.CommonSettingsTabPage);
            this.ZEDSettingsTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZEDSettingsTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.ZEDSettingsTabControl.ItemSize = new System.Drawing.Size(30, 150);
            this.ZEDSettingsTabControl.Location = new System.Drawing.Point(0, 0);
            this.ZEDSettingsTabControl.Multiline = true;
            this.ZEDSettingsTabControl.Name = "ZEDSettingsTabControl";
            this.ZEDSettingsTabControl.Padding = new System.Drawing.Point(3, 6);
            this.ZEDSettingsTabControl.SelectedIndex = 0;
            this.ZEDSettingsTabControl.Size = new System.Drawing.Size(784, 546);
            this.ZEDSettingsTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.ZEDSettingsTabControl.TabIndex = 0;
            this.ZEDSettingsTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ZEDSettingsTabControl_DrawItem);
            // 
            // ZEDCameraSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 546);
            this.Controls.Add(this.ZEDSettingsTabControl);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 584);
            this.MinimumSize = new System.Drawing.Size(800, 584);
            this.Name = "ZEDCameraSettings";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ZEDCameraSettings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ZEDCameraSettings_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ZEDCameraSettings_FormClosed);
            this.ZEDSettingsTabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage CommonSettingsTabPage;
        private System.Windows.Forms.TabControl ZEDSettingsTabControl;

    }
}