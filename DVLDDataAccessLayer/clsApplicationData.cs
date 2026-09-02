using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer
{
    public class clsApplicationData
    {
        //CRUD:

        //Create(AddNewPearson)                      done
        //Read(FindPearsonByID)(FindPearsonByName)   done
        //Update(UpdatePearsonInfo)                  done
        //Delete(DeletePearson)                      soon
        //Read All People(GetPeopleData)             soon
        static public bool GetApplicationByID(int ApplicationID, ref int PersonID,
            ref DateTime ApplicatoinDate, ref int ApplicationTypeID , ref short ApplicatoinStatus,
            ref DateTime LastStatusDate, ref float PaidFees, ref int CreatedByUserID)
        {
            bool isFound = false;
            string query = "select * from Applicatoins where ApplicationID=@ApplicationID";
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
                    ApplicatoinStatus = (short)reader["ApplicatoinStatus"];

                    ApplicatoinDate = (DateTime)reader["ApplicatoinDate"];
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
             DateTime ApplicatoinDate,  int ApplicationTypeID,  short ApplicatoinStatus,
             DateTime LastStatusDate,  float PaidFees,  int CreatedByUserID)
        {
            int id = -1;
            string query = @"insert into Applicatoins (PersonID,ApplicatoinDate,ApplicationTypeID,ApplicatoinStatus,LastStatusDate,PaidFees,CreatedByUserID) 
                        Values  (@PersonID,@ApplicatoinDate,@ApplicationTypeID,@ApplicatoinStatus,@LastStatusDate,@PaidFees,@CreatedByUserID) ;
                                SELECT SCOPE_IDENTITY();";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@ApplicatoinDate", ApplicatoinDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicatoinStatus", ApplicatoinStatus);
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
      
}

}

