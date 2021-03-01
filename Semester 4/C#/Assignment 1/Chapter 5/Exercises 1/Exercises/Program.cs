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

            // Ask Numbers to be inputed
            Console.Write("Press any key to continue\n");
            Console.ReadKey();
            Console.WriteLine("Enter Number 1:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number 2:");
            int num2 = int.Parse(Console.ReadLine());

            // Check if Number 1 is Equal, Greater or Less then Number 2
            if(num1 == num2)
            {
                Console.WriteLine("The number {0} is equal to {1}.", num1, num2);
            }
            else if(num1 > num2)
            {

                Console.WriteLine("The number {0} is greater then {1}.", num1, num2);

            }
            else if (num1 < num2)
            {
                Console.WriteLine("The number {0} is less then {1}.", num1, num2);

            }

            Console.Write("Press any key to continue\n");
            Console.ReadKey();


        }
    }
}
