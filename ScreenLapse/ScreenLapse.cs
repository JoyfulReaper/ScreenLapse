using ScreenLapseLib.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenLapse
{
    public partial class ScreenLapse : Form
    {
        private bool _started = false;
        private double _delay;
        private int _frameRate;
        private int _frameRepeat;
        private string _inputPath = ".\\images\\";
        private string _outputPath = ".\\images\\";

        public ScreenLapse()
        {
            InitializeComponent();

            CheckIfProccessIsAllowedAndUpdate();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            string errorMessage;
            if (!ValidateInput(out errorMessage))
            {
                MessageBox.Show(errorMessage);
                return;
            }

            btnStart.Enabled = false;
            btnStop.Enabled = true;
            btnProcess.Enabled = false;

            _started = true;

            while (_started == true)
            {
                var bounds = new Rectangle();
                bounds = Screen.PrimaryScreen.Bounds;
                ScreenHelper.TakeAndSave(_outputPath, $"{DateTime.Now.Ticks}-shot.png", bounds, ImageFormat.Png);
                await Task.Delay((int)(_delay * 1000));
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = false;
            btnStart.Enabled = true;

            CheckIfProccessIsAllowedAndUpdate();

            _started = false;
        }

        private async void btnProcess_Click(object sender, EventArgs e)
        {
            string errorMessage;

            if (!ValidateInput(out errorMessage))
            {
                MessageBox.Show(errorMessage);
                return;
            }

            VideoHelper.CreateVideoFromImages(_outputPath, "outfile", _inputPath, _frameRepeat, _frameRate);

            if (chkDeleteImages.Checked)
            {
                await Task.Delay(1000 * 10);
                var files = Directory.GetFiles(_outputPath, "*-shot.png");
                foreach (var file in files)
                {
                    File.Delete(file);
                }
                CheckIfProccessIsAllowedAndUpdate();
            }

            MessageBox.Show("Done Proccessing!");
            btnStart.Enabled = true;
        }

        private bool ValidateInput(out string errorMessage)
        {
            errorMessage = string.Empty;

            if (!double.TryParse(txtDelay.Text, out _delay))
            {
                errorMessage += "Please enter a valid delay!" + Environment.NewLine;
            }

            if (!int.TryParse(txtFrameRate.Text, out _frameRate))
            {
                errorMessage += "Please enter a valid framerate!" + Environment.NewLine;
            }

            if (!int.TryParse(txtRepeatFrames.Text, out _frameRepeat))
            {
                errorMessage += "Please enter a valid frame repeat number!" + Environment.NewLine;
            }

            if (errorMessage != string.Empty)
            {
                return false;
            }

            return true;
        }

        private void CheckIfProccessIsAllowedAndUpdate()
        {
            if (Directory.Exists(_outputPath) && Directory.GetFiles(_outputPath).Length > 0)
            {
                btnProcess.Enabled = true;
            }
            else
            {
                btnProcess.Enabled = false;
            }
        }
    }
}
