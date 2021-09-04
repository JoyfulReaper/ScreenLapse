using ScreenLapseLib.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenLapse
{
    public partial class ScreenLapse : Form
    {
        private bool _started = false;
        private int _delay;
        private int _frameRate;
        private int _frameRepeat;

        public ScreenLapse()
        {
            InitializeComponent();
        }

        private async void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
            _started = true;

            string errorMessage = string.Empty;

            if(!ValidateInput(out errorMessage))
            {
                MessageBox.Show(errorMessage);
                return;
            }

            while(_started == true)
            {
                var bounds = new Rectangle();
                bounds = Screen.PrimaryScreen.Bounds;
                ScreenHelper.TakeAndSave(@".\images\", $"{DateTime.Now.Ticks}-shot.png", bounds, ImageFormat.Png);
                await Task.Delay(_delay * 1000);
            }

            VideoHelper.CreateVideoFromImages(".\\images", "outfile", ".\\images", _frameRepeat, _frameRate);
            MessageBox.Show("Done Proccessing!");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            _started = false;
        }

        private bool ValidateInput(out string errorMessage)
        {
            errorMessage = string.Empty;

            if (!int.TryParse(txtDelay.Text, out _delay))
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
    }
}
