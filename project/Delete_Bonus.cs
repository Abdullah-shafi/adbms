using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;
using System.Data.Common;

namespace project
{
    public partial class Delete_Bonus : UserControl
    {
        public Delete_Bonus()
        {
            InitializeComponent();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string dbconnect = "Data Source=(DESCRIPTION =" +
               "(ADDRESS = (PROTOCOL = TCP)(HOST =127.0.0.1)(PORT = 1521))" +
               "(CONNECT_DATA =" + "(SERVER = DEDICATED)" +
               "(SERVICE_NAME = XE)));" +
               "User Id=scott;Password=tiger;";
            OracleConnection conn = new OracleConnection(dbconnect);
            OracleDataAdapter sda = new OracleDataAdapter("Select Count(*) From manager where m_id='" + textBoxId.Text.Trim() + "' ", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {
                OracleCommand cmd = new OracleCommand(@"Update manager  SET comm='0' WHERE m_id ='" + textBoxId.Text.Trim() +  "'", conn);
                
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("ok");
                textBoxId.Text = "";
            }
            else
            {
                MessageBox.Show("Not Found");
                textBoxId.Text = "";
            }
        }
    }
}
