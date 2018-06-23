// Form1.cs
using sl;
using System;
using System.Windows.Forms;
using ZED_Emgu.Cameras;
using System.Diagnostics;
using CameraRelocationSystem.Device;

namespace ZedTester
{


    public partial class Form1 : Form
    {

        VIEW view;
        Zed zed = null;

        public Form1()
        {
            InitializeComponent();

            // find version
            var versionZED = "[SDK]: " + sl.ZEDCamera.GetSDKVersion().ToString() + " [Plugin]: " + sl.ZEDCamera.PluginVersion.ToString();
            this.versionInfo.Text = versionZED;

            this.Start();

            Console.WriteLine("HOPE HERE!!");

            /*
            while (true)
            { }
             */ 
        }

        void Start()
        {
            // start with stored SVO
            //var zed = new Zed(@"c:\Projects\files\HD720_SN17600_11-04-52.svo");

            // start with live feed
            zed = new Zed();

            // You need to assign the listener that will execute in each camera loop
            // in this case I named it AcquireImages and implemented it below
            zed.FrameTick += this.AcquireImages;
            zed.RuntimeParameters = new RuntimeParameters
            {
                sensingMode = SENSING_MODE.FILL,
                enableDepth = true
            };
            //zed.Start();
            //zed.Start_Sequential();
            zed.Start_with_Thread();
        }

        private void AcquireImages(Zed zed)
        {
            try
            {
                imageBox1.Invoke((MethodInvoker)delegate
                {
                    // you can use method FetchImage or any of the helper methods
                    // e.g. zed.Left, zed.Right, zed.Depth ...
                    var image = zed.FetchImage(view);
                    imageBox1.Image = image;
                });
            }
            catch { }

        }





        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Is: " + ZEDCamera.CheckPlugin());
        }


        private void sourceSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (sourceSelection.SelectedIndex)
            {
                case 0:
                    view = sl.VIEW.LEFT;
                    break;
                case 1:
                    view = sl.VIEW.RIGHT;
                    break;
                case 2:
                    view = sl.VIEW.SIDE_BY_SIDE;
                    break;
                case 3:
                    view = sl.VIEW.DEPTH;
                    break;
                case 4:
                    view = sl.VIEW.CONFIDENCE;
                    break;
                case 5:
                    view = sl.VIEW.NORMALS;
                    break;
                case 6:
                    view = sl.VIEW.LEFT_UNRECTIFIED;
                    break;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ZEDCameraSettings cameraSetting = new ZEDCameraSettings();
            cameraSetting.Connect(zed);
            cameraSetting.showWindows();
        }


    }
}