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

using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ScreenLapseLib.Helpers
{
    public static class ScreenHelper
    {
        private static Bitmap CopyFromScreen(Rectangle bounds)
        {
            try
            {
                var image = new Bitmap(bounds.Width, bounds.Height);
                using var graphics = Graphics.FromImage(image);
                graphics.CopyFromScreen(Point.Empty, Point.Empty, bounds.Size);
                return image;
            }
            catch (Win32Exception)
            {
                //When screen saver is active
                return null;
            }
        }

        public static Image Take(Rectangle bounds)
        {
            return CopyFromScreen(bounds);

        }

        public static byte[] TakeAsByteArray(Rectangle bounds)
        {
            using var image = CopyFromScreen(bounds);
            using var ms = new MemoryStream();
            image.Save(ms, ImageFormat.Png);
            return ms.ToArray();
        }

        public static void TakeAndSave(string path, string fileName, Rectangle bounds, ImageFormat imageFormat)
        {
            using (var image = CopyFromScreen(bounds))
            {

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                image.Save(path + fileName, imageFormat);
            }
        }
    }
}
