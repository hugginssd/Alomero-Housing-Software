using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Alomero_Housing_Software.DAL;
using Alomero_Housing_Software.BLL;

namespace Alomero_Housing_Software.UI
{
    public partial class UserNewSystemUser : UserControl
    {
        public UserNewSystemUser()
        {
            InitializeComponent();
        }
        UserDAL udal = new UserDAL();
        UserBLL ubll = new UserBLL();
        Functions fns = new Functions();
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (txtID.Text!="ID" && txtEmail.Text!= "Email ID")
            {
                if (txtFirstname.Text!= "Firstname" && txtLastname.Text!= "Lastname")
                {
                   if(txtPassword.Text!= "Password" && txtRole.Text != "Confirm Password")
                    {
                        if (txtRole.Text!= "Role" && txtUsername.Text!= "Username")
                        {
                            if (txtID.Text != "" && txtEmail.Text != "")
                            {
                                if (txtFirstname.Text != "" && txtLastname.Text != "")
                                {
                                    if (txtPassword.Text != "" && txtRole.Text != "")
                                    {
                                        if (txtRole.Text != "" && txtUsername.Text != "")
                                        {
                                            if (txtPassword.Text == txtConfirmPassword.Text)
                                            {
                                                try
                                                {
                                                    ubll.ID = Convert.ToInt32(txtID.Text);
                                                    ubll.Firstname = txtFirstname.Text;
                                                    ubll.Lastname = txtLastname.Text;
                                                    ubll.NationalID = txtEmail.Text;
                                                    ubll.Role = txtRole.Text;
                                                    ubll.Username = txtUsername.Text;
                                                    ubll.Password = txtConfirmPassword.Text;
                                                    ubll.Designation = txtDesignation.Text;
                                                    bool IsSuccess = udal.Insert(ubll);
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
                                                    return;
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
            if (txtSearch.Text != "" && txtSearch.Text != "Search here...")
            {
                DataTable dt = new DataTable();
                dt = udal.Select(txtSearch.Text);
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Invalid parameter", "Search window", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private void UserNewSystemUser_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            txtID.Text = Convert.ToString(fns._nextId("[dbo].[Users]"));
        }
        void Reset()
        {
            txtFirstname.Clear();
            txtLastname.Clear();
            txtPassword.Clear();
            txtRole.Clear();
            txtSearch.Clear();
            txtUsername.Clear();
            txtConfirmPassword.Clear();
            txtDesignation.Clear();
            txtEmail.Clear();
            txtFirstname.Focus();
            txtID.Enabled = false;
            txtID.Text = Convert.ToString(fns._nextId("[dbo].[Users]"));
        }
    }
}
