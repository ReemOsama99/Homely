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
    public partial class AddCategory : Form
    {
        OracleConnection conn;
        string ordb = "data source = orcl; user id =scott; password=tiger;";
        public AddCategory()
        {
            InitializeComponent();
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }

        private void btn_AddCatback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_AddCat_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "insert into Item_Category values (:id,:name)";
            cmd.Parameters.Add("id", txt_addCatID.Text);
            cmd.Parameters.Add("name", txt_addCatName.Text);
            int rows = cmd.ExecuteNonQuery();
            if (rows != -1)
            {
                MessageBox.Show("New Category is added");
            }
        }
    }
}
