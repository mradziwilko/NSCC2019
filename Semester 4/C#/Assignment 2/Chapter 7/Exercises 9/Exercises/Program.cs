using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {

        // 
        static int maxSubArraySum(int[] a)
        {
            // Get Length of Array
            int size = a.Length;
            // get Min Array Value, and ending values
            int max_so_far = int.MinValue, max_ending_here = 0;
            // Loop to go though array
            for (int i = 0; i < size; i++)
            {
                max_ending_here = max_ending_here + a[i];

                if (max_so_far < max_ending_here)
                    max_so_far = max_ending_here;

                if (max_ending_here < 0)
                    max_ending_here = 0;
            }

            return max_so_far;
        }
        static void Main(string[] args)
        {

            // Create a static array (Based on book)
            int[] a = { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

            // Write out the Maximum Contiguous sum.
            Console.WriteLine("Maximum contiguous sum is " + maxSubArraySum(a));



            Console.WriteLine("Press any key to continue\n");
            Console.ReadKey();


        }
    }
}
