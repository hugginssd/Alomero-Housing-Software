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
    public partial class UserExchangeRate : UserControl
    {
        public UserExchangeRate()
        {
            InitializeComponent();
        }
        ExchangeRateBLL exchangeRateBLL = new ExchangeRateBLL(); //
        ExchangeRateDAL exchangeRateDAL = new ExchangeRateDAL();
        private void UserExchangeRate_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = exchangeRateDAL.Select();
            dataGridView1.DataSource = dt;
            
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (txtLocalExchange.Text != "New Exchange Rate (US)" && txtUsExchangeRate.Text != "New Exchange Rate (local)")
            {
                if (txtLocalExchange.Text != "" && txtUsExchangeRate.Text != "")
                {
                    try
                    {
                        exchangeRateBLL.ID = Convert.ToInt32(lblID.Text);
                        exchangeRateBLL.LocalCurrency = Convert.ToDouble(txtLocalExchange.Text);
                        exchangeRateBLL.USCurrency = Convert.ToInt32(txtUsExchangeRate.Text);
                        bool IsSuccess = exchangeRateDAL.UpdateRate(exchangeRateBLL);
                        if (IsSuccess)
                        {
                            MessageBox.Show("Successfully updated ", "Exchange Rate Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            Reset();
                            DataTable dt = new DataTable();
                            dt = exchangeRateDAL.Select();
                            dataGridView1.DataSource = dt;
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Failed to initiate update operation", "Exchange Rate Update", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString(),"UI Error",MessageBoxButtons.OKCancel,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid entry","Invalid information",MessageBoxButtons.OKCancel,MessageBoxIcon.Error,MessageBoxDefaultButton.Button1);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Invalid entry", "Invalid information", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        void Reset()
        {
            txtLocalExchange.Clear();
            txtUsExchangeRate.Clear();
            txtLocalExchange.Focus();
        }

    }
}
