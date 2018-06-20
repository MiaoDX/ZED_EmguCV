using Emgu.CV;
using Emgu.CV.Structure;
using sl;
using System;
using System.Collections.Generic;
using System.Threading;

namespace ZED_Emgu.Cameras
{
    public class Zed
    {
        ZEDCamera camera;
        InitParameters initParameters;
        object grabLock = new object();

        ERROR_CODE lastInitStatus = ERROR_CODE.ERROR_CODE_LAST;
        ERROR_CODE previousInitStatus;
        private bool running;
        private int stride;

        List<ZEDMat> mats;

        int matIndex;
        private RuntimeParameters runtimeParameters;

        // properties

        public event Action<Zed> FrameTick;

        // public ZEDCamera Camera => this.camera;
 
        public ZEDCamera Camera
        {
            get {return this.camera;}
        }


        public RuntimeParameters RuntimeParameters
        {
            get { return this.runtimeParameters; }
            set { this.runtimeParameters = value; }
        }
        //public RuntimeParameters RuntimeParameters{get; set;}

        /*
        public Image<Bgra, byte> Left => this.FetchImage(VIEW.LEFT);
        public Image<Bgra, byte> Right => this.FetchImage(VIEW.RIGHT);
        public Image<Bgra, byte> Depth => this.FetchImage(VIEW.DEPTH);
        public Image<Bgra, byte> Confidence => this.FetchImage(VIEW.CONFIDENCE);
        public Image<Bgra, byte> LeftGrey => this.FetchImage(VIEW.LEFT_GREY);
        public Image<Bgra, byte> RightGrey => this.FetchImage(VIEW.RIGHT_GREY);
        public Image<Bgra, byte> SideBySide => this.FetchImage(VIEW.SIDE_BY_SIDE);
        */

        public Image<Bgra, byte> Left
        {
            get {return this.FetchImage(VIEW.LEFT);}
        }
        public Image<Bgra, byte> Right
        {
            get {return this.FetchImage(VIEW.RIGHT);}
        }


        // constructor

        //public Zed(string svoPath) : this(null, svoPath) { }

        public Zed(InitParameters parameters = null, string svoPath = null)
        {
            camera = ZEDCamera.GetInstance();

            mats = new List<ZEDMat>();

            if (parameters == null)
            {
                parameters = new InitParameters();
                parameters.resolution = RESOLUTION.HD720;
                parameters.depthMode = DEPTH_MODE.MEDIUM;
                parameters.depthStabilization = true;
                parameters.enableRightSideMeasure = true; // isStereoRig;

                parameters.coordinateUnit = UNIT.MILLIMETER;
                parameters.depthMinimumDistance = 200f;
                //parameters.depthMinimumDistance = 0.2f;
            }

            if (svoPath != null)
            {
                parameters.pathSVO = svoPath;
            }

            this.initParameters = parameters;

            // runtime parameters
            runtimeParameters = new RuntimeParameters()
            {
                sensingMode = SENSING_MODE.FILL,
                enableDepth = true
            };

            // create the camera
            camera.CreateCamera(true);
        }

        public Zed(RESOLUTION resolution, DEPTH_MODE depthMode = DEPTH_MODE.PERFORMANCE, bool stabilisation = false)
            : this(new InitParameters
            {
                resolution = resolution,
                depthMode = depthMode,
                depthStabilization = stabilisation,
                enableRightSideMeasure = true,

                coordinateUnit = UNIT.MILLIMETER,
                depthMinimumDistance = 200f
                //depthMinimumDistance = 0.2f
            })
        { }

        public Image<Bgra, byte> FetchImage(VIEW view)
        {
            if (mats.Count < matIndex + 1)
            {
                mats.Add(new ZEDMat());
            }
            var mat = mats[matIndex++];
            camera.RetrieveImage(mat, view);
            //Console.WriteLine("GetInfos:{0}", mat.GetInfos());
            return new Image<Bgra, byte>(camera.ImageWidth, camera.ImageHeight, stride, mat.GetPtr());
        }


        public Image<Gray, ushort> FetchDepth16U()
        {

            if (mats.Count < matIndex + 1)
            {
                mats.Add(new ZEDMat());
            }
            var depth_zed = mats[matIndex++];
            camera.RetrieveMeasure(depth_zed, MEASURE.DEPTH);

            //ZEDMat depth_zed = new ZEDMat((uint)camera.ImageWidth, (uint)camera.ImageHeight, ZEDMat.MAT_TYPE.MAT_32F_C1);
            //ZEDMat depth_zed = new ZEDMat();
            //camera.RetrieveMeasure(depth_zed, MEASURE.DEPTH);

            //Console.WriteLine("depth_zed.GetType:{0}", depth_zed.GetType());
            //Console.WriteLine("depth_zed.GetResolution:{0}", depth_zed.GetResolution());
            //Console.WriteLine("depth_zed.GetPixelBytes:{0}", depth_zed.GetPixelBytes());
            //Console.WriteLine("GetInfos:{0}", depth_zed.GetInfos());

            //Image<Emgu.CV.Structure.Gray, float> im_32f = new Image<Gray, float>(camera.ImageWidth, camera.ImageHeight, stride, depth_zed.GetPtr());
            //Image<Emgu.CV.Structure.Gray, ushort> im = im_32f.Convert<Gray, ushort>();
            //Console.WriteLine("im.Size:{0}, im.GetType:{1},  im.Height:{2}, im.Width:{3}, im.NumberOfChannels:{4}", im.Size, im.GetType(), im.Height, im.Width, im.NumberOfChannels);         

            return new Image<Gray, float>(camera.ImageWidth, camera.ImageHeight, stride, depth_zed.GetPtr()).Convert<Gray, ushort>();
        }
                

        public void InitZED_Sequential()
        {
            while (lastInitStatus != sl.ERROR_CODE.SUCCESS)
            {
                lastInitStatus = camera.Init(ref initParameters);
                if (lastInitStatus != sl.ERROR_CODE.SUCCESS)
                {
                    lastInitStatus = camera.Init(ref initParameters);
                    previousInitStatus = lastInitStatus;
                }
                Thread.Sleep(300);
            }

            // init stride
            stride = 4 * ((camera.ImageWidth * 32 + 31) / 32);
            Console.WriteLine("Stride is:{0}.", stride);
        }

        public void Start_Sequential()
        {
            InitZED_Sequential();
            running = true;
        }

        public void GrabOnce()
        {

            if (running)
            {
                lock (grabLock)
                {
                    sl.ERROR_CODE e = camera.Grab(ref runtimeParameters);
                    // reset mat index
                    matIndex = 0;                    
                    Thread.Sleep(10);
                }
            }
            else
            {
                Console.WriteLine("Not open");
                Thread.Sleep(10);
            }
        }

        public void Stop()
        {
            this.running = false;
        }

        public void Close()
        {
            camera.Destroy();
        }
    }

}