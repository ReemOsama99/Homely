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

namespace DB_Project
{
    public partial class CustItemsForm : Form
    {
        public CustItemsForm()
        {
            InitializeComponent();
        }

        OracleDataAdapter adapter;
        DataSet ds;

        private void CustItemsForm_Load(object sender, EventArgs e)
        {
            string conStr = "Data Source=orcl; User Id=scott; Password=tiger;";
            string commandStr = "select B_ID from branch";

            adapter = new OracleDataAdapter(conStr, commandStr);
            ds = new DataSet();
            adapter.Fill(ds);
            cmb_Branches.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmb_Branches_SelectedIndexChanged(object sender, EventArgs e)
        {
            string conStr = "Data Source=orcl; User Id=scott; Password=tiger;";
            string commandStr = @"select Item_ID, QUANTITYINSTOCK, PRICE, RATE, ITEM_NAME
                                from ITEM itm, ARE_AVALIABLE_IN ari, branch b
                                where itm.ITEM_ID = ari.ITEM_ID
                                and b.B_ID = ari.B_ID and CITY = :n ";

            adapter = new OracleDataAdapter(conStr, commandStr);
            adapter.SelectCommand.Parameters.Add("n", cmb_Branches.SelectedItem);
            ds = new DataSet();
            adapter.Fill(ds);
            DGV_AllItems.DataSource = ds.Tables[0];
        }
    }
}
