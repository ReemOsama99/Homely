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
    public partial class sysUpdateCat : Form
    {
        OracleConnection conn;
        string ordb = "data source = orcl; user id =scott; password=tiger;";
        public sysUpdateCat()
        {
            InitializeComponent();
        }

        
        private void btn_updateCatBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_updateCat_Click(object sender, EventArgs e)
        {
            //A. Using ODP.Net connected mode (OracleConnection and OracleCommand) to:
            //6. Insert, Update and Delete rows using stored procedures
            // Update :

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;


            //***************procedure syntax **********************
            //create or replace procedure Update_Category
            //(CatId number,catName VARCHAR2 )
            //as
            //begin
            //update    ITEM_CATEGORY 
            //set   CAT_NAME  =   catName
            //where   CAT_ID  =   CatId  ;
            //End ;
            //******************************************************

            cmd.CommandText = "Update_Category";
            cmd.CommandType = CommandType.StoredProcedure;

            //Parameters Order : (cat_id , cat_name )
            cmd.Parameters.Add("cat_id", cbx_catID.SelectedItem.ToString());
            cmd.Parameters.Add("cat_name", txt_catName.Text);

            try
            {

                int r = cmd.ExecuteNonQuery();
                //if ( r != -1)
                {
                    MessageBox.Show("Category Modified","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Invalid Modification", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // clearing feilds
            cbx_catID.Text = "";
            txt_catName.Clear();
          
            
        }

        private void sysUpdateCat_Load(object sender, EventArgs e)
        {
           
            conn = new OracleConnection(ordb);
            conn.Open();

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

        private void btn_delCat_Click(object sender, EventArgs e)
        {

            //A. Using ODP.Net connected mode (OracleConnection and OracleCommand) to:
            //6. Insert, Update and Delete rows using stored procedures
            // Delete :

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;


 

            //***************procedure syntax **********************
            //create or replace procedure Delete_Category
            //(CatId number )
            //as
            //begin
            //Delete from ITEM_CATEGORY 
            //where   CAT_ID  =   CatId  ;
            //End ;
            //******************************************************

            cmd.CommandText = "Delete_Category";
            cmd.CommandType = CommandType.StoredProcedure;

            //Parameters  : (cat_id )
            cmd.Parameters.Add("cat_id", cbx_catID.SelectedItem.ToString());

            try
            {
                int  r= cmd.ExecuteNonQuery();
                //if ( r != -1)
                {
                    MessageBox.Show("Category Deleted","Success",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    cbx_catID.Items.RemoveAt(cbx_catID.SelectedIndex);
                }
            }
            catch
            {
                MessageBox.Show("Invalid Deletion","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

            // clearing feilds
            cbx_catID.Text = "";
       

        }
    }
}
