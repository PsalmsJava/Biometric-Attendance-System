using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Examination_Attendance_System
{
    public class Config
    {
        string ConectionString = "";  // save connection string
        public OleDbConnection connection = null;
        DataSet ds;
        DataTable dt;
        public string Table; // initialize db table
        public string ConnectionType = "";
        string RecordSource = "";

        DataGridView tempdata;

        public Config()
        {

        }

        // function to connect to the database
        public void Connect(string database_name)
        {
            try
            {
                ConectionString = "Provider=Microsoft.ACE.Oledb.12.0;Data Source=Attendance Database.accdb";
                connection = new OleDbConnection(ConectionString);
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        // Function to execute select statements
        public void ExecuteSql(string Sql_command)
        {

            nowquiee(Sql_command);

        }

        // creates connection to MySQL before execution
        public void nowquiee(string sql_comm)
        {
            try
            {
                OleDbConnection cs = new OleDbConnection(ConectionString);
                cs.Open();
                OleDbCommand myc = new OleDbCommand(sql_comm, cs);
                myc.ExecuteNonQuery();
                cs.Close();


            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);
            }
        }

        // function to execute delete , insert and update
        public void Execute(string Sql_command,string Table)
        {
            RecordSource = Sql_command;
            ConnectionType = Table;
            dt = new DataTable(ConnectionType);
            try
            {
                string command = RecordSource.ToUpper();

                //======================if sql contains select==========================================
                OleDbDataAdapter da2 = new OleDbDataAdapter(RecordSource, connection);
                DataSet tempds = new DataSet();
                da2.Fill(tempds, ConnectionType);
                da2.Fill(tempds);
                //======================================================================================
            }
            catch (Exception err) { MessageBox.Show(err.Message); }
        }

        // function to bring selected results based on column name and row index
        public string Results(int ROW, string COLUMN_NAME)
        {
            try
            {
                return dt.Rows[ROW][COLUMN_NAME].ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return "";

            }
        }

        // function to bring selected results based on column index and row index
        public string Results(int ROW, int COLUMN_NAME)
        {
            try
            {
                return dt.Rows[ROW][COLUMN_NAME].ToString();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return dt.Rows[ROW][COLUMN_NAME].ToString();

            }
        }

        // Execute select statement
        public void ExecuteSelect(string Sql_command,string Table)
        {
            RecordSource = Sql_command;
            ConnectionType = Table;

            dt = new DataTable(ConnectionType);
            try
            {
                string command = RecordSource.ToUpper();
                OleDbDataAdapter da = new OleDbDataAdapter(RecordSource, connection);
                ds = new DataSet();
                da.Fill(ds, ConnectionType);
                da.Fill(dt);
                tempdata = new DataGridView();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }


        }

        // count Number of rows after selecy
        public int Count()
        {
            return dt.Rows.Count;
        }
    }
}
