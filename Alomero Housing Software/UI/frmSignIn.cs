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
                ubll.Username = txtUsername.Text.Trim();
                ubll.Password = txtPassword.Text.Trim();
                bool IsSuccess = udal.SignIn(ubll);
                if (IsSuccess)
                {
                    Form1 form = new Form1();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials","Login",MessageBoxButtons.OKCancel,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);

                }
            }
        }
    }
}
