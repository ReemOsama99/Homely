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
    public partial class UpdateItem : Form
    {
        OracleConnection conn;
        string ordb = "data source = orcl; user id =scott; password=tiger;";
        public UpdateItem()
        {
            InitializeComponent();
        }

        private void UpdateItem_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select item_id from item";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbx_itemId.Items.Add(dr[0]);
            }
            dr.Close();

            OracleCommand c = new OracleCommand();
            c.Connection = conn;
            c.CommandText = "select cat_id from item_category";
            c.CommandType = CommandType.Text;

            OracleDataReader drr = c.ExecuteReader();
            while (drr.Read())
            {
                cbx_catID.Items.Add(drr[0]);
            }
            drr.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_updateItems_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update item set item_name=:name, quantityinstock=:quantity, price=:price, supp_name=:suppName, cat_id=:catID, rate=:rate where item_id=:id";
            cmd.Parameters.Add("name", txt_itemName);
            cmd.Parameters.Add("quantity", txt_quantityInStock);
            cmd.Parameters.Add("price", txt_price);
            cmd.Parameters.Add("suppName", txt_suppName);
            cmd.Parameters.Add("catID", cbx_catID.Text);
            //cmd.Parameters.Add("catID", cbx_catID.SelectedItem.ToString());
            cmd.Parameters.Add("rate", textBox1);
            cmd.Parameters.Add("id", cbx_itemId.Text);
            int rows = cmd.ExecuteNonQuery();
            if(rows!=-1)
            {
                MessageBox.Show("Item Modified");
            }
        }

        private void btn_IupdateIteemBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_delItems_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Delete from item where item_id=:id";
            cmd.Parameters.Add("id", cbx_itemId.SelectedItem.ToString());
            int rows = cmd.ExecuteNonQuery();
            if (rows != -1)
            {
                MessageBox.Show("Item deleted");
                //cbx_itemId.Items.RemoveAt(cbx_itemId.SelectedIndex);
            }
        }
    }
}
