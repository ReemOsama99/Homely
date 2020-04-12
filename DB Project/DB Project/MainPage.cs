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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_customer_Click(object sender, EventArgs e)
        {
            CustMenu custmenu = new CustMenu();
            custmenu.Show();
        }

        private void btn_sysAdmin_Click(object sender, EventArgs e)
        {
            SysMenu sysmenu = new SysMenu();
            sysmenu.Show();
        }
    }
}
