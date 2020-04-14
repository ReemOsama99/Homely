using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace DB_Project
{
    public partial class CategoriesReport : Form
    {
        CategoryItems cr;
        public CategoriesReport()
        {
            InitializeComponent();
        }
           //C. Using crystal reports to create reports with:
             //2. Parameters with different data types
        private void CategoriesReport_Load(object sender, EventArgs e)
        {
            cr = new CategoryItems();
            foreach (ParameterDiscreteValue p in cr.ParameterFields[0].DefaultValues)
            {
                cbx_CatNmaeRepo.Items.Add(p.Value);
            }
        }

        private void btn_catRepo_Click(object sender, EventArgs e)
        {
            cr.SetParameterValue(0, cbx_CatNmaeRepo.Text);
            cr.SetParameterValue(1, txt_maxPriceRepo.Text);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
