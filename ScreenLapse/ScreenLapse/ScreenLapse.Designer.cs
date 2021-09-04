
namespace ScreenLapse
{
    partial class ScreenLapse
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.lblDelay = new System.Windows.Forms.Label();
            this.lblRepeatFrames = new System.Windows.Forms.Label();
            this.txtRepeatFrames = new System.Windows.Forms.TextBox();
            this.lblFrameRate = new System.Windows.Forms.Label();
            this.txtFrameRate = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 255);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(102, 55);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(295, 255);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(102, 55);
            this.btnStop.TabIndex = 5;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(100, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(233, 47);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Screen Lapse";
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(174, 68);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(100, 35);
            this.txtDelay.TabIndex = 1;
            this.txtDelay.Text = "3";
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(12, 73);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(71, 30);
            this.lblDelay.TabIndex = 4;
            this.lblDelay.Text = "Delay:";
            // 
            // lblRepeatFrames
            // 
            this.lblRepeatFrames.AutoSize = true;
            this.lblRepeatFrames.Location = new System.Drawing.Point(12, 118);
            this.lblRepeatFrames.Name = "lblRepeatFrames";
            this.lblRepeatFrames.Size = new System.Drawing.Size(159, 30);
            this.lblRepeatFrames.TabIndex = 6;
            this.lblRepeatFrames.Text = "Repeat Frames:";
            // 
            // txtRepeatFrames
            // 
            this.txtRepeatFrames.Location = new System.Drawing.Point(174, 113);
            this.txtRepeatFrames.Name = "txtRepeatFrames";
            this.txtRepeatFrames.Size = new System.Drawing.Size(100, 35);
            this.txtRepeatFrames.TabIndex = 2;
            this.txtRepeatFrames.Text = "3";
            // 
            // lblFrameRate
            // 
            this.lblFrameRate.AutoSize = true;
            this.lblFrameRate.Location = new System.Drawing.Point(12, 165);
            this.lblFrameRate.Name = "lblFrameRate";
            this.lblFrameRate.Size = new System.Drawing.Size(127, 30);
            this.lblFrameRate.TabIndex = 8;
            this.lblFrameRate.Text = "Frame Rate:";
            this.lblFrameRate.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtFrameRate
            // 
            this.txtFrameRate.Location = new System.Drawing.Point(174, 160);
            this.txtFrameRate.Name = "txtFrameRate";
            this.txtFrameRate.Size = new System.Drawing.Size(100, 35);
            this.txtFrameRate.TabIndex = 3;
            this.txtFrameRate.Text = "32";
            // 
            // ScreenLapse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(409, 322);
            this.Controls.Add(this.lblFrameRate);
            this.Controls.Add(this.txtFrameRate);
            this.Controls.Add(this.lblRepeatFrames);
            this.Controls.Add(this.txtRepeatFrames);
            this.Controls.Add(this.lblDelay);
            this.Controls.Add(this.txtDelay);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ScreenLapse";
            this.Text = "Screen Lapse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.Label lblRepeatFrames;
        private System.Windows.Forms.TextBox txtRepeatFrames;
        private System.Windows.Forms.Label lblFrameRate;
        private System.Windows.Forms.TextBox txtFrameRate;
    }
}

