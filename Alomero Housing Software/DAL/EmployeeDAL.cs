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
    class EmployeeDAL
    {
        SqlConnection con = new SqlConnection("Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=alomero;Integrated Security=True");
        public bool Insert(EmployeeBLL ebll)
        {
            bool IsSuccess = false;
            string sql = "INSERT INTO [dbo].[Employees]" +
                                          "([EmployeeID]" +
                                           ",[Firstname]" +
                                           ",[Lastname]" +
                                           ",[NationalID]" +
                                           ",[Designation]" +
                                           ",[DateEmployeed])" +
                                     "VALUES" +
                                          "(@EmployeeID" +
                                          ",@Firstname" +
                                          ",@Lastname" +
                                          ",@NationalID" +
                                          ",@Designation" +
                                          ",@DateEmployeed)";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                cmd.Parameters.AddWithValue("@EmployeeID", ebll.EmployeeID);
                cmd.Parameters.AddWithValue("@Firstname", ebll.Firstname);
                cmd.Parameters.AddWithValue("@Lastname", ebll.Lastname);
                cmd.Parameters.AddWithValue("@NationalID", ebll.NationalID);
                cmd.Parameters.AddWithValue("@Designation", ebll.Designation);
                cmd.Parameters.AddWithValue("@DateEmployeed", ebll.DateEmployeed);
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
        public bool Update(EmployeeBLL ebll)
        {
            bool IsSuccess = false;
            string sql = "UPDATE[dbo].[Employees]" +
                                  "SET[Firstname] = @Firstname" +
                                      ",[Lastname] = @Lastname" +
                                      ",[NationalID] = @NationalID" +
                                      ",[Designation] = @Designation" +
                                      ",[DateEmployeed] = @DateEmployeed" +
                                 "WHERE[EmployeeID] = @EmployeeID";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                cmd.Parameters.AddWithValue("@Firstname", ebll.Firstname);
                cmd.Parameters.AddWithValue("@Lastname", ebll.Lastname);
                cmd.Parameters.AddWithValue("@NationalID", ebll.NationalID);
                cmd.Parameters.AddWithValue("@Designation", ebll.Designation);
                cmd.Parameters.AddWithValue("@DateEmployeed", ebll.DateEmployeed);
                cmd.Parameters.AddWithValue("@EmployeeID", ebll.EmployeeID);
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
        public DataTable Select(string keywords)
        {
            DataTable dt = null;
            string sql = "SELECT [ID]" +
                              ",[EmployeeID]" +
                              ",[Firstname]" +
                              ",[Lastname]" +
                              ",[NationalID]" +
                              ",[Designation]" +
                              ",[DateEmployeed]" +
                          "FROM[dbo].[Employees]" +
                           "WHERE[EmployeeID] LIKE '%" + keywords + "%'";

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
