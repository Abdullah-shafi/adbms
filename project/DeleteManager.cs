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
    public partial class DeleteManager : UserControl
    {
        public DeleteManager()
        {
            InitializeComponent();
        }

        private void DeleteManager_Load(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {

            string dbconnect = "Data Source=(DESCRIPTION =" +
                 "(ADDRESS = (PROTOCOL = TCP)(HOST =127.0.0.1)(PORT = 1521))" +
                 "(CONNECT_DATA =" + "(SERVER = DEDICATED)" +
                 "(SERVICE_NAME = XE)));" +
                 "User Id=scott;Password=tiger;";
            OracleConnection conn = new OracleConnection(dbconnect);
            OracleCommand cmd = new OracleCommand("Create or replace FUNCTION mvalid(mid manager.m_id %type)return Boolean is count_mno number(10);Begin select count(*) into count_mno from manager where m_id=mid;if count_mno=1 then return true;else return false;end if;end;", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            OracleCommand cmd1 = new OracleCommand("create or replace PROCEDURE Delete_mid (mid manager.m_id%TYPE)aS inval_mno exception;BEGIN if mvalid(mid)=true then delete from manager where m_id = mid;elsif mvalid(mid)=false then raise inval_mno;end if;exception when inval_mno then dbms_output.put_line('Invalid m_id No');when no_data_found then dbms_output.put_line('doesnot Exit');END Delete_mid;", conn);
            cmd1.ExecuteNonQuery();
            OracleCommand cmd3 = new OracleCommand("begin Delete_mid('" + textBoxId.Text + "');End;", conn);
            cmd3.ExecuteNonQuery();
            textBoxId.Text = "";

        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelId_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
