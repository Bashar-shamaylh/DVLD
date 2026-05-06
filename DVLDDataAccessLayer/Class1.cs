using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Globalization;
using System.Data;
namespace DVLDDataAccessLayer
{
    public  class clsPeopleDataAccess
    {
        //CRUD:

        //Create(AddNewPearson)                      done
        //Read(FindPearsonByID)(FindPearsonByName)   done
        //Update(UpdatePearsonInfo)                  done
        //Delete(DeletePearson)                      soon
        //Read All People(GetPeopleData)             soon
        static public bool GetPearsonByID(int id,ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref string NationalNumber,ref DateTime DateOfBirth,ref string Address,ref string Phone,ref string Email,ref int CountryID ,ref string PearsonPicturePath,ref char Gendor)
        {
            bool isFound = false;
            string query = "select * from People where PearsonID=@id";
            SqlConnection connection=new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command=new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id",id);
           
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    ThirdName = (string)reader["ThirdName"];
                    LastName = (string)reader["LastName"];
                    NationalNumber = (string)reader["NationalNumber"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gendor = (char)reader["Gendor"];
                    if (reader["Address"] != DBNull.Value)
                        Address = (string)reader["Address"];
                    else
                        Address = null;
                    if (reader["Phone"] != DBNull.Value)
                        Phone = (string)reader["Phone"];
                    else
                        Phone = null;
                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];
                    else
                        Email = null;
                    CountryID= (int)reader["CountryID"];
                    if (reader["PearsonPicturePath"] != DBNull.Value)
                        PearsonPicturePath = (string)reader["PearsonPicturePath"];
                    else
                        PearsonPicturePath = null;
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
        static public int AddNewPerson(string nationnalNumber, string firstname, string secondname, string thirdname, string lastname, DateTime dateOfBirth,string address,string phone,string email,int countryID,string personImagePath,char gendor)
        {
            int id = -1;
            string query = @"insert into People (NationalNumber,DateOfBirth,Address,Phone,Email,CountryID,PersonalPicturePath,FirstName,SecondName,ThirdName,LastName,Gendor) Values  (@nationnalNumber,@dateOfBirth,@address,@phone,@email,@countryID,@personImagePath,@firstname,@secondname,@thirdname,@lastname,@gendor) ;
                                SELECT SCOPE_IDENTITY();";
            SqlConnection connection=new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command=new SqlCommand(query, connection);
            
            command.Parameters.AddWithValue("@nationnalNumber", nationnalNumber);
            command.Parameters.AddWithValue("@firstname", firstname);
            command.Parameters.AddWithValue("@secondname", secondname);
            command.Parameters.AddWithValue("@thirdname", thirdname);
            command.Parameters.AddWithValue("@lastname", lastname);
            command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
            command.Parameters.AddWithValue("@gendor", gendor);
            if (address == "")
            {
                command.Parameters.AddWithValue("@address", System.DBNull.Value);
            }
            else { command.Parameters.AddWithValue("@address", address); }
            if (phone == "")
            {
                command.Parameters.AddWithValue("@phone", System.DBNull.Value);
            }
            else { command.Parameters.AddWithValue("@phone", phone); }
            if (email == "")
            {
                command.Parameters.AddWithValue("@email", System.DBNull.Value);
            }
            else { command.Parameters.AddWithValue("@email", email); }
           
            command.Parameters.AddWithValue("@countryID", countryID);
            if (personImagePath == "")
            {
                command.Parameters.AddWithValue("@personImagePath", System.DBNull.Value);
            }
            else { command.Parameters.AddWithValue("@personImagePath", personImagePath); }
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

        static public bool UpdatePersonInfo(int id,string nationnalNumber, string firstname, string secondname, string thirdname, string lastname, DateTime dateOfBirth, string address, string phone, string email, int countryID, string personImagePath,char gendor)
        {
            bool ChangeWasMade = false;
            
            string query = @"Update People
                                            set 
                                            NationalNumber='@nationnalNumber',
                                            FirstName='@firstname',
                                            SecondName='@secondname',
                                            ThirdName='@thirdname',
                                            LastName='@lastname',
                                            Gendor='@gendor',
                                            DateOfBirth=@dateOfBirth,
                                            Address='@address',
                                            Phone='@phone',
                                            Email='@email',
                                            CountryID=@countryID,
                                            PersonalPicturePath='@personImagePath'
                                            where PearsonID=@id;";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@nationnalNumber", nationnalNumber);
            command.Parameters.AddWithValue("@firstname", firstname);
            command.Parameters.AddWithValue("@secondname", secondname);
            command.Parameters.AddWithValue("@thirdname", thirdname);
            command.Parameters.AddWithValue("@lastname", lastname);
            command.Parameters.AddWithValue("@dateOfBirth", dateOfBirth);
            command.Parameters.AddWithValue("@gendor", gendor);
            if (address == "")
            {
                command.Parameters.AddWithValue("@address", System.DBNull.Value);
            }
            else { command.Parameters.AddWithValue("@address", address); }
            if (phone == "")
            {
                command.Parameters.AddWithValue("@phone", System.DBNull.Value);
            }
            else { command.Parameters.AddWithValue("@phone", phone); }
            if (email == "")
            {
                command.Parameters.AddWithValue("@email", System.DBNull.Value);
            }
            else { command.Parameters.AddWithValue("@email", email); }

            command.Parameters.AddWithValue("@countryID", countryID);
            if (personImagePath == "")
            {
                command.Parameters.AddWithValue("@personImagePath", System.DBNull.Value);
            }
            else { command.Parameters.AddWithValue("@personImagePath", personImagePath); }



            try
            {
                connection.Open();
                int numberofrowsaffected = command.ExecuteNonQuery();
                if(numberofrowsaffected !=0)
                {
                    ChangeWasMade = true;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally { 

                connection.Close(); }
            return ChangeWasMade;
        }
        static public bool DeletePerson(int id)
        {
            bool ChangeWasMade = false;
            string query = @"delete from People where PearsonID=@id";
            SqlConnection connection=new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command=new SqlCommand(query, connection);
            command.Parameters.AddWithValue ("@id", id);
            try
            {
                connection.Open();
                int rowsaffected= command.ExecuteNonQuery();
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
        static public DataTable GetPeopleInfo()
        {
            DataTable dt = new DataTable();
            string query = @"SELECT [PearsonID]
                                   ,[FirstName]
                                  ,[SecondName]
                                  ,[ThirdName]
                                  ,[LastName]
                                  ,[NationalNumber]
                                  ,[DateOfBirth]
                                    ,[Gendor]
                                  ,[Address]
                                  ,[Phone]
                                  ,[Email]
                                  ,[CountryID]
                                  ,[PersonalPicturePath]
                                    
                                  
                              FROM [dbo].[People]

                                                GO";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command= new SqlCommand(query, connection);
            try
            {
                connection.Open ();
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
