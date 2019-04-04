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
    public partial class UserUpdatePayment : UserControl
    {
        public UserUpdatePayment()
        {
            InitializeComponent();
        }
        ClientDAL cdal = new ClientDAL();
        ClientBLL cbll = new ClientBLL();
        Functions fns = new Functions();
        double rate = 0;
        double AmountInUS = 0;
        private void UserUpdatePayment_Load(object sender, EventArgs e)
        {
            try
            {
                rate = fns.CalculateRate();
            }
            catch (Exception)
            {
            }

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = cdal.SelectClients(txtSearch.Text.Trim());
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtDistributionNumber.Text = dataGridView1.SelectedCells[1].Value.ToString();
                txtStandNumber.Text = dataGridView1.SelectedCells[5].Value.ToString();
                DataTable dt = new DataTable();
                dt = cdal.SelectClientPreviewdetails(txtDistributionNumber.Text.Trim());
                if (dt.Rows.Count > 0)
                {
                    txtFirstname.Text = dataGridView1.SelectedCells[2].Value.ToString();
                    txtLastname.Text = dataGridView1.SelectedCells[3].Value.ToString();
                    txtProffession.Text = dt.Rows[0][5].ToString();
                    txtContactNumber.Text = dt.Rows[0][7].ToString();
                    txtNOKFirstname.Text = dt.Rows[0][8].ToString();
                    txtNOKLastname.Text = dt.Rows[0][9].ToString();
                    txtNOKPhoneNumber.Text = dt.Rows[0][10].ToString();
                    txtResidentialArea.Text = dt.Rows[0][12].ToString();
                    txtAmountPaidInUS.Text = "US$" + dt.Rows[0][13].ToString();
                    AmountInUS = Convert.ToDouble(dt.Rows[0][13].ToString());
                    txtDateRegistered.Text = dt.Rows[0][14].ToString();
                    txtTotalAmountToBePaid.Text = "US$" + dt.Rows[0][15].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAmount_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                double amountInUS = Convert.ToDouble(txtAmount.Text) / rate;
                txtAmountInUS.Text = Convert.ToString(Math.Round(amountInUS, 2));
            }
            catch (Exception)
            {

            }
                
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //double previous = Convert.ToDouble(AmountInUS);
            //MessageBox.Show(previous.ToString());
            if (txtDistributionNumber.Text != "Distribution number" && txtStandNumber.Text != "Stand number")
            {
                if (txtAmountInUS.Text != "Amount In US$" && txtAmount.Text != "Amount To Pay(local currency)")
                {
                    try
                    {
                        //MessageBox.Show(Convert.ToString(Convert.ToDouble(txtAmountInUS.Text.Trim()) + AmountInUS));
                      
                        cbll.StandNumber = txtStandNumber.Text.ToUpper().Trim();
                        cbll.AmountPaidInUS = Convert.ToString(Convert.ToDouble(txtAmountInUS.Text.Trim()) + AmountInUS);
                        cbll.DistributionNumber = txtDistributionNumber.Text.ToUpper().Trim();
                        bool IsSuccess = cdal.UpdatePayment(cbll);
                        if (IsSuccess)
                        {
                            MessageBox.Show("Successfully processed payment", "Payment update", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            Reset();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Failed to initiate payment", "UI Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            return;
                        }
                    }
                    catch (Exception)
                    {
                    }

                }
                else
                {
                    MessageBox.Show("Fill in the amount in local currency", "Invalid entry", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Select the record to make payment from the table", "Invalid selection", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
        }

        private void Reset()
        {
            txtAmount.Clear();
            txtAmountInUS.Clear();
            txtAmountPaidInUS.Clear();
            txtContactNumber.Clear();
            txtDateRegistered.Clear();
            txtFirstname.Clear();
            txtLastname.Clear();
            txtContactNumber.Clear();
            txtNOKFirstname.Clear();
            txtNOKLastname.Clear();
            txtNOKPhoneNumber.Clear();
            txtSearch.Clear();
            txtStandNumber.Clear();
            txtResidentialArea.Clear();
            txtTotalAmountToBePaid.Clear();
            txtSearch.Focus();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
