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

namespace project
{
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void allManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dbconnect = "Data Source=(DESCRIPTION =" +
                "(ADDRESS = (PROTOCOL = TCP)(HOST =127.0.0.1)(PORT = 1521))" +
                "(CONNECT_DATA =" + "(SERVER = DEDICATED)" +
                "(SERVICE_NAME = XE)));" +
                "User Id=scott;Password=tiger;";
            OracleConnection conn = new OracleConnection(dbconnect);
            OracleDataAdapter adapt;
             
            conn.Open();
            DataTable dt = new DataTable();
            adapt = new OracleDataAdapter("select c_id,c_name,model,price,availablity,saleamount from car ", conn);
            adapt.Fill(dt);
            dataGridViewmanager.DataSource = dt;
            conn.Close();
        }

        private void deleteManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelAdd.Controls.Clear();
            panelAdd.Controls.Add(new addcar());
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void deleteManagerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelDelete.Controls.Clear();
            panelDelete.Controls.Add(new deletecar());
        }

        private void backToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void Manager_Load(object sender, EventArgs e)
        {

        }

        public Manager(string ID)
        {
         
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelDelete.Controls.Clear();
            panelDelete.Controls.Add(new soldcar());
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormHome ob = new FormHome();
            this.Hide();
            ob.ShowDialog();
            this.Close();
        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

      

        private void panelAdd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void whoBookedCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                string dbconnect1 = "Data Source=(DESCRIPTION =" +
                   "(ADDRESS = (PROTOCOL = TCP)(HOST =127.0.0.1)(PORT = 1521))" +
                   "(CONNECT_DATA =" + "(SERVER = DEDICATED)" +
                   "(SERVICE_NAME = XE)));" +
                   "User Id=scott;Password=tiger;";
                OracleConnection conn = new OracleConnection(dbconnect1);
                OracleDataAdapter adapt;
                DataTable dt = new DataTable();
                OracleCommand cmd = new OracleCommand("create or replace view cus as select u_id,u_name,mobile_no,customer.booked_id,address,c_id,c_name from customer,car where car.c_id=customer.booked_id", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                adapt = new OracleDataAdapter("select * from cus", conn);
                adapt.Fill(dt);
                dataGridViewmanager.DataSource = dt;
                conn.Close();
            }
            catch { MessageBox.Show("None"); }
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dbconnect1 = "Data Source=(DESCRIPTION =" +
               "(ADDRESS = (PROTOCOL = TCP)(HOST =127.0.0.1)(PORT = 1521))" +
               "(CONNECT_DATA =" + "(SERVER = DEDICATED)" +
               "(SERVICE_NAME = XE)));" +
               "User Id=scott;Password=tiger;";
            OracleConnection conn = new OracleConnection(dbconnect1);
            OracleDataAdapter adapt;
            DataTable dt = new DataTable();
            adapt = new OracleDataAdapter("select u_id,u_name,mobile_no,booked_id,address from customer", conn);
            adapt.Fill(dt);
            dataGridViewmanager.DataSource = dt;
            conn.Close();
        }

        private void whoBoughtCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dbconnect1 = "Data Source=(DESCRIPTION =" +
              "(ADDRESS = (PROTOCOL = TCP)(HOST =127.0.0.1)(PORT = 1521))" +
              "(CONNECT_DATA =" + "(SERVER = DEDICATED)" +
              "(SERVICE_NAME = XE)));" +
              "User Id=scott;Password=tiger;";
            OracleConnection conn = new OracleConnection(dbconnect1);
            OracleDataAdapter adapt;
            DataTable dt = new DataTable();
            adapt = new OracleDataAdapter("select u_id,u_name from customer where bought_car>0", conn);
            adapt.Fill(dt);
            dataGridViewmanager.DataSource = dt;
            conn.Close();
        }

        private void disableUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dbconnect = "Data Source=(DESCRIPTION =" +
              "(ADDRESS = (PROTOCOL = TCP)(HOST =127.0.0.1)(PORT = 1521))" +
              "(CONNECT_DATA =" + "(SERVER = DEDICATED)" +
              "(SERVICE_NAME = XE)));" +
              "User Id=scott;Password=tiger;";
            OracleConnection conn = new OracleConnection(dbconnect);
            try
            {
                OracleCommand cmd = new OracleCommand("CREATE OR REPLACE PROCEDURE user_dis AS BEGIN IF TO_CHAR ( SYSDATE ,'DY') IN ('FRI', 'MON') AND TO_CHAR( SYSDATE,'HH24:MI')BETWEEN '12:00' AND '17:30' THEN RAISE_APPLICATION_ERROR(-20002,'It is not a normal hours');ELSE DBMS_OUTPUT.PUT_LINE('DONE');END IF;END;", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                OracleCommand cmd1 = new OracleCommand("CREATE OR REPLACE TRIGGER  works_user BEFORE INSERT OR UPDATE  ON car BEGIN user_dis;END;", conn);
                cmd1.ExecuteNonQuery();
                OracleCommand cmd2 = new OracleCommand("CREATE OR REPLACE TRIGGER  work_user BEFORE INSERT OR UPDATE ON customer BEGIN user_dis;END;", conn);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("Disable Done");

            }
            catch
            {
                MessageBox.Show("Not Done");

            }
        }

        private void enableUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string dbconnect = "Data Source=(DESCRIPTION =" +
               "(ADDRESS = (PROTOCOL = TCP)(HOST =127.0.0.1)(PORT = 1521))" +
               "(CONNECT_DATA =" + "(SERVER = DEDICATED)" +
               "(SERVICE_NAME = XE)));" +
               "User Id=scott;Password=tiger;";
            OracleConnection conn = new OracleConnection(dbconnect);
            OracleCommand cmd3 = new OracleCommand(" Drop trigger works_user", conn);
            OracleCommand cmd4 = new OracleCommand(" Drop trigger work_user", conn);
            conn.Open();
            cmd3.ExecuteNonQuery();
            cmd4.ExecuteNonQuery();

            MessageBox.Show("Enable Done");
        }
    }
}
