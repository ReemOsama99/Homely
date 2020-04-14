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
    public partial class sysItemsReport : Form
    {
        ItemsReport IR;
        public sysItemsReport()
        {
            InitializeComponent();
        }

        private void sysItemsReport_Load(object sender, EventArgs e)
        {
            IR = new ItemsReport();
            ItemsReportViewer1.ReportSource = IR;
        }
    }
}
