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
    public partial class sysLoginForm : Form
    {
        public sysLoginForm()
        {
            InitializeComponent();
        }

        private void lbl_username_Click(object sender, EventArgs e)
        {

        }

        private void btn_sysLoginback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_sysLogin_Click(object sender, EventArgs e)
        {
            //check if username and password are valid
            //open system admin functions form
            SysMenu sysmenu = new SysMenu();
            sysmenu.Show();
            
        }
    }
}
