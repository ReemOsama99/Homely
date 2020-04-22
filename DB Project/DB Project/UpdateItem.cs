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
            //A. Using ODP.Net connected mode (OracleConnection and OracleCommand) to:
               //1. Select one or more rows from DB without where condition
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


            OracleCommand com = new OracleCommand();
            com.Connection = conn;
            com.CommandText = "select SUPP_NAME from SUPPLIER";
            com.CommandType = CommandType.Text;

            OracleDataReader data = com.ExecuteReader();
            while (data.Read())
            {
                cbx_ItemSupp.Items.Add(data[0]);
            }
            data.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //A. Using ODP.Net connected mode (OracleConnection and OracleCommand) to:
           //3. Insert , Update and Delete rows (without using procedures)
           //Update and delete
        private void btn_updateItems_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update item set item_name=:name, quantityinstock=:quantity, price=:price, supp_name=:suppName, cat_id=:catID where item_id=:id";
            cmd.Parameters.Add("name", txt_itemName.Text);
            cmd.Parameters.Add("quantity", txt_quantityInStock.Text);
            cmd.Parameters.Add("price", txt_price.Text);
            cmd.Parameters.Add("suppName", cbx_ItemSupp.SelectedItem.ToString());
            cmd.Parameters.Add("catID", cbx_catID.SelectedItem.ToString());
            cmd.Parameters.Add("id", cbx_itemId.SelectedItem.ToString());
            try
            {
                int rows = cmd.ExecuteNonQuery();
                if (rows != -1)
                {
                    MessageBox.Show("Item Modified", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Invalid Modification", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txt_itemName.Clear();
            txt_price.Clear();
            txt_quantityInStock.Clear();
            cbx_ItemSupp.Text = "";
            cbx_catID.Text = "";
            cbx_itemId.Text = "";
        }

        private void btn_IupdateIteemBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateItem_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void btn_delItems_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "Delete from item where item_id=:id";
            cmd.Parameters.Add("id", cbx_itemId.SelectedItem.ToString());
            try
            {
                int rows = cmd.ExecuteNonQuery();
                if (rows != -1)
                {
                    MessageBox.Show("Item Deleted", "Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Invalid Deletion", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txt_itemName.Clear();
            txt_price.Clear();
            txt_quantityInStock.Clear();
            cbx_ItemSupp.Text = "";
            cbx_catID.Text = "";
            cbx_itemId.Text = "";
        }

        private void cbx_itemId_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void UpdateItem_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}
