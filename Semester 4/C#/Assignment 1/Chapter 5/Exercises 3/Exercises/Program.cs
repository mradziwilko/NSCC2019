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
            // Set the numbers
            int num1 = 5, num2 = 55, num3 = 20;


            // Check if Number 1 is Larger then 2.
            if (num1 > num2)
            {
                // Check if Number 3 is Larger then Number 1 else Number 1 Larger
                if (num1 > num3)
                {
                    Console.Write("Number " + num1 + " is the largest!\n");
                }
                else
                {
                    Console.Write("Number " + num3 + " is the largest!\n");
                }

                // Check if Number 2 is Larger then Number 3 else number 3 is larger
            }
            else if (num2 > num3)
            {
                Console.Write("Number " + num2 + " is the largest!\n");
            }
            else
            {
                Console.Write("Number " + num3 + " is the largest!\n");
            }


            Console.Write("Press any key to continue\n");
            Console.ReadKey();
        }
    }
}
