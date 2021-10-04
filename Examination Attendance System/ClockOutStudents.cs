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
    public partial class ClockOutStudents : Form, DPFP.Capture.EventHandler
    {
        private DPFP.Capture.Capture Capturer;
        delegate void Function();
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter adapter;
        OleDbDataReader dataReader;
        ImageConverter imgCon;

        public ClockOutStudents()
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
            picFingerPrint.Image = new Bitmap(bitmap, picFingerPrint.Size);	// fit the image into the picture box
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

        private void buttonStartCaptureOut_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            loadevents();
            startcapturing();
        }

        private void buttonStopCaptureOut_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new LecturerMenu().Show();
            this.Hide();
        }

        private void buttonClockOut_Click(object sender, EventArgs e)
        {
            connection = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Attendance Database.accdb");
            string query = "UPDATE ATTENDANCETABLE SET [TIMEOUT] = @timeout  WHERE [REGNUMBER] = @regnum ";
            try
            {
                command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@timeout", labelTimeOut.Text);
                command.Parameters.AddWithValue("@regnum", txtRegNumber.Text);
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Student Clocked Out");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Error Clocking Out " + exception.ToString());
            }
            finally {
                connection.Close();
            }
        }

        private void labelRegNumberOut_Click(object sender, EventArgs e)
        {

        }
    }
}
