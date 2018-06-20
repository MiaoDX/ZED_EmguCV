# ZED camera in `C#`

This is one *almost* bare SDK and demo to use ZED stereo camera in **C# with Emgu.CV**, **Unity3D is not needed**.

The code is copied from [tomitrescak](https://github.com/tomitrescak) on [https://github.com/stereolabs/zed-unity/issues/15](https://github.com/stereolabs/zed-unity/issues/15) and changed to be suitable with VS2010 with no good support for async mechanism, see original code for more advanced feature with more up-to-date C#. The original code is pruned from the [stereolabs/zed-unity plugin](https://github.com/stereolabs/zed-unity).

And **depth image acquisition** is also included!

NOTE: If only use `Emgu.CV.Image` as container, then both Emgu.CV `2.4.10` and `3.x.x`(3.4.1 tested) is okay.

Usage:

* Add Emgu.CV as Reference and add `bin` into PATH (or copy into the build directory), see [Download_And_Installation](http://www.emgu.com/wiki/index.php/Download_And_Installation) for more info, the `Using the Downloadable packages` is used here to change different versions of Emgu.CV easier
* Copy `sl_unitywrapper.dll`( and `sl_mr_core64.dll`) from [stereolabs/zed-unity plugin](https://github.com/stereolabs/zed-unity) into the build directory
* RUN