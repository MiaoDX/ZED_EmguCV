using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using ZED_Emgu.Cameras;
using sl;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Threading;
using System.Drawing;


namespace ZED_Emgu
{
    static class Program
    {
 
        static void Main(string[] args)
        {
            Zed zed_cam = new Zed();

            zed_cam.Start_Sequential();

            int show_time = 10;

            for (int i = 0; i < show_time; i++)
            {
                zed_cam.GrabOnce();
                Image<Bgra, byte> image_zed_left = zed_cam.Left;
                CvInvoke.cvShowImage("Left", image_zed_left);
                //CvInvoke.Imshow("Left", image_zed_left);
                Image<Bgra, byte> image_zed_right = zed_cam.Right;                
                CvInvoke.cvShowImage("Right", image_zed_right);
                //CvInvoke.Imshow("Right", image_zed_right);

                //CvInvoke.WaitKey(25);
                CvInvoke.cvWaitKey(25);

            }

            zed_cam.GrabOnce();
            Bitmap left_im = (Bitmap)zed_cam.Left.ToBitmap().Clone();
            Console.WriteLine("left_im.Size:{0}", left_im.Size);
            left_im.Save("left_save_cv.png");

            Image<Gray, ushort> depth_im = zed_cam.FetchDepth16U();

            //CvInvoke.Imwrite("depth_save_cv.png", depth_im);            
            depth_im.Save("depth_save_cv.png");

            zed_cam.Close();
        }
    }
    
}
