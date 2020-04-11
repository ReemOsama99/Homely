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
    public partial class sysBranchesForm : Form
    {
        public sysBranchesForm()
        {
            InitializeComponent();
            
        }



        OracleDataAdapter adapter;
        DataSet ds;
        OracleCommandBuilder builder;
        private void btn_viewAllBranches_Click(object sender, EventArgs e)
        {
            string conStr = "Data Source=orcl; User Id=scott; Password=tiger;";
            string commandStr = "select * from branch";

            adapter = new OracleDataAdapter(conStr, commandStr);
            ds = new DataSet();
            adapter.Fill(ds);
            dgv_sysBranches.DataSource = ds.Tables[0];

        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {

        }

        private void dgv_sysBranches_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sysBranchesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
