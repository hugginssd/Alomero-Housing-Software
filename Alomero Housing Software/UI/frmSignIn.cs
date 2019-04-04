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
        int count = 0;
        public string username = "";
        Form1 form1 = new Form1();
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
                username = udal.SelectRole(ubll);
                form1.lblUserName.Text = username;
                if (IsSuccess)
                {
                    Form1 form = new Form1();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid credentials", "Login", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    count = count + 1;
                }
                if (count == 3)
                {
                    MessageBox.Show("For security reasons the system does not allow numerous wrong combinations attempt.\nOne more wrong combination attempt, you will be logged out of the system.\nFor more information contact your System Administrator", "Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
        }
    }
}
