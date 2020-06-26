using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;
using System.Data.Common;
using System.IO;

namespace project
{
    public partial class Bonus : UserControl
    {
        public Bonus()
        {
            InitializeComponent();
        }

        private void labelNum_Click(object sender, EventArgs e)
        {

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            string dbconnect = "Data Source=(DESCRIPTION =" +
               "(ADDRESS = (PROTOCOL = TCP)(HOST =127.0.0.1)(PORT = 1521))" +
               "(CONNECT_DATA =" + "(SERVER = DEDICATED)" +
               "(SERVICE_NAME = XE)));" +
               "User Id=scott;Password=tiger;";
            OracleConnection conn = new OracleConnection(dbconnect);
         
            DataTable dt = new DataTable();
            OracleCommand cmd = new OracleCommand("CREATE OR REPLACE TRIGGER u_bonus before UPDATE ON manager FOR EACH ROW BEGIN If :new.comm=:old.COMM then raise_application_error(-20500,'CANNOT POSSIBLE');END IF;END;", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            try
            {
                OracleCommand cmd1 = new OracleCommand("Update manager  SET comm='" + textBoxNComm.Text.Trim() + "' WHERE m_id ='" + textBoxUId.Text.Trim() + "'", conn);
                cmd1.ExecuteNonQuery();
                MessageBox.Show("Add");
                textBoxNComm.Text = "";
                textBoxUId.Text = "";
                
            }
            catch
            {
                MessageBox.Show("The Add Bonus is same as previous one");
            }
            conn.Close();
            OracleCommand cmd3 = new OracleCommand(" Drop trigger u_bonus", conn);
            conn.Open();
            cmd3.ExecuteNonQuery();
        }

        private void labelAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
