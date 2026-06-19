using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DVLDDataAccessLayer
{
    public static  class clsApplicationTypesDataAccess
    {
        public static DataTable GetAllApplicationTypes()
        {
            DataTable dt = new DataTable();
            string query = "select * from ApplicationTypes;";
            SqlConnection connection = new SqlConnection( ClsDataAccessSetting.ConnectionString);
            SqlCommand command= new SqlCommand(query, connection);
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
        public static bool Update( int id, string title, float fees)
        {
            bool ChangeWasMade = false;

            string query = @"Update ApplicationTypes
                                            set 
                                            ApplicationTypeName=@title,
                                            Fees=@fees
                                            
                                            where ApplicationTypeID=@id;";
            SqlConnection connection = new SqlConnection(ClsDataAccessSetting.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@title", title);
            command.Parameters.AddWithValue("@fees", fees);
            command.Parameters.AddWithValue("@id", id);
           


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
    }
}
