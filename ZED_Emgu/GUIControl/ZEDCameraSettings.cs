using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;
using ZED_Emgu.Cameras;

namespace CameraRelocationSystem.Device
{
    public partial class ZEDCameraSettings : Form
    {
        private Zed camera = null;
        private bool isConnected = false;

        private ZEDCommonSettingPage commonPage = null;


        public ZEDCameraSettings()
        {
            InitializeComponent();
            CreatePages();
        }


        public void showWindows()
        {
            try
            {
                commonPage.setCamera(this.camera.Camera);
                commonPage.setConnectStatus(true);

                commonPage.changeGUIFromCurrentSettings(); // INIT GUI();
                
                Show();
                
            }
            catch (Exception e)
            {
                Debug.WriteLine("Unable to initialization Camera Settings");
                isConnected = false;
                return;
            }
        }

        public void Connect(Zed camera)
        {
            lock (this)
            {
                if (camera == null)
                {
                    Debug.WriteLine("Connecting a null Camera.");
                    return;
                }

                if (isConnected == true)
                {
                    Disconnected();
                }

                this.camera = camera;
                isConnected = true;
                Debug.WriteLine("Connected to a Camera");
            }
        }

        public void Disconnected()
        {
            lock (this)
            {
                camera = null;
                isConnected = false;
                Debug.WriteLine("Disconnected from Camera");
            }
        }

        private void CreatePages()
        {
            InitCommonSettingsPage();
        }

        private void InitCommonSettingsPage()
        {
            CommonSettingsTabPage.Controls.Clear();
            commonPage = new ZEDCommonSettingPage();
            commonPage.Dock = DockStyle.Fill;
            CommonSettingsTabPage.Controls.Add(commonPage);
        }


        // See http://msdn.microsoft.com/en-us/library/ms404305(v=VS.100).aspx
        // for why we have to draw it manually
        private void ZEDSettingsTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush currentTextBrush;
            TabPage currentTabPage = ZEDSettingsTabControl.TabPages[e.Index];
            Rectangle tabBounds = ZEDSettingsTabControl.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                // Draw a different background color, and don't paint a focus rectangle.
                currentTextBrush = SystemBrushes.ActiveCaptionText;
                g.FillRectangle(SystemBrushes.ActiveCaption, e.Bounds);
            }
            else
            {
                currentTextBrush = new System.Drawing.SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            Font currentTabFont = new Font("Tahoma", 11F, FontStyle.Regular, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat stringFlags = new StringFormat();
            stringFlags.Alignment = StringAlignment.Center;
            stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(
                currentTabPage.Text,
                currentTabFont,
                currentTextBrush,
                tabBounds,
                new StringFormat(stringFlags));

        }

        private void ZEDCameraSettings_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Disconnected();
            this.Hide();
        }

        private void ZEDCameraSettings_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
