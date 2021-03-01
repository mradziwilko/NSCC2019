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
            // Enter Number
            Console.WriteLine("Please enter your number:");
            double n = double.Parse(Console.ReadLine());


            // Check if number can be Divided by 5 and 7
            bool result = (n % 5 == 0) && (n % 7 == 0);
            Console.WriteLine("The number {0} can be divided by 5 and 7? {1}", n, result);

            Console.Write("Press any key to continue\n");
            Console.ReadKey();

        }
    }

}