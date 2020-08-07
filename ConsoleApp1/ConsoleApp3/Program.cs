using System;
using System.Data;
using System.Data.SqlClient;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press Enter to send test data to DB...");
            Console.ReadLine();
            var connectionString = $"Data Source=localhost;initial catalog=Slask;Integrated Security=True;";
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                                
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(null, connection);

                    // Create and prepare an SQL statement.
                    command.CommandText = 
                        "INSERT INTO People (Name, Age) " +
                        "VALUES (@name, @age)";


                    //SqlParameter nameParam = new SqlParameter("@name", SqlDbType.Text, 255);
                    SqlParameter ageParam = new SqlParameter("@age", SqlDbType.Int);
                     
                    //nameParam.Value = "Fred";
                    ageParam.Value = 35;
                    //command.Parameters.Add(nameParam);
                    command.Parameters.Add(ageParam);

                    //One liner:
                    command.Parameters.Add("@name", SqlDbType.NVarChar, 255).Value = "Frederick";
                    

                    // Call Prepare after setting the Commandtext and Parameters.
                    command.Prepare();
                    command.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
