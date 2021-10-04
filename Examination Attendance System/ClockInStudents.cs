using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_Attendance_System
{
    public partial class ClockInStudents : Form, DPFP.Capture.EventHandler
    {
        private DPFP.Capture.Capture Capturer;
        delegate void Function();
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter adapter;
        OleDbDataReader dataReader;
        ImageConverter imgCon;

        public ClockInStudents()
        {
            InitializeComponent();
        }

        protected virtual void loadevents()
        {
            try
            {
                Capturer = new DPFP.Capture.Capture();				// Create a capture operation.

                if (null != Capturer)
                    Capturer.EventHandler = this;					// Subscribe for capturing events.
                else
                    SetPrompt("Can't initiate capture operation!");
            }
            catch
            {
                MessageBox.Show("Can't initiate capture operation!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void startcapturing()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StartCapture();
                    SetPrompt("Using the fingerprint reader, scan your fingerprint.");
                }
                catch
                {
                    SetPrompt("Can't initiate capture!");
                }
            }
        }

        protected void Stop()
        {
            if (null != Capturer)
            {
                try
                {
                    Capturer.StopCapture();
                }
                catch
                {
                    SetPrompt("Can't terminate capture!");
                }
            }
        }

        public void SetPrompt(string text)
        {
            txtPrompt.Text = text;
        }

        #region EventHandler Members:

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            MakeReport("The fingerprint sample was captured.");
            SetPrompt("Scan the same fingerprint again.");
            Process(Sample);

        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The finger was removed from the fingerprint reader.");
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was touched.");
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was connected.");
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("The fingerprint reader was disconnected.");
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
                MakeReport("The quality of the fingerprint sample is good.");
            else
                MakeReport("The quality of the fingerprint sample is poor.");
        }
        #endregion

        protected void MakeReport(string message)
        {
            txtStatus.AppendText(message + "\n");
        }

        protected virtual void Process(DPFP.Sample Sample)
        {
            // Draw fingerprint sample image.
            DrawPicture(ConvertSampleToBitmap(Sample));
        }

        private void DrawPicture(Bitmap bitmap)
        {
            //this.Invoke(new Function(delegate()
            //{
            picFingerPrintIn.Image = new Bitmap(bitmap, picFingerPrintIn.Size);	// fit the image into the picture box
            //}));
        }

        protected void SetStatus(string status)
        {
            txtStatus.Text = status;
        }

        protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();	// Create a feature extractor
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);			// TODO: return features as a result?
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;
        }

        protected Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();	// Create a sample convertor.
            Bitmap bitmap = null;												            // TODO: the size doesn't matter
            Convertor.ConvertToPicture(Sample, ref bitmap);									// TODO: return bitmap as a result

            return bitmap;
        }

        private void CaptureForm_Load(object sender, EventArgs e)
        {
            // Start capture operation.
        }

        private byte[] ConvertImageToByteArray(System.Drawing.Image imageToConvert, System.Drawing.Imaging.ImageFormat formatOfImage)
        {
            byte[] Ret;
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    imageToConvert.Save(ms, formatOfImage);
                    Ret = ms.ToArray();
                }
            }
            catch (Exception) { throw; }
            return Ret;
        }
        public static byte[] imgToByteConverter(Image inImg)
        {
            ImageConverter imgCon = new ImageConverter();
            return (byte[])imgCon.ConvertTo(inImg, typeof(byte[]));
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }


        private void buttonStart_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            loadevents();
            startcapturing();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonStartCaptureIn_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            loadevents();
            startcapturing();
        }

        private void buttonStopCaptureIn_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void txtCourse_TextChanged(object sender, EventArgs e)
        {
            labelRegNumber.Text = "";
            labelTimeIn.Text = "";
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LecturerMenu().Show();
        }

        private void buttonClockIn_Click_1(object sender, EventArgs e)
        {
            if (txtCourse.Text != string.Empty || txtRegNumber.Text != string.Empty)
            {
                connection = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Attendance Database.accdb");
                command = new OleDbCommand("SELECT * FROM FINGERPRINTTABLE where RegNumber='"  + txtRegNumber.Text + "'", connection);
                connection.Open();
                dataReader = command.ExecuteReader();
                if (dataReader.Read())
                {
                    MessageBox.Show("Student Details Found");
                    dataReader.Close();
                    labelFullname.Text = dataReader.GetString(0);
                    labelTimeIn.Text = DateTime.Now.ToShortTimeString();
                    try {
                        command = new OleDbCommand("INSERT INTO ATTENDANCETABLE (`COURSECODE`,`REGNUMBER`,`TIMEIN`,`TIMEOUT`) VALUES (@cc,@reg,@ti,@tout)",connection);
                        connection.Open();
                        command.Parameters.AddWithValue("@cc", txtCourse.Text);
                        command.Parameters.AddWithValue("@reg", txtRegNumber.Text);
                        command.Parameters.AddWithValue("@ti", labelTimeIn.Text);
                        command.Parameters.AddWithValue("@to", labelTimeIn.Text);
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    dataReader.Close();
                    MessageBox.Show("FingerPrint and Track Number Mismatch ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Enter Course Title and Student Track Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelRegNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
