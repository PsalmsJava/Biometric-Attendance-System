namespace Examination_Attendance_System
{
    partial class AttendanceReport
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.attendanceDataSet = new Examination_Attendance_System.AttendanceDataSet();
            this.attendanceTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceTableTableAdapter = new Examination_Attendance_System.AttendanceDataSetTableAdapters.AttendanceTableTableAdapter();
            this.courseTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.regNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseTitleDataGridViewTextBoxColumn,
            this.regNumberDataGridViewTextBoxColumn,
            this.timeInDataGridViewTextBoxColumn,
            this.timeOutDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.attendanceTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(603, 376);
            this.dataGridView1.TabIndex = 0;
            // 
            // attendanceDataSet
            // 
            this.attendanceDataSet.DataSetName = "AttendanceDataSet";
            this.attendanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendanceTableBindingSource
            // 
            this.attendanceTableBindingSource.DataMember = "AttendanceTable";
            this.attendanceTableBindingSource.DataSource = this.attendanceDataSet;
            // 
            // attendanceTableTableAdapter
            // 
            this.attendanceTableTableAdapter.ClearBeforeFill = true;
            // 
            // courseTitleDataGridViewTextBoxColumn
            // 
            this.courseTitleDataGridViewTextBoxColumn.DataPropertyName = "CourseTitle";
            this.courseTitleDataGridViewTextBoxColumn.HeaderText = "CourseTitle";
            this.courseTitleDataGridViewTextBoxColumn.Name = "courseTitleDataGridViewTextBoxColumn";
            // 
            // regNumberDataGridViewTextBoxColumn
            // 
            this.regNumberDataGridViewTextBoxColumn.DataPropertyName = "RegNumber";
            this.regNumberDataGridViewTextBoxColumn.HeaderText = "RegNumber";
            this.regNumberDataGridViewTextBoxColumn.Name = "regNumberDataGridViewTextBoxColumn";
            // 
            // timeInDataGridViewTextBoxColumn
            // 
            this.timeInDataGridViewTextBoxColumn.DataPropertyName = "TimeIn";
            this.timeInDataGridViewTextBoxColumn.HeaderText = "TimeIn";
            this.timeInDataGridViewTextBoxColumn.Name = "timeInDataGridViewTextBoxColumn";
            // 
            // timeOutDataGridViewTextBoxColumn
            // 
            this.timeOutDataGridViewTextBoxColumn.DataPropertyName = "TimeOut";
            this.timeOutDataGridViewTextBoxColumn.HeaderText = "TimeOut";
            this.timeOutDataGridViewTextBoxColumn.Name = "timeOutDataGridViewTextBoxColumn";
            // 
            // AttendanceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 396);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AttendanceReport";
            this.Text = "AttendanceReport";
            this.Load += new System.EventHandler(this.AttendanceReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceTableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private AttendanceDataSet attendanceDataSet;
        private System.Windows.Forms.BindingSource attendanceTableBindingSource;
        private AttendanceDataSetTableAdapters.AttendanceTableTableAdapter attendanceTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn regNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOutDataGridViewTextBoxColumn;
    }
}