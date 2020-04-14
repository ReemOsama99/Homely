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

namespace DB_Project
{
    public partial class sysAddItem : Form
    {
        OracleConnection conn;
        string ordb = "data source = orcl; user id =scott; password=tiger;";
        public sysAddItem()
        {
            InitializeComponent();
        }

        private void btn_AddCatback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddCat_Click(object sender, EventArgs e)
        {
            //A. Using ODP.Net connected mode (OracleConnection and OracleCommand) to:
            //6. Insert , Update and Delete rows using stored procedures
            //Insert
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            // ************* Procedure syntex ***********
            // create or replace procedure Insert_item 
            //(itemId number,catId number,quantity number,itemPrice number, itemName VARCHAR2,suppName VARCHAR2)
            //as
            //begin
            //insert  into  item
            //(item_id , cat_id , quantityinstock, price,rate, item_name, supp_name)
            //Values(itemId ,catId ,quantity ,itemPrice ,'0' , itemName ,suppName ) ;
            //End ;
            //************************************************

            cmd.CommandText = "Insert_item";
            cmd.CommandType = CommandType.StoredProcedure;

            //Parameters Order : (item_id , cat_id , quantity, price, item_name, supp_name)
            cmd.Parameters.Add("item_id", txt_itemID.Text);
            cmd.Parameters.Add("cat_id", cbx_catID.SelectedItem.ToString());
            cmd.Parameters.Add("quantity", txt_quantityInStock.Text);
            cmd.Parameters.Add("price", txt_price.Text);
            cmd.Parameters.Add("item_name", txt_itemName.Text);
            cmd.Parameters.Add("supp_name", cbx_ItemSupp.SelectedItem.ToString());

            try
            {

                int r = cmd.ExecuteNonQuery();
                if ( r != -1)
                {
                    MessageBox.Show("New Item is added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
              
            }
            catch
            {
                MessageBox.Show("Invalid Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // clearing feilds
            txt_price.Clear();
            txt_itemID.Clear();
            txt_itemName.Clear();
            txt_quantityInStock.Clear();
            cbx_catID.Text = "";
            cbx_ItemSupp.Text = "";
        }

        private void sysAddItem_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select SUPP_NAME from SUPPLIER";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbx_ItemSupp.Items.Add(dr[0]);
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
    }
}
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace DB_Project
{
    public partial class sysAddItem : Form
    {
        OracleConnection conn;
        string ordb = "data source = orcl; user id =scott; password=tiger;";
        public sysAddItem()
        {
            InitializeComponent();
        }

        private void btn_AddCatback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddCat_Click(object sender, EventArgs e)
        {
            //A. Using ODP.Net connected mode (OracleConnection and OracleCommand) to:
            //6. Insert , Update and Delete rows using stored procedures
            //Insert
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            // ************* Procedure syntex ***********
            // create or replace procedure Insert_item 
            //(itemId number,catId number,quantity number,itemPrice number, itemName VARCHAR2,suppName VARCHAR2)
            //as
            //begin
            //insert  into  item
            //(item_id , cat_id , quantityinstock, price,rate, item_name, supp_name)
            //Values(itemId ,catId ,quantity ,itemPrice ,'0' , itemName ,suppName ) ;
            //End ;
            //************************************************

            cmd.CommandText = "Insert_item";
            cmd.CommandType = CommandType.StoredProcedure;

            //Parameters Order : (item_id , cat_id , quantity, price, item_name, supp_name)
            cmd.Parameters.Add("item_id", txt_itemID.Text);
            cmd.Parameters.Add("cat_id", cbx_catID.SelectedItem.ToString());
            cmd.Parameters.Add("quantity", txt_quantityInStock.Text);
            cmd.Parameters.Add("price", txt_price.Text);
            cmd.Parameters.Add("item_name", txt_itemName.Text);
            cmd.Parameters.Add("supp_name", cbx_ItemSupp.SelectedItem.ToString());

            try
            {

                int r = cmd.ExecuteNonQuery();
                //if ( r != -1)
                {
                    MessageBox.Show("New Item is added");
                }
              
            }
            catch
            {
                MessageBox.Show("Invalid Information");
            }
            // clearing feilds
            txt_price.Clear();
            txt_itemID.Clear();
            txt_itemName.Clear();
            txt_quantityInStock.Clear();
            cbx_catID.Text = "";
            cbx_ItemSupp.Text = "";
        }

        private void sysAddItem_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select SUPP_NAME from SUPPLIER";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbx_ItemSupp.Items.Add(dr[0]);
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
    }
}
>>>>>>> f9841237d5754fc90a08866ae6773c4fa4e8ade6
