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

            double a, b, h;

            // Enter trapezoid Side's
            Console.Write("Enter the first side of the trapezoid:");
            bool SideA = double.TryParse(Console.ReadLine(), out a);
            Console.Write("Enter the second side of the trapezoid:");
            bool SideC = double.TryParse(Console.ReadLine(), out b);
            Console.Write("Enter the height of the trapezoid:");
            bool SideC = double.TryParse(Console.ReadLine(), out c);


            // Error check, to see if Input is Valid Numbers
            if (SideA && SideB && SideC)
            {
                // Math for Trapezoid
                double area = (a + b) * 0.5 * c;

                // Output.
                Console.WriteLine("The Area of the Rectange is: {0}", area);
            }
            else
            {
                // Error if Not valid number
                Console.WriteLine("Did not enter a Valid Number!");
            }


            Console.Write("Press any key to continue\n");
            Console.ReadKey();

        }
    }
}
