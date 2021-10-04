namespace Examination_Attendance_System
{
    partial class ClockOutStudents
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRegNumber = new System.Windows.Forms.TextBox();
            this.buttonClockOut = new System.Windows.Forms.Button();
            this.buttonStopCaptureOut = new System.Windows.Forms.Button();
            this.buttonStartCaptureOut = new System.Windows.Forms.Button();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtPrompt = new System.Windows.Forms.TextBox();
            this.labelTimeOut = new System.Windows.Forms.Label();
            this.labelFullname = new System.Windows.Forms.Label();
            this.labelRegNumberOut = new System.Windows.Forms.Label();
            this.picFingerPrint = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFingerPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtRegNumber);
            this.groupBox3.Controls.Add(this.buttonClockOut);
            this.groupBox3.Controls.Add(this.buttonStopCaptureOut);
            this.groupBox3.Controls.Add(this.buttonStartCaptureOut);
            this.groupBox3.Controls.Add(this.txtStatus);
            this.groupBox3.Controls.Add(this.txtPrompt);
            this.groupBox3.Controls.Add(this.labelTimeOut);
            this.groupBox3.Controls.Add(this.labelFullname);
            this.groupBox3.Controls.Add(this.labelRegNumberOut);
            this.groupBox3.Controls.Add(this.picFingerPrint);
            this.groupBox3.Location = new System.Drawing.Point(249, 13);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(446, 480);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Clock In";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(282, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Finish";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRegNumber
            // 
            this.txtRegNumber.Location = new System.Drawing.Point(8, 54);
            this.txtRegNumber.Name = "txtRegNumber";
            this.txtRegNumber.Size = new System.Drawing.Size(187, 20);
            this.txtRegNumber.TabIndex = 10;
            // 
            // buttonClockOut
            // 
            this.buttonClockOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClockOut.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonClockOut.Location = new System.Drawing.Point(201, 276);
            this.buttonClockOut.Name = "buttonClockOut";
            this.buttonClockOut.Size = new System.Drawing.Size(75, 28);
            this.buttonClockOut.TabIndex = 9;
            this.buttonClockOut.Text = "Clock Out";
            this.buttonClockOut.UseVisualStyleBackColor = true;
            this.buttonClockOut.Click += new System.EventHandler(this.buttonClockOut_Click);
            // 
            // buttonStopCaptureOut
            // 
            this.buttonStopCaptureOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStopCaptureOut.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonStopCaptureOut.Location = new System.Drawing.Point(101, 276);
            this.buttonStopCaptureOut.Name = "buttonStopCaptureOut";
            this.buttonStopCaptureOut.Size = new System.Drawing.Size(94, 28);
            this.buttonStopCaptureOut.TabIndex = 9;
            this.buttonStopCaptureOut.Text = "Stop Capture";
            this.buttonStopCaptureOut.UseVisualStyleBackColor = true;
            this.buttonStopCaptureOut.Click += new System.EventHandler(this.buttonStopCaptureOut_Click);
            // 
            // buttonStartCaptureOut
            // 
            this.buttonStartCaptureOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartCaptureOut.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonStartCaptureOut.Location = new System.Drawing.Point(8, 276);
            this.buttonStartCaptureOut.Name = "buttonStartCaptureOut";
            this.buttonStartCaptureOut.Size = new System.Drawing.Size(87, 28);
            this.buttonStartCaptureOut.TabIndex = 9;
            this.buttonStartCaptureOut.Text = "Start Capture";
            this.buttonStartCaptureOut.UseVisualStyleBackColor = true;
            this.buttonStartCaptureOut.Click += new System.EventHandler(this.buttonStartCaptureOut_Click);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(7, 336);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(394, 137);
            this.txtStatus.TabIndex = 9;
            // 
            // txtPrompt
            // 
            this.txtPrompt.Location = new System.Drawing.Point(7, 310);
            this.txtPrompt.Name = "txtPrompt";
            this.txtPrompt.Size = new System.Drawing.Size(334, 20);
            this.txtPrompt.TabIndex = 9;
            // 
            // labelTimeOut
            // 
            this.labelTimeOut.AutoSize = true;
            this.labelTimeOut.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelTimeOut.Location = new System.Drawing.Point(162, 185);
            this.labelTimeOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTimeOut.Name = "labelTimeOut";
            this.labelTimeOut.Size = new System.Drawing.Size(50, 13);
            this.labelTimeOut.TabIndex = 3;
            this.labelTimeOut.Text = "Time Out";
            // 
            // labelFullname
            // 
            this.labelFullname.AutoSize = true;
            this.labelFullname.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelFullname.Location = new System.Drawing.Point(162, 109);
            this.labelFullname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFullname.Name = "labelFullname";
            this.labelFullname.Size = new System.Drawing.Size(49, 13);
            this.labelFullname.TabIndex = 2;
            this.labelFullname.Text = "Fullname";
            // 
            // labelRegNumberOut
            // 
            this.labelRegNumberOut.AutoSize = true;
            this.labelRegNumberOut.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelRegNumberOut.Location = new System.Drawing.Point(5, 37);
            this.labelRegNumberOut.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRegNumberOut.Name = "labelRegNumberOut";
            this.labelRegNumberOut.Size = new System.Drawing.Size(75, 13);
            this.labelRegNumberOut.TabIndex = 1;
            this.labelRegNumberOut.Text = "Track Number";
            this.labelRegNumberOut.Click += new System.EventHandler(this.labelRegNumberOut_Click);
            // 
            // picFingerPrint
            // 
            this.picFingerPrint.Location = new System.Drawing.Point(8, 109);
            this.picFingerPrint.Margin = new System.Windows.Forms.Padding(4);
            this.picFingerPrint.Name = "picFingerPrint";
            this.picFingerPrint.Size = new System.Drawing.Size(146, 160);
            this.picFingerPrint.TabIndex = 0;
            this.picFingerPrint.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Examination_Attendance_System.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(13, 122);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(229, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ClockOutStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 519);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "ClockOutStudents";
            this.Text = "Arthur Javis";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFingerPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonClockOut;
        private System.Windows.Forms.Button buttonStopCaptureOut;
        private System.Windows.Forms.Button buttonStartCaptureOut;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtPrompt;
        private System.Windows.Forms.Label labelTimeOut;
        private System.Windows.Forms.Label labelFullname;
        private System.Windows.Forms.Label labelRegNumberOut;
        private System.Windows.Forms.PictureBox picFingerPrint;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRegNumber;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}