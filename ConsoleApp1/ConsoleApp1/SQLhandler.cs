using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp1
{

    static class SQLhandler
    {

        public static string _connectionString { get; set; }

        public static void HelloWorld()
        {
            Console.WriteLine("Connection: " + _connectionString);
            var query = "SELECT(1+1)";
            //TODO: use ExecuteScalar to optain single value result.
            using (SqlConnection connection = new SqlConnection(_connectionString))
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
