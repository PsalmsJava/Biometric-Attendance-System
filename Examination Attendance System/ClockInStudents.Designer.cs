namespace Examination_Attendance_System
{
    partial class ClockInStudents
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.txtRegNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtPrompt = new System.Windows.Forms.TextBox();
            this.buttonClockIn = new System.Windows.Forms.Button();
            this.buttonStopCaptureIn = new System.Windows.Forms.Button();
            this.buttonStartCaptureIn = new System.Windows.Forms.Button();
            this.labelTimeIn = new System.Windows.Forms.Label();
            this.labelFullname = new System.Windows.Forms.Label();
            this.labelRegNumber = new System.Windows.Forms.Label();
            this.picFingerPrintIn = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFingerPrintIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonFinish);
            this.groupBox2.Controls.Add(this.txtRegNumber);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtCourse);
            this.groupBox2.Controls.Add(this.txtStatus);
            this.groupBox2.Controls.Add(this.txtPrompt);
            this.groupBox2.Controls.Add(this.buttonClockIn);
            this.groupBox2.Controls.Add(this.buttonStopCaptureIn);
            this.groupBox2.Controls.Add(this.buttonStartCaptureIn);
            this.groupBox2.Controls.Add(this.labelTimeIn);
            this.groupBox2.Controls.Add(this.labelFullname);
            this.groupBox2.Controls.Add(this.labelRegNumber);
            this.groupBox2.Controls.Add(this.picFingerPrintIn);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupBox2.Location = new System.Drawing.Point(281, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(490, 467);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Clock In";
            // 
            // buttonFinish
            // 
            this.buttonFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFinish.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonFinish.Location = new System.Drawing.Point(282, 297);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(82, 28);
            this.buttonFinish.TabIndex = 12;
            this.buttonFinish.Text = "Finish";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // txtRegNumber
            // 
            this.txtRegNumber.Location = new System.Drawing.Point(7, 92);
            this.txtRegNumber.Name = "txtRegNumber";
            this.txtRegNumber.Size = new System.Drawing.Size(236, 20);
            this.txtRegNumber.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(8, 22);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Course Title";
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(11, 38);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.Size = new System.Drawing.Size(232, 20);
            this.txtCourse.TabIndex = 9;
            this.txtCourse.TextChanged += new System.EventHandler(this.txtCourse_TextChanged);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(7, 357);
            this.txtStatus.Multiline = true;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(394, 91);
            this.txtStatus.TabIndex = 8;
            // 
            // txtPrompt
            // 
            this.txtPrompt.Location = new System.Drawing.Point(7, 331);
            this.txtPrompt.Name = "txtPrompt";
            this.txtPrompt.Size = new System.Drawing.Size(334, 20);
            this.txtPrompt.TabIndex = 7;
            // 
            // buttonClockIn
            // 
            this.buttonClockIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClockIn.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonClockIn.Location = new System.Drawing.Point(200, 297);
            this.buttonClockIn.Name = "buttonClockIn";
            this.buttonClockIn.Size = new System.Drawing.Size(75, 28);
            this.buttonClockIn.TabIndex = 6;
            this.buttonClockIn.Text = "Clock In";
            this.buttonClockIn.UseVisualStyleBackColor = true;
            this.buttonClockIn.Click += new System.EventHandler(this.buttonClockIn_Click_1);
            // 
            // buttonStopCaptureIn
            // 
            this.buttonStopCaptureIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStopCaptureIn.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonStopCaptureIn.Location = new System.Drawing.Point(100, 297);
            this.buttonStopCaptureIn.Name = "buttonStopCaptureIn";
            this.buttonStopCaptureIn.Size = new System.Drawing.Size(94, 28);
            this.buttonStopCaptureIn.TabIndex = 5;
            this.buttonStopCaptureIn.Text = "Stop Capture";
            this.buttonStopCaptureIn.UseVisualStyleBackColor = true;
            // 
            // buttonStartCaptureIn
            // 
            this.buttonStartCaptureIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartCaptureIn.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonStartCaptureIn.Location = new System.Drawing.Point(7, 297);
            this.buttonStartCaptureIn.Name = "buttonStartCaptureIn";
            this.buttonStartCaptureIn.Size = new System.Drawing.Size(87, 28);
            this.buttonStartCaptureIn.TabIndex = 4;
            this.buttonStartCaptureIn.Text = "Start Capture";
            this.buttonStartCaptureIn.UseVisualStyleBackColor = true;
            this.buttonStartCaptureIn.Click += new System.EventHandler(this.buttonStartCaptureIn_Click);
            // 
            // labelTimeIn
            // 
            this.labelTimeIn.AutoSize = true;
            this.labelTimeIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTimeIn.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelTimeIn.Location = new System.Drawing.Point(161, 197);
            this.labelTimeIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTimeIn.Name = "labelTimeIn";
            this.labelTimeIn.Size = new System.Drawing.Size(42, 13);
            this.labelTimeIn.TabIndex = 3;
            this.labelTimeIn.Text = "Time In";
            // 
            // labelFullname
            // 
            this.labelFullname.AutoSize = true;
            this.labelFullname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelFullname.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelFullname.Location = new System.Drawing.Point(162, 134);
            this.labelFullname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFullname.Name = "labelFullname";
            this.labelFullname.Size = new System.Drawing.Size(49, 13);
            this.labelFullname.TabIndex = 2;
            this.labelFullname.Text = "Fullname";
            // 
            // labelRegNumber
            // 
            this.labelRegNumber.AutoSize = true;
            this.labelRegNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelRegNumber.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelRegNumber.Location = new System.Drawing.Point(8, 76);
            this.labelRegNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRegNumber.Name = "labelRegNumber";
            this.labelRegNumber.Size = new System.Drawing.Size(75, 13);
            this.labelRegNumber.TabIndex = 1;
            this.labelRegNumber.Text = "Track Number";
            this.labelRegNumber.Click += new System.EventHandler(this.labelRegNumber_Click);
            // 
            // picFingerPrintIn
            // 
            this.picFingerPrintIn.Location = new System.Drawing.Point(7, 119);
            this.picFingerPrintIn.Margin = new System.Windows.Forms.Padding(4);
            this.picFingerPrintIn.Name = "picFingerPrintIn";
            this.picFingerPrintIn.Size = new System.Drawing.Size(146, 160);
            this.picFingerPrintIn.TabIndex = 0;
            this.picFingerPrintIn.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Examination_Attendance_System.Properties.Resources.images;
            this.pictureBox1.Location = new System.Drawing.Point(35, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ClockInStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 494);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ClockInStudents";
            this.Text = "Arthur Javis";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFingerPrintIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtPrompt;
        private System.Windows.Forms.Button buttonClockIn;
        private System.Windows.Forms.Button buttonStopCaptureIn;
        private System.Windows.Forms.Button buttonStartCaptureIn;
        private System.Windows.Forms.Label labelTimeIn;
        private System.Windows.Forms.Label labelFullname;
        private System.Windows.Forms.Label labelRegNumber;
        private System.Windows.Forms.PictureBox picFingerPrintIn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtRegNumber;
        private System.Windows.Forms.Button buttonFinish;
    }
}