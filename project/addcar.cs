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
using System.IO;
using Oracle.ManagedDataAccess.Client;
using System.Data.Common;

namespace project
{
    public partial class addcar : UserControl
    {
        public addcar()
        {
            InitializeComponent();
        }
        string imgLocation = "";

        private void button2_Click(object sender, EventArgs e)
        {
            string name = this.nametextbox.Text;
            string num = this.pricetextbox.Text;
            string add = this.detailstextbox.Text;
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(num) || string.IsNullOrEmpty(add))
            {
                MessageBox.Show("Please,Fill Up All");
            }
            else
                MessageBox.Show("Data Saved Successfully");

            string dbconnect = "Data Source=(DESCRIPTION =" +
               "(ADDRESS = (PROTOCOL = TCP)(HOST =127.0.0.1)(PORT = 1521))" +
               "(CONNECT_DATA =" + "(SERVER = DEDICATED)" +
               "(SERVICE_NAME = XE)));" +
               "User Id=scott;Password=tiger;";

            OracleConnection conn = new OracleConnection(dbconnect);
            OracleDataAdapter mid = new OracleDataAdapter("select max(c_id)+1 from car", conn);
            DataTable dt1 = new DataTable();
            mid.Fill(dt1);
            string mid1 = dt1.Rows[0][0].ToString();
            OracleCommand cmd = new OracleCommand("create OR REPLACE procedure add_car( cid car.c_id%type,cname car.c_name%type,MODELS car.MODEL%type,PRIC car.PRICE%type,AVAILABLIT car.AVAILABLITY%type,SALEAMOUN car.SALEAMOUNT%type)As Begin INSERT INTO car(c_id,c_name,MODEL,PRICE,AVAILABLITY,SALEAMOUNT)values(cid,cname,MODELS,PRIC,AVAILABLIT,SALEAMOUN);END add_car;", conn);
                conn.Open();
            cmd.ExecuteNonQuery();
            string m2 = "0";

            OracleCommand cmd1 = new OracleCommand("BEGIN add_car('" + mid1 + "','" + nametextbox.Text + "','" + detailstextbox.Text + "','" + pricetextbox.Text + "','" + availabletextbox.Text + "','" + m2 + "');End; ", conn);
            cmd1.ExecuteNonQuery();
            conn.Close();
        }

      
    }
}
 