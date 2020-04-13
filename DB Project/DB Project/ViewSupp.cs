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
    public partial class ViewSupp : Form
    {
        OracleConnection conn;
        string ordb = "data source = orcl; user id =scott; password=tiger;";
        public ViewSupp()
        {
            InitializeComponent();
        }

        private void ViewSupp_Load(object sender, EventArgs e)
        {
            //A. Using ODP.Net connected mode (OracleConnection and OracleCommand) to:
               //1. Select one or more rows from DB without where condition
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select supp_name from SUPPLIER";
            c.CommandType = CommandType.Text;

            OracleDataReader drr = c.ExecuteReader();
            while (drr.Read())
            {
                cbx_SuppName.Items.Add(drr[0]);
            }
            drr.Close();
        }

        private void cbx_SuppName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //A. Using ODP.Net connected mode (OracleConnection and OracleCommand) to:
            //4. Insert , Update and Delete rows (without using procedures)
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "GetSuppInfo";
            c.CommandType = CommandType.StoredProcedure;
            c.Parameters.Add("suppName", cbx_SuppName.SelectedItem.ToString());
            c.Parameters.Add("suppNumber", OracleDbType.Int32, ParameterDirection.Output);
            c.ExecuteNonQuery();
            try
            {
                txt_suppNumber.Text = c.Parameters["suppNumber"].Value.ToString();
            }
            catch
            {
                MessageBox.Show("no data");
            }
        }

        private void btn_viewSuppBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_viewSuppName_Click(object sender, EventArgs e)
        {

        }
    }
}
