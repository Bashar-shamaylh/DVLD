using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer
{
    public static class clsUsersDataAccess
    {
        //CRUD:

        //Create(AddNewPearson)                      done
        //Read(FindPearsonByID)(FindPearsonByName)   done
        //Update(UpdatePearsonInfo)                  done
        //Delete(DeletePearson)                      done
        //Read All People(GetPeopleData)             done
        //UserID,UserName,UserPassword,PersonID,isActive
        static public bool GetUserByID(int userid, ref string username, ref string userpassword, ref int personid, ref bool isactive)
        {
            bool isFound = false;
            string query = "select * from Users where UserID=@userid";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@userid", userid);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    username = (string)reader["UserName"];
                    userpassword = (string)reader["UserPassword"];
                    personid = (int)reader["PersonID"];
                    isactive = (bool)reader["isActive"];
                    isFound = true;
                }

            }
            catch (Exception ex)
            {

                throw;
            }

            connection.Close();
            return isFound;

        }
        static public bool GetUserByPersonID(ref int userid, ref string username, ref string userpassword,  int personid, ref bool isactive)
        {
            bool isFound = false;
            string query = "select * from Users where PersonID=@personid";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@personid", personid);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    username = (string)reader["UserName"];
                    userpassword = (string)reader["UserPassword"];
                    userid = (int)reader["UserID"];
                    isactive = (bool)reader["isActive"];
                    isFound = true;
                }

            }
            catch (Exception ex)
            {

                throw;
            }

            connection.Close();
            return isFound;

        }
        static public int AddNewUser(string username, string userpassword, int personid, bool isactive)
        {
            int id = -1;
            string query = @"insert into Users (UserName,UserPassword,PersonID,isActive) Values  (@username,@userpassword,@personid,@isactive) ;
                                SELECT SCOPE_IDENTITY();";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@userpassword", userpassword);
            command.Parameters.AddWithValue("@personid", personid);
            command.Parameters.AddWithValue("@isactive", isactive);

            try
            {
                connection.Open();
                Object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int ID)) { id = ID; }
            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }
            return id;
        }

        static public bool UpdateUserInfo(int userid, string username, string userpassword, int personid, bool isactive)
        {
            bool ChangeWasMade = false;

            string query = @"Update Users
                                            set 
                                            UserName=@username,
                                            UserPassword=@userpassword,
                                            PersonID=@personid,
                                            isActive=@isactive
                                           
                                            where UserID=@userid;";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@userpassword", userpassword);
            command.Parameters.AddWithValue("@personid", personid);
            command.Parameters.AddWithValue("@isactive", isactive);
            command.Parameters.AddWithValue("@userid", userid);



            try
            {
                connection.Open();
                int numberofrowsaffected = command.ExecuteNonQuery();
                if (numberofrowsaffected != 0)
                {
                    ChangeWasMade = true;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

                connection.Close();
            }
            return ChangeWasMade;
        }
        static public bool DeleteUser(int userid)
        {
            bool ChangeWasMade = false;
            string query = @"delete from Users where UserID=@userid";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@userid", userid);
            try
            {
                connection.Open();
                int rowsaffected = command.ExecuteNonQuery();
                if (rowsaffected != 0)
                {
                    ChangeWasMade = true;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }
            return ChangeWasMade;
        }
        static public DataTable GetUsersInfo()
        {
            DataTable dt = new DataTable();
            string query = @"  SELECT Users.UserID,Users.PersonID,
  People.FirstName+' '+People.SecondName +' '+People.ThirdName +' '+People.LastName as fullName,Users.UserName,Users.isActive 
  from Users inner join People on Users.PersonID=People.PersonID;";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);

                }
                reader.Close();
            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }
            return dt;
        }

        //function FindUserByUserNameAndUserPassword
        static public bool FindUserByUserNameAndUserPassword(string username, string userpassword, ref bool isactive,ref int userid)
        {
            bool isFound = false;
            string query = "select * from Users where UserName=@username and UserPassword=@userpassword";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@userpassword", userpassword);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    isactive =(bool)reader["isActive"];
                    userid = (int)reader["UserID"];
                    isFound = true;
                }

            }
            catch (Exception ex)
            {

                throw;
            }

            connection.Close();
            return isFound;

        }
        static public bool isUserWithUserNameExist(string username)
        {
            bool wasFound = false;
            string query = @"select 1 from Users where UserName=@username;";

            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@username", username);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                    wasFound = true;
                else
                    wasFound = false;


            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }
            return wasFound;
        }
        static public bool isUserWithUserIDExist(int userid)
        {
            bool wasFound = false;
            string query = @"select 1 from Users where UserID=@userid;";

            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@userid", userid);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                    wasFound = true;
                else
                    wasFound = false;


            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }
            return wasFound;
        }
        static public bool isUserWithPersonIDExist(int personid)
        {
            bool wasFound = false;
            string query = @"select 1 from Users where PersonID=@personid;";

            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@personid", personid);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                    wasFound = true;
                else
                    wasFound = false;


            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }
            return wasFound;
        }
        static public bool ChangePassword(int userId, string newPassword)
        {
            bool ChangeWasMade = false;

            string query = @"Update Users set UserPassword=@newPassword,where UserID=@userId;";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            
            command.Parameters.AddWithValue("@newPassword", newPassword);
            command.Parameters.AddWithValue("@userId", userId);



            try
            {
                connection.Open();
                int numberofrowsaffected = command.ExecuteNonQuery();
                if (numberofrowsaffected != 0)
                {
                    ChangeWasMade = true;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

                connection.Close();
            }
            return ChangeWasMade;
        }
     
    }

}

