using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            // Enter a Number
            Console.WriteLine("Please enter a number:");
            int n = int.Parse(Console.ReadLine());


            // Write that Number from 0 to the Number. Only if Number is greater then 0.
            if(n >= 0) { 
                for(int i = 0; i <= n; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Number below 0, cannot continue.");

            }

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
    }
}
