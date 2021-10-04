using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_Attendance_System
{
    public partial class Home : Form
    {
        private static string ADMIN_PASSWORD = "admin";
        private static string ADMIN_USERNAME = "admin@aj";
        OleDbCommand command;
        OleDbConnection connection;
        OleDbDataReader dataReader;


        public Home()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (comboRole.Text.Equals(""))
            {
                MessageBox.Show("Select User Role");
            }
            else if (comboRole.Text.Equals("Admin"))
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                if(username.Equals(ADMIN_USERNAME) && password.Equals(ADMIN_PASSWORD))
                {
                    MessageBox.Show("Authentication Successfull");
                    new AdminPortal().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect Login Details");
                    txtPassword.Text = "";
                    txtUsername.Text = "";
                }
            }
            else {
                if (txtPassword.Text != string.Empty || txtUsername.Text != string.Empty)
                {
                    connection = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Attendance Database.accdb");
                    command = new OleDbCommand("SELECT * FROM LECTURERTABLE where USERNAME='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'", connection);
                    connection.Open();
                    dataReader = command.ExecuteReader();
                    if (dataReader.Read())
                    {
                        dataReader.Close();
                        this.Hide();
                        LecturerMenu lectureMenu = new LecturerMenu();
                        lectureMenu.Show();
                    }
                    else
                    {
                        dataReader.Close();
                        MessageBox.Show("No Account available with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter value in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
