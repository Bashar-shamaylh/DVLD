using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer
{
    public static class clsCountriesDataAccess
    {
        static public DataTable GetCountriesInfo()
        {
            DataTable dt = new DataTable();
            string query = @"select * from Countries;";
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
        static public bool GetCountryById(int CountryID,ref string  CountryName)
        {
            bool isFound = false;
            string query = "select * from Countries where CountryID=@CountryID";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    CountryName = (string)reader["CountryName"];
                    
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
        static public bool GetCountryByName(ref int CountryID,  string CountryName)
        {
            bool isFound = false;
            string query = "select * from Countries where CountryName=@CountryName";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    CountryName = (string)reader["CountryName"];

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
