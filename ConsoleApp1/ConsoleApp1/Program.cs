using System;

/*This console application provides a little command line interface to test you database connaction.*/

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintGreeting();


            InputHandler.MainMenu();
            
            

            Console.ReadLine();
        }

        private static void PrintGreeting()
        {
            Console.WriteLine("ADO.NET test program v.0.1. -FF. ");
            Console.WriteLine("Hi, this is an command line line application to test functionality in ADO.NET.");
            Console.WriteLine("-------------------------------------------------------------------------");
            Console.WriteLine("Press [Enter] to continue...");
            Console.ReadLine();
        }
    }
}
