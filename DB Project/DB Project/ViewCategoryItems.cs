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
    public partial class ViewCategoryItems : Form
    {
        OracleConnection conn;
        string ordb = "data source = orcl; user id =scott; password=tiger;";
        int item_id = -1;
        public ViewCategoryItems()
        {
            InitializeComponent();
        }

        private void cbx_categName_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvCategItems.Rows.Clear();
            dgvCategItems.Refresh();
            //A. Using ODP.Net connected mode (OracleConnection and OracleCommand) to:
            //2. Select one or more rows from DB using bind variables and command parameters
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select Cat_id from item_category where cat_name=:categName";
            c.CommandType = CommandType.Text;
            c.Parameters.Add("categName", cbx_categName.SelectedItem.ToString());
            OracleDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                //A. Using ODP.Net connected mode (OracleConnection and OracleCommand) to:
                //5. Select multiple rows from DB using stored procedures.
                c.CommandText = "GetCategItems";
                c.CommandType = CommandType.StoredProcedure;
                c.Parameters.Add("id", dr.GetInt32(0));
                c.Parameters.Add("items", OracleDbType.RefCursor, ParameterDirection.Output);
                OracleDataReader d = c.ExecuteReader();
                while(d.Read())
                {
                    dgvCategItems.Rows.Add(d[0], d[1], d[2]);
                }
                d.Close();
            }
            dr.Close();
         }

        private void ViewCategoryItems_Load(object sender, EventArgs e)
        {
            //A. Using ODP.Net connected mode (OracleConnection and OracleCommand) to:
            //1. Select one or more rows from DB without where condition
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select Cat_Name from item_category";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbx_categName.Items.Add(dr[0]);
            }
            dr.Close();
        }
    }
}