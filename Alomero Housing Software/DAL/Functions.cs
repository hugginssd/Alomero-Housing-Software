using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alomero_Housing_Software.DAL
{
    class Functions
    {
        //public static string connection = ConfigurationManager.ConnectionStrings["alomero_housing"].ToString();
        public int _nextId(string table)
        {
            SqlDataAdapter da = null;
            DataTable dt = null;
            int MAX_ID = 0;
            SqlConnection con = new SqlConnection("Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=alomero;Integrated Security=True");
            string sql = "SELECT MAX(ID) + 1 FROM " + table;
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {

                con.Open();
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MAX_ID = Convert.ToInt32(dt.Rows[0][0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Function Error");
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }

            return MAX_ID;
        }
        public double CalculateRate()
        {
            double rate = 0;
            DataTable dt = null;
            SqlConnection con = new SqlConnection("Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=alomero;Integrated Security=True");
            string sql = "SELECT[LocalCurrencyPerUS]" +
                             "FROM[alomero].[dbo].[CurrencyExchange]";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    rate = Convert.ToDouble(dt.Rows[0][0].ToString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Function Error");
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return rate;
        }
    }
}
