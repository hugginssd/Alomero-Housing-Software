using Alomero_Housing_Software.BLL;
using Alomero_Housing_Software.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alomero_Housing_Software.UI
{
    public partial class frmSignIn : Form
    {
        public frmSignIn()
        {
            InitializeComponent();
        }
        UserDAL udal = new UserDAL();
        UserBLL ubll = new UserBLL();
        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnSignIn_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text != "Username" && txtPassword.Text != "Password")
            {
                    
            }
        }
    }
}
