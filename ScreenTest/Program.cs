/*
 * 
 * This is where I would put the MIT license!
 */

using FFMpegCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ScreenTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (true)
            for (int i = 0; i < 30; i++)
            {
                var bounds = new Rectangle();
                bounds = Screen.PrimaryScreen.Bounds;
                ScreenHelper.TakeAndSave(@".\images\", $"{DateTime.Now.Ticks}-shot.png", bounds, ImageFormat.Png);
                Thread.Sleep(3 * 1000);
            }

            WriteVideo();
        }

        private static void WriteVideo()
        {
            var images = Directory.GetFiles(".\\images", "*png");

            var imageInfo = new List<ImageInfo>();
            foreach (var image in images)
            {
                imageInfo.Add(ImageInfo.FromPath(image));
                imageInfo.Add(ImageInfo.FromPath(image));
                imageInfo.Add(ImageInfo.FromPath(image));
            }

            FFMpeg.JoinImageSequence("test.mp4", 30, imageInfo.ToArray());
        }
    }
}
