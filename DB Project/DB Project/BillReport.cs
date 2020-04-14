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
    public partial class BillReport : Form
    {
        CustomerBill br;
        public BillReport()
        {
            InitializeComponent();
        }

        private void BillReport_Load(object sender, EventArgs e)
        {
            br = new CustomerBill();
        }

        private void btn_BillReport_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = br;
        }
    }
}
