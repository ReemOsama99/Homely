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
    public partial class CustMenu : Form
    {
        public CustMenu()
        {
            InitializeComponent();
        }

        private void lbl_title_Click(object sender, EventArgs e)
        {

        }

        private void btn_custMenuback_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_custViewBranches_Click(object sender, EventArgs e)
        {
            CustBranchesForm viewingBranchesForm = new CustBranchesForm();
            viewingBranchesForm.Show();
        }

        private void btn_custSearch_Click(object sender, EventArgs e)
        {

        }

        private void btn_custviewItems_Click(object sender, EventArgs e)
        {
            CustItemsForm custItemsForm = new CustItemsForm();
            custItemsForm.Show();
        }

        private void btn_categItems_Click(object sender, EventArgs e)
        {
            ViewCategoryItems ctg = new ViewCategoryItems();
            ctg.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CategoriesReport categRepo = new CategoriesReport();
            categRepo.Show();
        }
    }
}
