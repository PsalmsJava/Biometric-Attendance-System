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
    public partial class AttendanceReport : Form
    {
        public AttendanceReport()
        {
            InitializeComponent();
        }

        private void AttendanceReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'attendanceDataSet.AttendanceTable' table. You can move, or remove it, as needed.
            this.attendanceTableTableAdapter.Fill(this.attendanceDataSet.AttendanceTable);

        }
    }
}
