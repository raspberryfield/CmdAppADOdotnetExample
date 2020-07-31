using System;
using System.Data;
using System.Data.SqlClient;

/*Simple example query SQL Server with ADO.NET.*/
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var connectionString = $"Data Source=localhost;initial catalog=Test;Integrated Security=SSPI;";
            var query = "SELECT(1+1)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("\t{0}", reader[0]);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        }
    }
}
