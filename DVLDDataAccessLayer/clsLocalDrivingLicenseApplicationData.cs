using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer
{
    public static class clsLocalDrivingLicenseApplicationData 
    {
        static public bool GetLocalDrivingLicenseApplicationByID(int LocalDrivingLicenseApplicationID,ref int ApplicationID,ref int LicenseClassID)
        {
            bool isFound = false;
            string query = "select * from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ApplicationID = (int)reader["ApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
                    
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

        static public int AddNewLocalDrivingLicenseApplication(int ApplicationID,int LicenseClassID)
        {
            int id = -1;
            string query = @"insert into LocalDrivingLicenseApplications (ApplicationID,LicenseClassID) 
                        Values  (@ApplicationID,@LicenseClassID,) ;
                                SELECT SCOPE_IDENTITY();";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            

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

        static public bool UpdateLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID ,int ApplicationID, int LicenseClassID)
        {
            bool ChangeWasMade = false;

            string query = @"Update LocalDrivingLicenseApplications
                                            set 
                                            ApplicationID=@ApplicationID,
                                            LicenseClassID=@LicenseClassID,
                                            
                                            where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID;";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
           

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
        static public bool DeleteLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            bool ChangeWasMade = false;
            string query = @"delete from LocalDrivingLicenseApplication where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
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
        static public DataTable GetApplicationsInfo()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT [ApplicationID]
                              ,[PersonID]
                              ,[ApplicationTypeID]
                              ,[ApplicationDate]
                              ,[ApplicationState]
                              ,[LastStatusDate]
                              ,[PaidFees]
                              ,[CreatedByUserID]
                          FROM [dbo].[Applications]   ";
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
    }
}
