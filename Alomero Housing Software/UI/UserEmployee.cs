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

namespace Alomero_Housing_Software.BLL
{
    public partial class UserEmployeeBLL : UserControl
    {
        public UserEmployeeBLL()
        {
            InitializeComponent();
        }
        EmployeeBLL ebll = new EmployeeBLL();
        EmployeeDAL edal = new EmployeeDAL();
        Functions fns = new Functions();
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "ID" && txtEmployeeID.Text != "Employee ID")
            {
                if (txtFirstname.Text != "Firstname" && txtLastname.Text != "Lastname")
                {
                    if (txtNationalID.Text != "National ID" && txtDesignation.Text != "Designation")
                    {
                        try
                        {
                            ebll.EmployeeID = txtEmployeeID.Text.ToUpper().Trim();
                            ebll.Firstname = txtFirstname.Text.ToUpper().Trim();
                            ebll.Lastname = txtLastname.Text.ToUpper().Trim();
                            ebll.NationalID = txtNationalID.Text.ToUpper().Trim();
                            ebll.Designation = txtDesignation.Text.ToUpper().Trim();
                            ebll.DateEmployeed = DtpDateEmployeed.Value.Date;
                            bool IsSuccess = edal.Insert(ebll);
                            if (IsSuccess)
                            {
                                MessageBox.Show("Successfully created", "New record", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                Reset();
                                string[] arr = new string[] { txtID.Text, txtEmployeeID.Text.ToUpper(), txtFirstname.Text.ToUpper(), txtLastname.Text.ToUpper(), txtNationalID.Text.ToUpper(), txtDesignation.Text.ToUpper(), DtpDateEmployeed.Value.ToShortDateString() };
                                dataGridView1.Rows.Add(arr);
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Failed to initiate a record", "New record", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                return;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "UI Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            return;
                        }
                    }
                    MessageBox.Show("Please make sure all the information not tagged optional is mandatory\nID Number and Designation should be field",
                          "Invalid information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
                MessageBox.Show("Please make sure all the information not tagged optional is mandatory\nFirstname and Lastname should be field",
                          "Invalid information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            MessageBox.Show("Please make sure all the information not tagged optional is mandatory\nID and Employee ID should be field",
                          "Invalid information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            return;
        }

        private void Reset()
        {
            txtID.Text = Convert.ToString(fns._nextId("[dbo].[Employees]"));
            txtEmployeeID.Text = "EMP00" + Convert.ToString(fns._nextId("[dbo].[Employees]"));
            txtFirstname.Clear();
            txtLastname.Clear();
            txtNationalID.Clear();
            txtDesignation.Clear();
            DtpDateEmployeed.Value = DateTime.Now;
            txtSearch.Clear();

        }

        private void UserEmployeeBLL_Load(object sender, EventArgs e)
        {
            txtID.Text = Convert.ToString(fns._nextId("[dbo].[Employees]"));
            txtEmployeeID.Text = "EMP00" + Convert.ToString(fns._nextId("[dbo].[Employees]"));
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text != "Search here...")
            {
                DataTable dt = new DataTable();
                dt = edal.Select(txtSearch.Text.Trim());
                dataGridView1.DataSource = dt;
                return;
            }
            else
            {
                MessageBox.Show("Please use Employee Id to search a record",
                          "Invalid parameter", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}
