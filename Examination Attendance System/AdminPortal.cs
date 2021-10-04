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
    public partial class AdminPortal : Form, DPFP.Capture.EventHandler
    {
        private DPFP.Capture.Capture Capturer;
        delegate void Function();
        OleDbConnection connection;
        OleDbCommand command;
        OleDbDataAdapter adapter;
        OleDbDataReader dataReader;
        ImageConverter imgCon;
        string query;
        string connectionString = "Provider=Microsoft.ACE.Oledb.12.0;Data Source=Attendance Database.accdb";


        public AdminPortal()
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
            picFingerprint.Image = new Bitmap(bitmap, picFingerprint.Size);	// fit the image into the picture box
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                imgCon = new ImageConverter();
                byte[] imageInPic = imgToByteConverter(picFingerprint.Image);
                query = "INSERT INTO FINGERPRINTTABLE (`REGNUMBER`,`FINGERPRINT`,`FULLNAME`,`FACULTY`,`DEPARTMENT`,`LEVEL`) VALUES (@regnumber,@fingerprint,@full,@fac,@dept,@leve)";
                command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@regnumber", txtRegNumber.Text);
                command.Parameters.AddWithValue("@fingerprint", imageInPic);
                command.Parameters.AddWithValue("@full", txtFull.Text);
                command.Parameters.AddWithValue("@fac", txtFac.Text);
                command.Parameters.AddWithValue("@dept", txtDept.Text);
                command.Parameters.AddWithValue("@leve", comboStudLevel.Text);
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Student Enrolled Successfully");
               
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally {
                txtRegNumber.Text = "";
                picFingerprint.Image = null;
                txtFull.Text = "";
                txtFac.Text = "";
                txtDept.Text = "";
                comboStudLevel.Text = "";
                connection.Close();
            }
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddCourse_Click(object sender, EventArgs e)
        {
            try
            {
                query = "INSERT INTO COURSETABLE (`COURSECODE`,`COURSETITLE`,`CREDITHOURS`,`FACULTY`,`DEPARTMENT`,`SEMESTER`,`SESSION`,`LEVEL`) VALUES (@cc,@ct,@ch,@fac,@dept,@sem,@sess,@lev)";
                command = new OleDbCommand(query, connection); command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@cc", txtCourseCode.Text);
                command.Parameters.AddWithValue("@ct", txtCourseTitle.Text);
                command.Parameters.AddWithValue("@ch", comboCreditHours.Text);
                command.Parameters.AddWithValue("@fac", txtFac.Text);
                command.Parameters.AddWithValue("@dept", txtDept.Text);
                command.Parameters.AddWithValue("@sem", comboSemester.Text);
                command.Parameters.AddWithValue("@sess", txtSession.Text);
                command.Parameters.AddWithValue("@lev", comboStudLevel.Text);
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Course Upload Successfull");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally {
                txtCourseCode.Text = "";
                txtCourseTitle.Text = "";
                comboCreditHours.Text = "";
                txtFac.Text = "";
                txtDept.Text = "";
                comboSemester.Text = "";
                txtSession.Text = "";
                comboStudLevel.Text = "";

                connection.Close();
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                query = "INSERT INTO LECTURERTABLE (`STAFFID`,`FULLNAME`,`EMAIL`,`PHONENUMBER`,`USERNAME`,`PASSWORD`) VALUES (@sf,@full,@em,@pn,@usr,@pass)";
                command = new OleDbCommand(query, connection);
                command.Parameters.AddWithValue("@sf", txtStaffId.Text);
                command.Parameters.AddWithValue("@full", txtFullname.Text);
                command.Parameters.AddWithValue("@em", txtEmail.Text);
                command.Parameters.AddWithValue("@pn", txtPhoneNumber.Text);
                command.Parameters.AddWithValue("@usr", txtUsername.Text);
                command.Parameters.AddWithValue("@pass", txtPassword.Text);
                connection.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Lecturer Upload Successfull");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Message" + ex.Message);
            }
            finally {
                txtStaffId.Text = "";
                txtFullname.Text = "";
                txtEmail.Text = "";
                txtPhoneNumber.Text = "";
                txtUsername.Text = "";
                txtPassword.Text = "";

                connection.Close();
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

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void AdminPortal_Load(object sender, EventArgs e)
        {
            connection = new OleDbConnection(connectionString);
        }
    }
}
