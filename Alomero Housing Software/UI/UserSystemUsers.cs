using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alomero_Housing_Software.BLL;
using Alomero_Housing_Software.DAL;

namespace Alomero_Housing_Software.UI
{
    public partial class UserSystemUsers : UserControl
    {
        public UserSystemUsers()
        {
            InitializeComponent();
        }
        UserDAL udal = new UserDAL();
        UserBLL ubll = new UserBLL();
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text !="ID" && txtUsername.Text!= "Username")
            {
                if (txtPassword.Text!= "Password" && txtConfirmPassword.Text!= "Confirm Password")
                {
                    if (txtPassword.Text != "" && txtConfirmPassword.Text != "")
                    {
                        if (txtUsername.Text!="")
                        {
                            if (txtPassword.Text == txtConfirmPassword.Text)
                            {   
                                try
                                {
                                    ubll.ID = Convert.ToInt32(txtID.Text.Trim());
                                    ubll.Username = txtUsername.Text.Trim();
                                    ubll.Password = txtPassword.Text.Trim();
                                    bool IsSuccess = udal.Update(ubll);
                                    if (IsSuccess)
                                    {
                                        MessageBox.Show("Successfully updated", "System user", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                        Reset();
                                        return;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Failed to initiate an update operation", "System user", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                        return;
                                    }
                                }
                                catch (Exception ex)
                                {

                                    MessageBox.Show(ex.ToString(), "UI error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                                }
                            }
                            else
                            {
                                MessageBox.Show("New password does not match the confirm password",
                                    "Invalid information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid parameters",
                                "Invalid information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid parameters",
                            "Invalid information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid parameters",
                        "Invalid information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid parameters",
                    "Invalid information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text !="" && txtSearch.Text!= "Search here...")
            {
                DataTable dt = new DataTable();
                dt = udal.Select(txtSearch.Text);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Invalid parameter","Search window",MessageBoxButtons.OKCancel,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
            }
        }

        void Reset()
        {
            txtPassword.Clear();
            txtUsername.Clear();
            txtConfirmPassword.Clear();
            txtSearch.Clear();
        }
        DataTable dt = new DataTable();
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           
            dt = udal.Select(txtSearch.Text);
            dataGridView1.DataSource = dt;
        }
    }
}
