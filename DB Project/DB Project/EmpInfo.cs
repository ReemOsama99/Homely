using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace DB_Project
{
    public partial class empInfo : Form
    {
        OracleConnection conn;
        string ordb = "data source = orcl; user id =scott; password=tiger;";
        public empInfo()
        {
            InitializeComponent();
        }

        private void lbl_suppName_Click(object sender, EventArgs e)
        {

        }

        private void btn_empInfoBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void empInfo_Load(object sender, EventArgs e)
        {
            //A. Using ODP.Net connected mode (OracleConnection and OracleCommand) to:
              //1. Select one or more rows from DB without where condition
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select eid from employee";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbx_empId.Items.Add(dr[0]);
            }
            dr.Close();
        }

        private void cbx_empId_SelectedIndexChanged(object sender, EventArgs e)
        {
            //A. Using ODP.Net connected mode (OracleConnection and OracleCommand) to:
               //2. Select one or more rows from DB using bind variables and command parameters
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select emp_name, salary, email, b_id from Employee where eid=:id";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("id", cbx_empId.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                txt_empName.Text = dr[0].ToString();
                txt_empSalary.Text = dr[1].ToString();
                txt_empEmail.Text = dr[2].ToString();
                txt_empBid.Text = dr[3].ToString();
            }
            dr.Close();
        }
    }
}
