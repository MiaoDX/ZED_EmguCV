using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Diagnostics;
using ZED_Emgu.Cameras;
using sl;

namespace CameraRelocationSystem.Device
{
    public partial class ZEDCommonSettingPage : UserControl
    {
        protected ZEDCamera m_camera = null;
        protected bool m_isConnected = false;
        protected bool m_isPageSelected = false;

        //protected ZEDCameraSettingsManager

        public ZEDCommonSettingPage()
        {
            InitializeComponent();
        }

        public ZEDCommonSettingPage(Zed camera)
        {
            InitializeComponent();
            setCamera(camera.Camera);
        }

        public void setCamera(ZEDCamera camera)
        {
            m_camera = camera;
        }

        public void setConnectStatus(bool isConnected)
        {
            m_isConnected = isConnected;
            if (isConnected == false && m_camera != null)
            {
                m_camera = null;
            }
        }

        public void IsPageSelected(bool isSelected)
        {
            m_isPageSelected = isSelected;
        }



        private void BrightnessTrackBar_Scroll(object sender, EventArgs e)
        {
            int v = BrightnessTrackBar.Value;
            m_camera.SetCameraSettings(sl.CAMERA_SETTINGS.BRIGHTNESS, v, false);
            BrightnessTextBox.Text = v.ToString();
        }

        private void ContrastTrackBar_Scroll(object sender, EventArgs e)
        {
            int v = ContrastTrackBar.Value;
            m_camera.SetCameraSettings(sl.CAMERA_SETTINGS.CONTRAST, v, false);
            ContrastTextBox.Text = v.ToString();
        }

        private void HueTrackBar_Scroll(object sender, EventArgs e)
        {
            int v = HueTrackBar.Value;
            m_camera.SetCameraSettings(sl.CAMERA_SETTINGS.HUE, v, false);
            HueTextBox.Text = v.ToString();
        }

        private void SaturationTrackBar_Scroll(object sender, EventArgs e)
        {
            int v = SaturationTrackBar.Value;
            m_camera.SetCameraSettings(sl.CAMERA_SETTINGS.SATURATION, v, false);
            SaturationTextBox.Text = v.ToString();
        }






        private void AWBAutoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;

            int v = AWBTrackBar.Value;

            if (cb.Checked)
            {
                AWBTrackBar.Enabled = false;
                m_camera.SetCameraSettings(sl.CAMERA_SETTINGS.WHITEBALANCE, v, true);
            }
            else
            {
                AWBTrackBar.Enabled = true;
                m_camera.SetCameraSettings(sl.CAMERA_SETTINGS.WHITEBALANCE, v * 100, false);
                AWBTextBox.Text = (v * 100).ToString();
            }
        }

        private void AWBTrackBar_Scroll(object sender, EventArgs e)
        {
            CheckBox cb = AWBAutoCheckBox;

            int v = AWBTrackBar.Value;            
            
            if (cb.Checked) // AUTO
            {
                AWBTrackBar.Enabled = false;
            }
            else
            {
                AWBTrackBar.Enabled = true;
                m_camera.SetCameraSettings(sl.CAMERA_SETTINGS.WHITEBALANCE, v*100, false);
            }

            AWBTextBox.Text = (v * 100).ToString();

        }





        private void GECheckBox_CheckedChanged(object sender, EventArgs e)
        {
            changeGEValue();
        }

        private void GainTrackBar_Scroll(object sender, EventArgs e)
        {
            changeGEValue();
        }

        private void ExposureTrackBar_Scroll(object sender, EventArgs e)
        {
            changeGEValue();
        }

