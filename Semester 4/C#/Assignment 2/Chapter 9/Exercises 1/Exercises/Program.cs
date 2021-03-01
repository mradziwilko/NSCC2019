using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        // Print name in console Function
        static void PrintName(String name)
        {
            Console.WriteLine("Hello, " + name + "!");
        }

        
        static void Main(string[] args)
        {

            // Enter Name
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            // Clear Console
            Console.Clear();

            // Print Name
            PrintName(name);


            Console.Write("Press any key to continue\n");
            Console.ReadKey();



        }
    }
}
