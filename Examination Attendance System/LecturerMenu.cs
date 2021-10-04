using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_Attendance_System
{
    public partial class LecturerMenu : Form
    {
        public LecturerMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ClockInStudents().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ClockOutStudents().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AttendanceReport().Show();
            this.Hide();
        }
    }
}
