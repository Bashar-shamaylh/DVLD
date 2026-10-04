using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer
{
    public static class clsTestsData
    {
        
        static public bool GetTestByID(int testid, ref int testappointmentid, ref bool testresult, ref string notes, ref int createdbyuserid)
        {
            bool isFound = false;
            string query = "select * from Tests where TestID=@testid";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@testid", testid);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    testappointmentid = (int)reader["TestAppointmentID"];
                    testresult = (bool)reader["TestResult"];
                    notes = (string)reader["Notes"];
                    createdbyuserid = (int)reader["CreatedByUserID"];
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
       
        static public int AddTestUser( int testappointmentid,  bool testresult,  string notes,  int createdbyuserid)
        {
            int id = -1;
            string query = @"insert into Tests (TestAppointmentID,TestResult,Notes,CreatedByUserID) Values  (@testappointmentid,@testresult,@notes,@createdbyuserid) ;
                                SELECT SCOPE_IDENTITY();";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@testappointmentid", testappointmentid);
            command.Parameters.AddWithValue("@testresult", testresult);
            command.Parameters.AddWithValue("@notes", notes);
            command.Parameters.AddWithValue("@createdbyuserid", createdbyuserid);

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
        
        static public bool UpdateTestInfo(int testid,int testappointmentid, bool testresult, string notes, int createdbyuserid)
        {
            bool ChangeWasMade = false;

            string query = @"Update Tests
                                            set 
                                            TestAppointmentID=@testappointmentid,
                                            TestResult=@testresult,
                                            Notes=@notes,
                                            CreatedByUserID=@createdbyuserid
                                           
                                            where TestID=@testid;";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@testid", testid);
            command.Parameters.AddWithValue("@testappointmentid", testappointmentid);
            command.Parameters.AddWithValue("@testresult", testresult);
            command.Parameters.AddWithValue("@notes", notes);

            command.Parameters.AddWithValue("@createdbyuserid", createdbyuserid);



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
        static public bool DeleteTest(int testid)
        {
            bool ChangeWasMade = false;
            string query = @"delete from Tests where TestID=@testid";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@testid", testid);
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
  //      static public DataTable GetUsersInfo()
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
       
    }
}
