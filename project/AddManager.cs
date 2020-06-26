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
    public partial class AddManager : UserControl
    {
        public AddManager()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string dbconnect = "Data Source=(DESCRIPTION =" +
                "(ADDRESS = (PROTOCOL = TCP)(HOST =127.0.0.1)(PORT = 1521))" +
                "(CONNECT_DATA =" + "(SERVER = DEDICATED)" +
                "(SERVICE_NAME = XE)));" +
                "User Id=scott;Password=tiger;";
            OracleConnection conn = new OracleConnection(dbconnect);
            OracleDataAdapter sda = new OracleDataAdapter("Select Count(*) From manager where mobile_no='" + textBoxPhn.Text.Trim() + "' ", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            OracleDataAdapter mid = new OracleDataAdapter("select max(m_id)+1 from manager",conn);
            DataTable dt1 = new DataTable();
            mid.Fill(dt1);
             string mid1 = dt1.Rows[0][0].ToString();
            //MessageBox.Show(mid1);


             if (string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxPhn.Text) || string.IsNullOrEmpty(textBoxPass.Text) || string.IsNullOrEmpty(textBoxAdd.Text))
            {
                MessageBox.Show("Please,Fill Up All");
            }

                       
                       else if (dt.Rows[0][0].ToString() == "0")
                        {
                            OracleCommand cmd = new OracleCommand("create OR REPLACE procedure add_mana( mid manager.m_id%type,mname manager.m_name%type,pas manager.pass%type,addres manager.address%type,mobileno manager.mobile_no%type,hiredat manager.hiredate%type,sal manager.salary%type,com manager.comm%type)As Begin INSERT INTO manager(m_id,m_name,pass,address,mobile_no,hiredate,salary,comm)values(mid,mname,pas,addres,mobileno,hiredat,sal,com);END add_mana;",conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();

                            OracleCommand cmd1 = new OracleCommand("BEGIN add_mana('" + mid1 + "','" + textBoxName.Text + "','" + textBoxPass.Text + "','" + textBoxAdd.Text + "','" + textBoxPhn.Text + "','" + dateTimePicker1.Text + "','30000','0');End; ", conn);
                           //BEGIN add_mana(8,'an',12,'aaa','0188','11',90,0); 
                           cmd1.ExecuteNonQuery();
                            MessageBox.Show("ok");
                            textBoxName.Text = "";
                            textBoxPass.Text = "";
                            textBoxAdd.Text = "";
                            textBoxPhn.Text = "";
                            dateTimePicker1.Text = "";

                        }
                        else
                        {
                            MessageBox.Show("Mobile Number Exits");
                            textBoxPhn.Text = "";
                        }

                        /*
                        OracleCommand cmd = new OracleCommand(@"INSERT INTO manager ([M_ID],[m_name],[pass],[address],[mobile_no],[hiredate])
                 VALUES
                       ('0','" + textBoxName.Text + "','" + textBoxPass.Text + "','" + textBoxAdd.Text + "','" + textBoxPhn.Text + "','" + dateTimePicker1.Text + "')", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("ok");*/
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void AddManager_Load(object sender, EventArgs e)
        {

        }

        private void textBoxPhn_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
