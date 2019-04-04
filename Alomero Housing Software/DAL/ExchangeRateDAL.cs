using Alomero_Housing_Software.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alomero_Housing_Software.DAL
{
    class ExchangeRateDAL
    {
        SqlConnection con = new SqlConnection("Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=alomero;Integrated Security=True");

        public bool UpdateRate(ExchangeRateBLL ubll)
        {
            
                bool IsSuccess = false;
                string sql = "UPDATE [dbo].[CurrencyExchange]" +
                                   "SET[USCurrency] = @USCurrency" +
                                      ",[LocalCurrencyPerUS] = @LocalCurrencyPerUS" +
                                 " WHERE [ID] = @ID";
                SqlCommand cmd = new SqlCommand(sql, con);
                try
                {
                    cmd.Parameters.AddWithValue("@USCurrency", ubll.USCurrency);
                    cmd.Parameters.AddWithValue("@LocalCurrencyPerUS", ubll.LocalCurrency);
                    cmd.Parameters.AddWithValue("@ID", ubll.ID);
                    con.Open();
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        IsSuccess = true;
                    }
                    else
                    {
                        IsSuccess = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Data Access Error");
                } finally
                {
                    cmd.Dispose();
                    con.Close();
                }

                return IsSuccess;
            
        }
        public DataTable Select()
        {
            DataTable dt = null;
            string sql = "SELECT [ID]"+
                          ",[USCurrency] AS [CURRENCY(US$)]"+
                          ",[LocalCurrencyPerUS] AS [LOCAL CURRENCY PER US$]"+
                      " FROM[dbo].[CurrencyExchange]";
            SqlCommand cmd = new SqlCommand(sql,con);
            try
            {
                con.Open();
                dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Data Access Error");
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return dt;
        }
    }
}
