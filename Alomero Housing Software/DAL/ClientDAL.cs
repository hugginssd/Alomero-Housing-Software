using Alomero_Housing_Software.BLL;
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
    class ClientDAL
    {
        // public string connection = ConfigurationManager.ConnectionStrings["alomero_housing_software"].ToString();
        public bool Insert(ClientBLL cbll)
        {
            bool IsSuccess = false;
            SqlConnection con = new SqlConnection("Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=alomero;Integrated Security=True");
            string sql = "INSERT INTO [dbo].[Clients]" +
                                   "([DistributionNumber]" +
                                   ",[Firstname]" +
                                   ",[Lastname]" +
                                   ",[IDNumber]" +
                                   ",[Proffession]" +
                                   ",[CurrentAddress]" +
                                   ",[PhoneNumber]" +
                                   ",[NOKFirstname]" +
                                   ",[NOKLastname]" +
                                   ",[NOKPhoneNumber]" +
                                   ",[StandNumber]" +
                                   ",[ResidentialArea]" +
                                   ",[AmountPaidInInUS]" +
                                   ",[DateOfRegistration]" +
                                   ",[TotalAmountToBePaid])" +
                             "VALUES" +
                                   "(@DistributionNumber" +
                                   ",@Firstname" +
                                   ",@Lastname" +
                                   ",@IDNumber" +
                                   ",@Proffession" +
                                   ",@CurrentAddress" +
                                   ",@PhoneNumber" +
                                   ",@NOKFirstname" +
                                   ",@NOKLastname" +
                                   ",@NOKPhoneNumber" +
                                   ",@StandNumber" +
                                   ",@ResidentialArea" +
                                   ",@AmountPaidInInUS" +
                                   ",@DateOfRegistration" +
                                   ",@TotalAmountToBePaid)";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                cmd.Parameters.AddWithValue("@DistributionNumber", cbll.DistributionNumber);
                cmd.Parameters.AddWithValue("@Firstname", cbll.Firstname);
                cmd.Parameters.AddWithValue("@Lastname", cbll.Lastname);
                cmd.Parameters.AddWithValue("@IDNumber", cbll.IDNumber);
                cmd.Parameters.AddWithValue("@Proffession", cbll.Proffession);
                cmd.Parameters.AddWithValue("@CurrentAddress", cbll.CurrentAddress);
                cmd.Parameters.AddWithValue("@PhoneNumber", cbll.PhoneNumber);
                cmd.Parameters.AddWithValue("@NOKFirstname", cbll.NOKFirstname);
                cmd.Parameters.AddWithValue("@NOKLastname", cbll.NOKLastname);
                cmd.Parameters.AddWithValue("@NOKPhoneNumber", cbll.NOKPhoneNumber);
                cmd.Parameters.AddWithValue("@StandNumber", cbll.StandNumber);
                cmd.Parameters.AddWithValue("@ResidentialArea", cbll.ResidentialArea);
                cmd.Parameters.AddWithValue("@AmountPaidInInUS", cbll.AmountPaidInUS);
                cmd.Parameters.AddWithValue("@DateOfRegistration", cbll.DateOfRegistration);
                cmd.Parameters.AddWithValue("@TotalAmountToBePaid", cbll.TotalAmountToBePaid);
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
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return IsSuccess;
        }
        public bool UpdatePayment(ClientBLL cbll)
        {
            //update subcription
            bool IsSuccess = true;
            SqlConnection con = new SqlConnection();
            string sql = "UPDATE [dbo].[Clients]" +
                               "SET[StandNumber] = @StandNumber" +
                                  ",[AmountPaidInInUS] = @AmountPaidInInUS" +
                             " WHERE [DistributionNumber] = @DistributionNumber";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                cmd.Parameters.AddWithValue("@StandNumber", cbll.StandNumber);
                cmd.Parameters.AddWithValue("@AmountPaidInInUS", cbll.AmountPaidInUS);
                cmd.Parameters.AddWithValue("@DistributionNumber", cbll.DistributionNumber);
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
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return IsSuccess;
        }
        public DataTable SelectClients(string keywords)
        {
            DataTable dt = null;
            SqlConnection con = new SqlConnection("Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=alomero;Integrated Security=True");
            string sql = "SELECT [ID]" +
                              ",[DistributionNumber]" +
                              ",[Firstname]" +
                              ",[Lastname]" +
                              ",[IDNumber]" +
                              ",[StandNumber]" +
                              ",[ResidentialArea]" +
                              ",[DateOfRegistration]" +
                          "FROM[dbo].[Clients]" +
                           "WHERE[DistributionNumber] LIKE '%" + keywords + "%' OR [Firstname] LIKE '%" + keywords + "%' OR [Lastname] LIKE '%" + keywords + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Data Access Error");
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return dt;
        }
        public DataTable SelectClientPreviewdetails(string DistributionNumber)
        {
            DataTable dt = null;
            SqlConnection con = new SqlConnection("Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=alomero;Integrated Security=True");
            string sql = "SELECT [ID]" +
                              ",[DistributionNumber]" +
                              ",[Firstname]" +
                              ",[Lastname]" +
                              ",[IDNumber]" +
                              ",[Proffession]" +
                              ",[CurrentAddress]" +
                              ",[PhoneNumber]" +
                              ",[NOKFirstname]" +
                              ",[NOKLastname]" +
                              ",[NOKPhoneNumber]" +
                              ",[StandNumber]" +
                              ",[ResidentialArea]" +
                              ",[AmountPaidInInUS]" +
                              ",[DateOfRegistration]" +
                              ",[TotalAmountToBePaid]" +
                          "FROM [dbo].[Clients]" +
                           " WHERE [DistributionNumber] LIKE'%" + DistributionNumber + "%'";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Data Access Error");
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
