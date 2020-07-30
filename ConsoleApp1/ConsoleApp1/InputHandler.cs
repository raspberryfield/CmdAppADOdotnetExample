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

                    default:
                        Console.WriteLine("Test test test.");
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
            }
            catch (Exception e)
            {

            }
        }  

    }
}
