using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using Oracle.DataAccess.Client;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;

namespace DB_Project
{
    public partial class CustItemsForm : Form
    {
        OracleConnection conn;
        string ordb = "data source = orcl; user id =scott; password=tiger;";
        public CustItemsForm()
        {
            InitializeComponent();
        }

        OracleDataAdapter adapter;
        DataSet ds;

        private void CustItemsForm_Load(object sender, EventArgs e)
        {
            /*string conStr = "Data Source=orcl; User Id=scott; Password=tiger;";
            string commandStr = "select city from branch";

            adapter = new OracleDataAdapter(commandStr, conStr);
            ds = new DataSet();
            adapter.Fill(ds);
            cmb_Branches.DataSource = ds.Tables[0];
            cmb_Branches.DisplayMember = "city";*/
            conn = new OracleConnection(ordb);
            conn.Open();
            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select city from branch";
            c.CommandType = CommandType.Text;

            OracleDataReader drr = c.ExecuteReader();
            while (drr.Read())
            {
                cmb_Branches.Items.Add(drr[0]);
            }
            drr.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_Branches_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conStr = "Data Source=orcl; User Id=scott; Password=tiger;";
            string commandStr = @"select itm.Item_ID, QUANTITYINSTOCK, PRICE, RATE, ITEM_NAME
                                from ITEM itm, ARE_AVAILABLE_IN ari, branch b
                                where itm.ITEM_ID = ari.ITEM_ID
                                and b.B_ID = ari.B_ID and CITY = :n ";

            adapter = new OracleDataAdapter(commandStr, conStr);
            adapter.SelectCommand.Parameters.Add("n", cmb_Branches.SelectedItem.ToString());
            ds = new DataSet();
            adapter.Fill(ds);
            DGV_AllItems.DataSource = ds.Tables[0];
        }
    }
}
