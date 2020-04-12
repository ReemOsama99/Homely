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
    public partial class CustBranchesForm : Form
    {
        public CustBranchesForm()
        {
            InitializeComponent();
        }

        OracleDataAdapter adapter;
        DataSet ds;
        private void ViewingBranchesForm_Load(object sender, EventArgs e)
        {
            //B. Using ODP.Net Disconnected mode (OracleDataAdapater and Dataset) to:
              //2. Select All rows from certain table
            string conStr = "Data Source=orcl; User Id=scott; Password=tiger;";
            string commandStr = "select * from branch";

            adapter = new OracleDataAdapter(commandStr, conStr);
            ds = new DataSet();
            adapter.Fill(ds);
            DGV_AllBranches.DataSource = ds.Tables[0];
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
