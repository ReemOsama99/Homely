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
using Oracle.DataAccess.Types;

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
            //B. Using ODP.Net Disconnected mode (OracleDataAdapater and Dataset) to:
              //3. Insert, update, delete using oracle command builder
            string conStr = "Data Source=orcl; User Id=scott; Password=tiger;";
            string commandStr = "select * from branch";

            adapter = new OracleDataAdapter(commandStr, conStr);
            ds = new DataSet();
            adapter.Fill(ds);
            dgv_sysBranches.DataSource = ds.Tables[0];

        }

        private void btn_saveChanges_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Changes saved successfully.");
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_sysBranches_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sysBranchesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void sysBranchesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void sysBranchesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
