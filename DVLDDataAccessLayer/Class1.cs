using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace DVLDDataAccessLayer
{
    public  class clsPeopleDataAccess
    {
        //CRUD
        //Create(AddNewPearson)
        //Read(FindPearsonByID)(FindPearsonByName)
        //Update(UpdatePearsonInfo)
        //Delete(DeletePearson)
        //Read All People(GetPeopleData)
        static public bool GetPearsonByID(int id,ref string Name,ref string NationalNumber,ref DateTime DateOfBirth,ref string Address,ref string Phone,ref string Email,ref int CountryID ,ref string PearsonPicturePath)
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
                    Name = (string)reader["FullName"];
                    NationalNumber = (string)reader["NationalNumber"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Address = (string)reader["Address"];
                    Phone= (string)reader["Phone"];
                    Email= (string)reader["Email"];
                    CountryID= (int)reader["CountryID"];
                    PearsonPicturePath= (string)reader["PearsonPicturePath"];
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
        

    }
}
