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
            int num = 53;

            // Check if even or odd.
            if (num % 2 == 0)
            {
                Console.WriteLine("Number is even");
}
            else
            {
                Console.WriteLine("Number is odd");
            }
            Console.Write("Press any key to continue\n");
            Console.ReadKey();
        }
    }
}
