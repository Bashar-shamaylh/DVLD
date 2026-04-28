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
        static public bool GetPearsonByID(int id,string Name)
        {
            string query = "select * from People where PearsonID=@id";
            SqlConnection connection=new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command=new SqlCommand(query, connection);
            connection.Open();
            try
            {

            }
            catch (Exception ex)
            {

                throw;
            }
            return true;
        }

    }
}
