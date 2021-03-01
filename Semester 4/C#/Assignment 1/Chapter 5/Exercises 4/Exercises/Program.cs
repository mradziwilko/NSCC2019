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
            // Set Int Array
            int[] a = { 10, 12, 5 };


            // Sort Array
            Array.Sort(a);


            // Write Each number from Smallest to Largest. Simple Loop.
            for (int i = 0; i < 3; i++)
            {
                Console.Write(a[i] + " ");
            }


            Console.Write("Press any key to continue\n");
            Console.ReadKey();
        }
    }
}
