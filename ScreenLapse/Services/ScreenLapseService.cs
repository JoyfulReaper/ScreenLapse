/*
MIT License
Copyright(c) 2026 Kyle Givler
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

using ScreenLapse.Lib;
using System;
using System.IO;

namespace ScreenLapse.Services;

internal class ScreenLapseService
{
    private CaptureSession? _captureSession = null;
    private ScreenLapseOptions _options;

    public ScreenLapseService(ScreenLapseOptions options)
    {
        _options = options;
    }

    public CaptureSession StartSession()
    {
        var timeStamps = DateTimeOffset.Now;
        var path = Path.Combine(_options.CapturePath, timeStamps.ToString("yyyy-MM-dd-HHmmss"));

        if (Directory.Exists(path))
        {
            throw new Exception($"Path {path} already exists");
        }

        Directory.CreateDirectory(path);
        _captureSession = new CaptureSession(path, timeStamps, 0);

        return _captureSession;
    }
}
