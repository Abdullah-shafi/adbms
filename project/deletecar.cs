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
    public partial class deletecar : UserControl
    {
        public deletecar()
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
            OracleCommand cmd = new OracleCommand("Create or replace FUNCTION cvalid(cid car.c_id %type)return Boolean is count_cno number(10);Begin select count(*) into count_cno from car where c_id=cid;if count_cno=1 then return true;else return false;end if;end;", conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            OracleCommand cmd1 = new OracleCommand("create or replace PROCEDURE Delete_cid (cid car.c_id%TYPE)aS inval_cno exception;BEGIN if cvalid(cid)=true then delete from car where c_id = cid;elsif cvalid(cid)=false then raise inval_cno;end if;exception when inval_cno then dbms_output.put_line('Invalid c_id No');when no_data_found then dbms_output.put_line('doesnot Exit');END Delete_cid;", conn);
            cmd1.ExecuteNonQuery();
            OracleCommand cmd3 = new OracleCommand("begin Delete_cid('" + textBoxId.Text + "');End;", conn);
            cmd3.ExecuteNonQuery();
            textBoxId.Text = "";


        }
    }
}
