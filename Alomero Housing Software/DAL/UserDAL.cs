﻿using Alomero_Housing_Software.BLL;
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
    class UserDAL
    {
        SqlConnection con= new SqlConnection("Data Source=USER-PC\\SQLEXPRESS;Initial Catalog=alomero;Integrated Security=True");
        public bool Insert(UserBLL ubll)
        {
            bool IsSuccess = false;
            string sql = "INSERT INTO [dbo].[Users]" +
                                           "([Firstname]" +
                                           ",[Lastname]" +
                                           ",[IDNumber]" +
                                           ",[Designation]" +
                                           ",[Role]" +
                                           ",[Username]" +
                                           ",[Password])" +
                                     "VALUES" +
                                           "(@Firstname" +
                                           ",@Lastname" +
                                           ",@IDNumber" +
                                           ",@Designation" +
                                           ",@Role" +
                                           ",@Username" +
                                           ",@Password)";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                cmd.Parameters.AddWithValue("@Firstname", ubll.Firstname);
                cmd.Parameters.AddWithValue("@Lastname", ubll.Lastname);
                cmd.Parameters.AddWithValue("@IDNumber", ubll.NationalID);
                cmd.Parameters.AddWithValue("@Designation", ubll.Designation);
                cmd.Parameters.AddWithValue("@Role", ubll.Role);
                cmd.Parameters.AddWithValue("@Username", ubll.Username);
                cmd.Parameters.AddWithValue("@Password", ubll.Password);
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
                          ",[Firstname]" +
                          ",[Lastname]" +
                          ",[IDNumber]" +
                          ",[Designation]" +
                          ",[Role]" +
                          ",[Username]" +
                          ",[Password]" +
                      "FROM[dbo].[Users]" +
                      " WHERE[Firstname] LIKE '%" + keywords + "%' OR [Lastname] LIKE '%" + keywords + "%' OR [Role] LIKE '%" + keywords + "%' OR [Username] LIKE '%" + keywords + "%'";
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
                dt.Clear();
                con.Close();
            }
            return dt;
        }
        public bool SignIn(UserBLL ubll)
        {
            bool IsSuccess = false;
            DataTable dt = new DataTable();
            SqlDataReader dr = null;
            string sql = "SELECT [Id]" +
                              ",[Firstname]" +
                              ",[Lastname]" +
                              ",[Username]" +
                              ",[Password]" +
                          "FROM [dbo].[Users]" +
                          " WHERE [Username] =@Username AND [Password] =@Password";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {

                cmd.Parameters.AddWithValue("@Username", ubll.Username);
                cmd.Parameters.AddWithValue("@Password", ubll.Password);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
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
                dr.Close();
                con.Close();
            }
            cmd.Dispose();
            dr.Close();
            con.Close();
            return IsSuccess;
        }
        public bool Update(UserBLL ubll)
        {
            bool IsSuccess = false;
            string sql = "UPDATE [dbo].[Users]"+
                                   "SET[Username] = @Username"+
                                      ",[Password] = @Password"+
                                    " WHERE[ID]=@ID";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
               
                cmd.Parameters.AddWithValue("@Username", ubll.Username);
                cmd.Parameters.AddWithValue("@Password", ubll.Password);
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
            }
            finally
            {
                cmd.Dispose();
                con.Close();
            }
            return IsSuccess;
        }
        public string SelectRole(UserBLL ubll)
        {
            DataTable dt = new DataTable();
            string username = "";
            SqlDataAdapter da = null;
            string sql = "SELECT [Firstname]" +
                              ",[Lastname]" +
                              ",[Username]" +
                              ",[Password]" +
                          "FROM [dbo].[Users]" +
                          " WHERE [Username] =@Username AND [Password] =@Password";
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {

                cmd.Parameters.AddWithValue("@Username", ubll.Username);
                cmd.Parameters.AddWithValue("@Password", ubll.Password);
                con.Open();
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    username = Convert.ToString(dt.Rows[0][0].ToString()+" "+ dt.Rows[0][1].ToString());
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
            cmd.Dispose();
            con.Close();
            return username;
        }
    }
}
