using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data;
using System.Data.SqlClient;
using Oracle.ManagedDataAccess.Client;
using System.Data.Common;

namespace project
{
    public partial class FormHome : Form
    {
        private string b;
        public FormHome()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonsignup_Click(object sender, EventArgs e)
        {
            Formsign ob = new Formsign(); 
            this.Hide();
            ob.ShowDialog();
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void textId_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void buttonsignin_Click(object sender, EventArgs e)
        {

            //try

            string id = textId.Text;
            string pass = textpass.Text;
            User n1 = new User(id,pass);

            string dbconnect = "Data Source=(DESCRIPTION =" +
                "(ADDRESS = (PROTOCOL = TCP)(HOST =127.0.0.1)(PORT = 1521))" +
                "(CONNECT_DATA =" + "(SERVER = DEDICATED)" +
                "(SERVICE_NAME = XE)));" +
                "User Id=scott;Password=tiger;";

            OracleConnection conn = new OracleConnection(dbconnect);
            conn.Open();

            
           
            //MessageBox.Show("Database connected");

            try
            {

            
            string sql = "Select count(*)a From owner where o_id='" + textId.Text.Trim() + "' and pass= '" + textpass.Text.Trim() + "'";
            
            OracleCommand oracleCommand = new OracleCommand();
            oracleCommand.Connection = conn;
            oracleCommand.CommandText = sql;
            DbDataReader dbDataReader = oracleCommand.ExecuteReader();

            if (dbDataReader.HasRows)
            {
                while (dbDataReader.Read())
                {
                    string s = dbDataReader.GetInt32(dbDataReader.GetOrdinal("a")).ToString();

                    //int s1=Int32.Parse(s);

                    if (s == "1")
                    {
                        MessageBox.Show("Welcome Owner");
                        FormOwner n = new FormOwner();
                        n.Show();
                        this.Hide();
                    }

                    else if (s != "1")
                    {
                        string sql2 = "Select count(*)b From manager where MOBILE_NO='" + textId.Text.Trim() + "' and pass= '" + textpass.Text.Trim() + "'";
                        OracleCommand oracleCommand2 = new OracleCommand();
                        oracleCommand2.Connection = conn;
                        oracleCommand2.CommandText = sql2;
                        DbDataReader dbDataReader2 = oracleCommand2.ExecuteReader();
                        if (dbDataReader2.HasRows)
                        {
                            while (dbDataReader2.Read())
                            {
                                string s2 = dbDataReader2.GetInt32(dbDataReader2.GetOrdinal("b")).ToString();
                                if (s2 == "1")
                                {
                                    MessageBox.Show("Welcome manager");
                                    this.Hide();
                                    Manager n = new Manager();
                                    n.Show();
                                }
                                else if (s != "1")
                                {
                                    string sql3 = "Select count(*)c From customer where MOBILE_NO='" + textId.Text.Trim() + "' and pass= '" + textpass.Text.Trim() + "'";
                                    OracleCommand oracleCommand3 = new OracleCommand();
                                    oracleCommand3.Connection = conn;
                                    oracleCommand3.CommandText = sql3;
                                    DbDataReader dbDataReader3 = oracleCommand3.ExecuteReader();
                                    if (dbDataReader3.HasRows)
                                    {
                                        while (dbDataReader3.Read())
                                        {
                                            string s3 = dbDataReader3.GetInt32(dbDataReader3.GetOrdinal("c")).ToString();
                                            if (s3 == "1")
                                            {
                                                MessageBox.Show("Welcome Customer");
                                                this.Hide();
                                                User n = new User();
                                                profile a = new profile(textId.Text.Trim());
                                                n.Show();
                                            }
                                            else
                                            {
                                                MessageBox.Show("Please Cheak your Phone Number Or Password again!");

                                            }
                                        }

                                    }
                                }
                            }
                        }
                    }

                    else
                    {

                        MessageBox.Show("Please Cheak your Phone Number Or Password again!");
                    }
                }

                }
            }
            catch
            {
                MessageBox.Show("Please Cheak your Phone Number Or Password again!");
            }
             

           
              

        }

        private void buttonguest_Click(object sender, EventArgs e)
        {
            User ob = new User();
            this.Hide();
            ob.ShowDialog();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormHome_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

