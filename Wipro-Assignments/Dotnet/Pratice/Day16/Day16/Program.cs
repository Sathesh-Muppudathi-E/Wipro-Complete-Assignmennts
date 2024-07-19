


using System;
using System.Data;
using System.Data.SqlClient;


       

class Program
{
    static void main()
    {
        
        string connectionString = "Data Source=DESKTOP-TIC5DM4\\SQLEXPRESS;database=TABLE_NAME;integrated security=SSPI";

        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            try
            {
                connection.Open();
               


                string query = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("Tables in the database:");

                        while (reader.Read())
                        {
                            Console.WriteLine(reader["TABLE_NAME"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                    
                }
            }
        }
    }
}




