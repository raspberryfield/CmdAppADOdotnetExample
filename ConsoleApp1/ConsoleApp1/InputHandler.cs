using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading;

namespace ConsoleApp1
{
    static class InputHandler
    {
       
        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("MAIN MENU:");
            Console.WriteLine("1. Enter connection string.");
            Console.WriteLine("2. Test connection.");
            UserOptionMainMenu();
        }

        private static void UserOptionMainMenu()
        {
            try
            {
                int userOption = Convert.ToInt32(Console.ReadLine());
                switch (userOption)
                {
                    case 1:
                        ConnectionMenu();
                        break;
                    case 2:
                        TestConnection();
                        break;
                    default:
                        MainMenu();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input...");
                Thread.Sleep(1000);
                MainMenu();
            }
        }

        private static void ConnectionMenu()
        {
            Console.Clear();
            Console.WriteLine("CONNECTION MENU:");
            try
            {
                Console.Write("Name of server: ");
                var server = Console.ReadLine();
                Console.Write("Name of Database: ");
                var database = Console.ReadLine();
                Console.Write("Username: ");
                var username = Console.ReadLine();
                Console.Write("Password: ");
                var password = Console.ReadLine();
                //string connectionString = "Data Source=DELL-PC;initial catalog=AdventureWorks2008R2 ; " +
                //  "User ID=sa;Password=sqlpass;Integrated Security=SSPI;"; --false

                var connectionString = $"Data Source={server};initial catalog={database};User ID={username};Password={password};Integrated Security=false;"; //SSPI-current account windows authnetication mode.
                Console.WriteLine(connectionString);
                SQLhandler._connectionString = connectionString;
                Console.ReadLine();
                MainMenu();
            }
            catch(Exception e)
            {
                Console.WriteLine("Invalid input...");
                Thread.Sleep(1000);
                ConnectionMenu();
            }
        }  

        private static void TestConnection()
        {
            Console.Clear();
            Console.WriteLine("Testing connection...");
            SQLhandler.HelloWorld();
            Console.ReadLine();
            MainMenu();
        }

    }
}
