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
            // Create a 20 Number array using ulong
            ulong[] TheArray = new ulong[20];


            // go though the array, if array is first set number to 1, else multiply previous entry by 5 and add it to array.
            for(int i = 0; i < 20; i++)
                
            {
                if(i == 0)
                {
                    TheArray[i] = 1;
                } else
                {
                    TheArray[i] = TheArray[i - 1] * 5;
                }
            }

            // Loop though array, to show each value.
            for ( int n = 0; n < 20; n++)
            {
                int i = n + 1;
                Console.WriteLine(i +": "+TheArray[n]);

            }


            Console.Write("Press any key to continue\n");
            Console.ReadKey();



        }
    }
}
