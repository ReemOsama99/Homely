using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Project
{
    public partial class SysMenu : Form
    {
        public SysMenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_custMenuback_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_sysAddItem_Click(object sender, EventArgs e)
        {
            AddCategory add = new AddCategory();
            add.Show();
        }
      
        private void btn_sysManageBranches_Click(object sender, EventArgs e)
        {
            sysBranchesForm branchesForm = new sysBranchesForm();
            branchesForm.Show();

        }

        private void btn_UpdateCat_Click(object sender, EventArgs e)
        {

            UpdateItem updateitem = new UpdateItem();
            updateitem.Show();

        }

        private void btn_empInfo_Click(object sender, EventArgs e)
        {
            empInfo emp = new empInfo();
            emp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewSupp supp = new ViewSupp();
            supp.Show();
        }

        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            sysAddItem addItem = new sysAddItem();
            addItem.Show();
        }

        private void btn_sysUpdateCat_Click(object sender, EventArgs e)
        {
            sysUpdateCat updateCat = new sysUpdateCat();
            updateCat.Show();
        }
    }
}
