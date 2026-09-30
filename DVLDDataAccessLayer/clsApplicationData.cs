using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace DVLDDataAccessLayer
{
    public class clsApplicationData
    {
        
        static public bool GetApplicationByID(int ApplicationID, ref int PersonID,
            ref DateTime ApplicatoinDate, ref int ApplicationTypeID , ref short ApplicatoinStatus,
            ref DateTime LastStatusDate, ref float PaidFees, ref int CreatedByUserID)
        {
            bool isFound = false;
            string query = "select * from Applications where ApplicationID=@ApplicationID";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    PersonID = (int)reader["PersonID"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    ApplicatoinStatus = Convert.ToInt16(reader["ApplicationState"]);

                    ApplicatoinDate = (DateTime)reader["ApplicationDate"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];

                    PaidFees = Convert.ToSingle(reader["PaidFees"]);
                    
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
       
        static public int AddNewApplication( int PersonID,
             DateTime ApplicationDate,  int ApplicationTypeID,  short ApplicationState,
             DateTime LastStatusDate,  float PaidFees,  int CreatedByUserID)
        {
            int id = -1;
            string query = @"insert into Applications (PersonID,ApplicationDate,ApplicationTypeID,ApplicationState,LastStatusDate,PaidFees,CreatedByUserID) 
                        Values  (@PersonID,@ApplicationDate,@ApplicationTypeID,@ApplicationState,@LastStatusDate,@PaidFees,@CreatedByUserID) ;
                                SELECT SCOPE_IDENTITY();";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationState", ApplicationState);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            
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

        static public bool UpdateApplicatoinInfo(int ApplicationID,int PersonID,
             DateTime ApplicatoinDate, int ApplicationTypeID, short ApplicatoinStatus,
             DateTime LastStatusDate, float PaidFees, int CreatedByUserID)
        {
            bool ChangeWasMade = false;

            string query = @"Update Applications
                                            set 
                                            PersonID=@PersonID,
                                            ApplicatoinDate=@ApplicatoinDate,
                                            ApplicationTypeID=@ApplicationTypeID,
                                            ApplicatoinStatus=@ApplicatoinStatus,
                                            LastStatusDate=@LastStatusDate,
                                            PaidFees=@PaidFees,
                                            CreatedByUserID=@CreatedByUserID,
                                            
                                            where ApplicationID=@ApplicationID;";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@ApplicatoinDate", ApplicatoinDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicatoinStatus", ApplicatoinStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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
        static public bool DeleteApplicatoin(int ApplicationID)
        {
            bool ChangeWasMade = false;
            string query = @"delete from Applications where ApplicationID=@ApplicationID";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
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
        static public bool UpdateApplicationState(int ApplicationID,short ApplicationState)
        {
            bool ChangeWasMade = false;

            string query = @"Update Applications
                                            set 
                                            
                                            ApplicationState=@ApplicationState
                                            
                                            where ApplicationID=@ApplicationID;";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

           
            command.Parameters.AddWithValue("@ApplicationState", ApplicationState);
           
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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
        static public bool isApplicationExist(int ApplicationID)
        {
            bool wasFound = false;
            string query = @"select 1 from Applications Where ApplicationID=@ApplicationID;";

            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
      
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
        public static bool DoesPersonHaveActiveApplication(int PersonID,int ApplicationTypeID)
        {
            return (GetActiveApplicationID (PersonID,ApplicationTypeID)!= -1);
        }
       public static int GetActiveApplicationID(int PersonID,int ApplicationTypeID)
        {
            int ActiveApplicationID = -1;
            string query = "select ActiveApplicationID=ApplicationID from Applications where PersonID=@PersonID and ApplicationTypeID=@ApplicationTypeID and ApplicationState=1";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ActiveApplicationID = (int)reader["ActiveApplicationID"];
            
                }

            }
            catch (Exception ex)
            {

                throw;
            }

            connection.Close();
            return ActiveApplicationID;

        }
       public  static int GetActiveApplicationIDForLicenseClass(int PersonID, int ApplicationTypeID,int LicenseClassID)
        {
            int ActiveApplicationID = -1;
            string query = "select ActiveApplicationID=Applications.ApplicationID from Applications inner join LocalDrivingLicenseApplication On Applications.ApplicationID=LocalDrivingLicenseApplication.ApplicationID\r\n\r\n where PersonID=@PersonID and ApplicationTypeID=@ApplicationTypeID and ApplicationState=1  and LicenseClassID=@LicenseClassID;";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    ActiveApplicationID = (int)reader["ActiveApplicationID"];

                }

            }
            catch (Exception ex)
            {

                throw;
            }

            connection.Close();
            return ActiveApplicationID;

        }
    }

}

