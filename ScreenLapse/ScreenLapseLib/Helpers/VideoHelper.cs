/*
MIT License
Copyright(c) 2021 Kyle Givler
https://github.com/JoyfulReaper
Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

using FFMpegCore;
using System.Collections.Generic;
using System.IO;

namespace ScreenLapseLib.Helpers
{
    public static class VideoHelper
    {
        public static bool CreateVideoFromImages(string path, string filename, string inputPath, int frameRepeat = 3, int frameRate = 30)
        {
            var inputImages = Directory.GetFiles(inputPath, "*png");
            var imageinfo = new List<ImageInfo>();

            foreach (var image in inputImages)
            {
                for (int i = 0; i < frameRepeat; i++)
                {
                    imageinfo.Add(ImageInfo.FromPath(image));
                }
            }

            return FFMpeg.JoinImageSequence($"{path}{Path.DirectorySeparatorChar}{filename}.mp4", frameRate, imageinfo.ToArray());
        }

        public static void JoinVideos(string path, string outputFile, string inputPath)
        {
            var inputVideos = Directory.GetFiles(inputPath);
        }
    }
}
