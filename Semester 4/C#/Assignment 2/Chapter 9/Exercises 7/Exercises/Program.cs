using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
		static int RevOrder(int number)
		{
			// Set Base Values
			int rev = 0, b;

			// do while number is not 0, reverse the number, and return it;
			while (number != 0)
			{
				b = number % 10;
				rev = (rev * 10) + b;
				number = number / 10;
			}
			return rev;

		}
        static void Main(string[] args)
        {
			// Enter a Number to reverse
			Console.WriteLine("Please enter a number:");
			int a = int.Parse(Console.ReadLine());

			// Reverse the order
			int rev = RevOrder(a);
			// Clear Console.
			Console.Clear();

			// Output Reversed Number
			Console.WriteLine("The reverse of the number "+ a +" is: " + rev);
			Console.WriteLine("Press any key to continue\n");

			Console.ReadKey();

		}
    }
}
