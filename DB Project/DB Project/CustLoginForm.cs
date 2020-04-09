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
    public partial class CustLoginForm : Form
    {
        public CustLoginForm()
        {
            InitializeComponent();
        }

        private void btn_Loginback_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_custLogin_Click(object sender, EventArgs e)
        {
            //check if username and password are valid
            //open customers functions form
            CustMenu custmenu = new CustMenu();
            custmenu.Show();
            
        }
    }
}