        private void changeGEValue()
        {
            CheckBox cb = GECheckBox;

            int v_g = GainTrackBar.Value;
            int v_e = ExposureTrackBar.Value;

            if (cb.Checked)
            {
                GainTrackBar.Enabled = false;
                ExposureTrackBar.Enabled = false;

                m_camera.SetCameraSettings(sl.CAMERA_SETTINGS.GAIN, v_g, true);
                m_camera.SetCameraSettings(sl.CAMERA_SETTINGS.EXPOSURE, v_e, true);
            }
            else
            {
                GainTrackBar.Enabled = true;
                ExposureTrackBar.Enabled = true;

                m_camera.SetCameraSettings(sl.CAMERA_SETTINGS.GAIN, v_g, false);
                m_camera.SetCameraSettings(sl.CAMERA_SETTINGS.EXPOSURE, v_e, false);

                GainTextBox.Text = v_g.ToString();
                ExposureTextBox.Text = v_e.ToString();
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetValues(true);
        }

        public void changeGUIFromCurrentSettings()
        {
            m_camera.RetrieveCameraSettings();
            ZEDCameraSettingsManager.CameraSettings settings = m_camera.GetCameraSettings();
            bool GEAuto = m_camera.GetExposureUpdateType();
            bool whiteBalanceAuto = m_camera.GetWhiteBalanceUpdateType();

            int hue = settings.Hue;
            int brightness = settings.Brightness;
            int contrast = settings.Contrast;
            int saturation = settings.Saturation;

            int exposure = settings.Exposure;
            int gain = settings.Gain;

            int whiteBalance = settings.WhiteBalance;

            m_camera.SetCameraSettings(sl.CAMERA_SETTINGS.GAIN, gain, GEAuto);
            m_camera.SetCameraSettings(sl.CAMERA_SETTINGS.EXPOSURE, exposure, GEAuto);
            m_camera.SetCameraSettings(sl.CAMERA_SETTINGS.WHITEBALANCE, whiteBalance, whiteBalanceAuto);

            

            // GUI
            BrightnessTrackBar.Value = brightness;
            BrightnessTextBox.Text = brightness.ToString();

            ContrastTrackBar.Value = contrast;
            ContrastTextBox.Text = contrast.ToString();
            
            HueTrackBar.Value = hue;
            HueTextBox.Text = hue.ToString();

            SaturationTrackBar.Value = saturation;
            SaturationTextBox.Text = saturation.ToString();




            AWBAutoCheckBox.Checked = whiteBalanceAuto;
            if (AWBAutoCheckBox.Checked) // AUTO
            {
                AWBTrackBar.Enabled = false;
            }
            else
            {
                AWBTrackBar.Enabled = true;
            }


            GECheckBox.Checked = GEAuto;
            if (GECheckBox.Checked)
            {
                GainTrackBar.Enabled = false;
                ExposureTrackBar.Enabled = false;
            }
            else
            {
                GainTrackBar.Enabled = true;
                ExposureTrackBar.Enabled = true;
            }

        }


        private void ResetValues(bool auto)
        {

            const int cbrightness = 4;
            const int ccontrast = 4;
            const int chue = 0;
            const int csaturation = 4;
            const int cwhiteBalance = 2600;

            m_camera.SetCameraSettings(sl.CAMERA_SETTINGS.BRIGHTNESS, cbrightness, false);
            m_camera.SetCameraSettings(sl.CAMERA_SETTINGS.CONTRAST, ccontrast, false);
            m_camera.SetCameraSettings(sl.CAMERA_SETTINGS.HUE, 0, false);
            m_camera.SetCameraSettings(sl.CAMERA_SETTINGS.SATURATION, csaturation, false);

            if (auto) // NOT so sure why no action when auto==false, the reference code is like this
            {
                m_camera.SetCameraSettings(sl.CAMERA_SETTINGS.WHITEBALANCE, cwhiteBalance, true);
                m_camera.SetCameraSettings(sl.CAMERA_SETTINGS.GAIN, 0, true); // NOTE 0, should has no imapct
                m_camera.SetCameraSettings(sl.CAMERA_SETTINGS.EXPOSURE, 0, true);
            }

            changeGUIFromCurrentSettings();
        }

    }
}
