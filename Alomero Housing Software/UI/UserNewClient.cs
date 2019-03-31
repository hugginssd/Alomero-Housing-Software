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
    public partial class UserNewClient : UserControl
    {
        public UserNewClient()
        {
            InitializeComponent();
        }
        Functions fns = new Functions();
        ClientDAL cdal = new ClientDAL();
        ClientBLL cbll = new ClientBLL();
        double rate = 0;
        private void BtnCreate_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "ID" && txtDistributionNumber.Text != "Distribution number")
            {
                if (txtFirstname.Text != "Firstname " && txtLastname.Text != "Lastname ")
                {
                    if (txtIDNumber.Text != "ID Number" && txtPhoneNumber.Text != "Proffession")
                    {
                        if (txtCurrentAddress.Text != "Phone number" && txtStandNumber.Text != "Stand number")
                        {
                            if (txtAmountPaidInLocalCurrency.Text != "Amount Paid(local currency)" && txtAmoundPaidInUS.Text != "Amount Paid In US ")
                            {
                                if (txtTotalAmountToBePaid.Text != "Total Amount")
                                {
                                    try
                                    {
                                        cbll.DistributionNumber = txtDistributionNumber.Text.ToUpper().Trim();
                                        cbll.Firstname = txtFirstname.Text.ToUpper().Trim();
                                        cbll.Lastname = txtLastname.Text.ToUpper().Trim();
                                        cbll.IDNumber = txtIDNumber.Text.ToUpper().Trim();
                                        cbll.Proffession = txtProffession.Text.ToUpper().Trim();
                                        cbll.CurrentAddress = txtCurrentAddress.Text.ToUpper().Trim();
                                        cbll.PhoneNumber = txtPhoneNumber.Text.ToUpper().Trim();
                                        cbll.NOKFirstname = txtNOKFirstname.Text.ToUpper().Trim();
                                        cbll.NOKLastname = txtNOKFirstname.Text.ToUpper().Trim();
                                        cbll.NOKPhoneNumber = txtNOKPhonNumber.Text.ToUpper().Trim();
                                        cbll.StandNumber = txtStandNumber.Text.ToUpper().Trim();
                                        cbll.ResidentialArea = txtResidentialArea.Text.ToUpper().Trim();
                                        cbll.AmountPaidInUS = txtAmoundPaidInUS.Text.ToUpper().Trim();
                                        cbll.DateOfRegistration = DtpDateOfRegistration.Value.Date;
                                        cbll.TotalAmountToBePaid = Convert.ToDouble(txtTotalAmountToBePaid.Text.Trim());
                                        bool IsSuccess = cdal.Insert(cbll);
                                        if (IsSuccess)
                                        {
                                            MessageBox.Show("Allocation successfull", "New record", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                            Reset();
                                            return;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Failed to initiate a record", "UI Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.ToString(), "UI error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Please make sure all the information not tagged optional is mandatory\nTotal amount to be paid per allocation should be provided.",
                                        "Invalid information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                    return;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Please make sure all the information not tagged optional is mandatory\nLocal currency and Forex field should be filled",
                                    "Invalid information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please make sure all the information not tagged optional is mandatory\nPhone number and Stand number should be filled",
                                "Invalid information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please make sure all the information not tagged optional is mandatory\nID Number and Proffession should be field",
                            "Invalid information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Please make sure all the information not tagged optional is mandatory\nFirstname and lastname should be filled",
                        "Invalid information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please make sure all the information not tagged optional is mandatory\nID and Distribution number should be filled",
                    "Invalid information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
           
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void UserNewClient_Load(object sender, EventArgs e)
        {
            rate = fns.CalculateRate();
            txtDistributionNumber.Enabled = false;
            txtID.Enabled = false;
            txtID.Text = Convert.ToString(fns._nextId("[dbo].[Clients]"));
        }
        public void Reset()
        {
            txtAmoundPaidInUS.Clear();
            txtAmountPaidInLocalCurrency.Clear();
            txtCurrentAddress.Clear();
            txtDistributionNumber.Clear();
            txtFirstname.Clear();
            txtLastname.Clear();
            txtIDNumber.Clear();
            txtNextOFKinLastname.Clear();
            txtNOKFirstname.Clear();
            txtNOKPhonNumber.Clear();
            txtPhoneNumber.Clear();
            txtProffession.Clear();
            txtResidentialArea.Clear();
            txtStandNumber.Clear();
            txtTotalAmountToBePaid.Clear();
            DtpDateOfRegistration.Value = DateTime.Now;
            txtID.Text = Convert.ToString(fns._nextId("[dbo].[Clients]"));
        }

        private void txtStandNumber_TextChanged(object sender, EventArgs e)
        {
            txtDistributionNumber.Text = "GBL0" + txtStandNumber.Text;
        }

        private void txtAmountPaidInLocalCurrency_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtAmountPaidInLocalCurrency_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                if (txtAmountPaidInLocalCurrency.Text != "Amount Paid(local currency)")
                {
                    double amountInUS = Convert.ToDouble(txtAmountPaidInLocalCurrency.Text) / rate;
                    txtAmoundPaidInUS.Text = Convert.ToString(Math.Round(amountInUS, 2));
                }
                else
                {
                    return;
                }
            }
            catch (Exception)
            {
            }

        }
    }
}
