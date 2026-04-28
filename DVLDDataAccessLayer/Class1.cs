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
        static public bool GetPearsonByID(int id,ref string Name)
        {
            bool isFound = false;
            string query = "select * from People where PearsonID=@id";
            SqlConnection connection=new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command=new SqlCommand(query, connection);
            connection.Open();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();
                Name = (string)reader["FullName"];
                isFound = true;

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
