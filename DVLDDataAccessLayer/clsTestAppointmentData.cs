using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer
{
    public static class clsTestAppointmentData
    {
        static public bool GetTestAppointmentByID(int testappointmentid, ref int localdrivinglicenseid, ref DateTime appointmentdate, ref int userid, ref float paidfees,ref int testtypeid,ref bool islocked)
        {
            bool isFound = false;
            string query = "select * from TestAppointments where TestAppointmentID=@testappointmentid;";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@testappointmentid", testappointmentid);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                     localdrivinglicenseid = (int)reader["LocalDrivingLicenseID"];
                    appointmentdate = (DateTime)reader["AppointmentDate"];
                    userid = (int)reader["UserID"];
                    paidfees = Convert.ToSingle(reader["PaidFees"]);
                    testtypeid = (int)reader["TestTypeID"];
                    islocked = (bool)reader["IsLocked"];
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
        //static public bool GetUserByPersonID(ref int userid, ref string username, ref string userpassword, int personid, ref bool isactive)
        //{
        //    bool isFound = false;
        //    string query = "select * from Users where PersonID=@personid";
        //    SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
        //    SqlCommand command = new SqlCommand(query, connection);
        //    command.Parameters.AddWithValue("@personid", personid);

        //    try
        //    {
        //        connection.Open();
        //        SqlDataReader reader = command.ExecuteReader();
        //        if (reader.Read())
        //        {
        //            username = (string)reader["UserName"];
        //            userpassword = (string)reader["UserPassword"];
        //            userid = (int)reader["UserID"];
        //            isactive = (bool)reader["isActive"];
        //            isFound = true;
        //        }

        //    }
        //    catch (Exception ex)
        //    {

        //        throw;
        //    }

        //    connection.Close();
        //    return isFound;

        //}
        static public int AddNewTestAppointment( int localdrivinglicenseid,  DateTime appointmentdate,  int userid,  float paidfees,  int testtypeid,  bool islocked)
        {
            int id = -1;
            string query = @"insert into TestAppointments (LocalDrivingLicenseApplicationID,AppointmentDate,PaidFees,UserID,TestTypeID,IsLocked) Values  (@localdrivinglicenseid,@appointmentdate,@userid,@paidfees,@testtypeid,@islocked) ;
                                SELECT SCOPE_IDENTITY()";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@localdrivinglicenseid", localdrivinglicenseid);
            command.Parameters.AddWithValue("@appointmentdate", appointmentdate);
            command.Parameters.AddWithValue("@userid", userid);
            command.Parameters.AddWithValue("@paidfees", paidfees);
            command.Parameters.AddWithValue("@testtypeid", testtypeid);
            command.Parameters.AddWithValue("@islocked", islocked);

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

        static public bool UpdateTestAppointmentInfo(int testappointmentid, int localdrivinglicenseid, DateTime appointmentdate, int userid, float paidfees, int testtypeid, bool islocked)//Reduce the parameters later based on system requirements
        {
            bool ChangeWasMade = false;

            string query = @"Update TestAppointments
                                            set 
                                            AppointmentDate=@appointmentdate,
                                            LocalDrivingLicenseApplicationID=@localdrivinglicenseid,
                                            UserID=@userid,
                                            PaidFees=@paidfees,
                                            TestTypeID=@testtypeid,
                                            IsLocked=@islocked
                                           
                                            where TestAppointmentID=@testappointmentid;";  //i think i need just one parameter :IsLocked;
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@localdrivinglicenseid", localdrivinglicenseid);
            command.Parameters.AddWithValue("@appointmentdate", appointmentdate);
            command.Parameters.AddWithValue("@userid", userid);
            command.Parameters.AddWithValue("@paidfees", paidfees);
            command.Parameters.AddWithValue("@testtypeid", testtypeid);
            command.Parameters.AddWithValue("@islocked", islocked);

            command.Parameters.AddWithValue("@testappointmentid", testappointmentid);


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
        static public bool DeleteTestAppointment(int testappointmentid)
        {
            bool ChangeWasMade = false;
            string query = @"delete from TestAppointments where TestAppointmentID=@testappointmentid";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@testappointmentid", testappointmentid);
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
  //      static public DataTable GetTestAppointmentsInfo()
  //      {
  //          DataTable dt = new DataTable();
  //          string query = @"  SELECT Users.UserID,Users.PersonID,
  //People.FirstName+' '+People.SecondName +' '+People.ThirdName +' '+People.LastName as fullName,Users.UserName,Users.isActive 
  //from Users inner join People on Users.PersonID=People.PersonID;";
  //          SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
  //          SqlCommand command = new SqlCommand(query, connection);
  //          try
  //          {
  //              connection.Open();
  //              SqlDataReader reader = command.ExecuteReader();
  //              if (reader.HasRows)
  //              {
  //                  dt.Load(reader);

  //              }
  //              reader.Close();
  //          }
  //          catch (Exception)
  //          {

  //              throw;
  //          }
  //          finally { connection.Close(); }
  //          return dt;
  //      }

  //      //function FindUserByUserNameAndUserPassword
  //      static public bool FindUserByUserNameAndUserPassword(string username, string userpassword, ref bool isactive, ref int userid)
  //      {
  //          bool isFound = false;
  //          string query = "select * from Users where UserName=@username and UserPassword=@userpassword";
  //          SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
  //          SqlCommand command = new SqlCommand(query, connection);
  //          command.Parameters.AddWithValue("@username", username);
  //          command.Parameters.AddWithValue("@userpassword", userpassword);

  //          try
  //          {
  //              connection.Open();
  //              SqlDataReader reader = command.ExecuteReader();
  //              if (reader.Read())
  //              {

  //                  isactive = (bool)reader["isActive"];
  //                  userid = (int)reader["UserID"];
  //                  isFound = true;
  //              }

  //          }
  //          catch (Exception ex)
  //          {

  //              throw;
  //          }

  //          connection.Close();
  //          return isFound;

  //      }
  //      static public bool FindUserByUserNameAndUserPassword(string username, string userpassword, ref bool isactive, ref int userid, ref int personid)
  //      {
  //          bool isFound = false;
  //          string query = "select * from Users where UserName=@username and UserPassword=@userpassword";
  //          SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
  //          SqlCommand command = new SqlCommand(query, connection);
  //          command.Parameters.AddWithValue("@username", username);
  //          command.Parameters.AddWithValue("@userpassword", userpassword);

  //          try
  //          {
  //              connection.Open();
  //              SqlDataReader reader = command.ExecuteReader();
  //              if (reader.Read())
  //              {

  //                  isactive = (bool)reader["isActive"];
  //                  userid = (int)reader["UserID"];
  //                  personid = (int)reader["PersonID"];
  //                  isFound = true;
  //              }

  //          }
  //          catch (Exception ex)
  //          {

  //              throw;
  //          }

  //          connection.Close();
  //          return isFound;

  //      }
  //      static public bool isUserWithUserNameExist(string username)
  //      {
  //          bool wasFound = false;
  //          string query = @"select 1 from Users where UserName=@username;";

  //          SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
  //          SqlCommand command = new SqlCommand(query, connection);
  //          command.Parameters.AddWithValue("@username", username);
  //          try
  //          {
  //              connection.Open();
  //              object result = command.ExecuteScalar();
  //              if (result != null)
  //                  wasFound = true;
  //              else
  //                  wasFound = false;


  //          }
  //          catch (Exception)
  //          {

  //              throw;
  //          }
  //          finally { connection.Close(); }
  //          return wasFound;
  //      }
  //      static public bool isUserWithUserIDExist(int userid)
  //      {
  //          bool wasFound = false;
  //          string query = @"select 1 from Users where UserID=@userid;";

  //          SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
  //          SqlCommand command = new SqlCommand(query, connection);
  //          command.Parameters.AddWithValue("@userid", userid);
  //          try
  //          {
  //              connection.Open();
  //              object result = command.ExecuteScalar();
  //              if (result != null)
  //                  wasFound = true;
  //              else
  //                  wasFound = false;


  //          }
  //          catch (Exception)
  //          {

  //              throw;
  //          }
  //          finally { connection.Close(); }
  //          return wasFound;
  //      }
  //      static public bool isUserWithPersonIDExist(int personid)
  //      {
  //          bool wasFound = false;
  //          string query = @"select 1 from Users where PersonID=@personid;";

  //          SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
  //          SqlCommand command = new SqlCommand(query, connection);
  //          command.Parameters.AddWithValue("@personid", personid);
  //          try
  //          {
  //              connection.Open();
  //              object result = command.ExecuteScalar();
  //              if (result != null)
  //                  wasFound = true;
  //              else
  //                  wasFound = false;


  //          }
  //          catch (Exception)
  //          {

  //              throw;
  //          }
  //          finally { connection.Close(); }
  //          return wasFound;
  //      }
  //      static public bool ChangePassword(int userId, string newPassword)
  //      {
  //          bool ChangeWasMade = false;

  //          string query = @"Update Users set UserPassword=@newPassword,where UserID=@userId;";
  //          SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
  //          SqlCommand command = new SqlCommand(query, connection);


  //          command.Parameters.AddWithValue("@newPassword", newPassword);
  //          command.Parameters.AddWithValue("@userId", userId);



  //          try
  //          {
  //              connection.Open();
  //              int numberofrowsaffected = command.ExecuteNonQuery();
  //              if (numberofrowsaffected != 0)
  //              {
  //                  ChangeWasMade = true;
  //              }

  //          }
  //          catch (Exception)
  //          {

  //              throw;
  //          }
  //          finally
  //          {

  //              connection.Close();
  //          }
  //          return ChangeWasMade;
  //      }
    }
}
