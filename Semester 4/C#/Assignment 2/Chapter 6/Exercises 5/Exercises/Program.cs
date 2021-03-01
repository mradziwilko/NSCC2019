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
            // State Default Numbers
            int n1 = 0, n2 = 1, n3, i, number;

            // Enter Element Max Numbers
            Console.Write("Enter the number of elements: ");
            number = int.Parse(Console.ReadLine());

            // Write first two numbers
            Console.Write(n1 + " " + n2 + " "); 
            
            // Loop though elements to sequence if i is less then given max number elements
            for (i = 2; i < number; ++i) 
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }

            Console.Write("\nPress any key to continue\n");
            Console.ReadKey();
        }
    }
}
