using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
     
        // Function to get max value
        static int GetMax(int num1, int num2, int num3)
        {


            // If Number 1 is greater then 2, then check if Number 1 is greater then 3 if not return 3 else return 1.
            if (num1 > num2)
            {
                if(num1 > num3)
                {
                    return num1;
                }
                else
                {
                    return num3;
                }
            }
            else
            {

                // If Number 2 is greater then 3 return number 2, else return number 3.
                if (num2 > num3)
                {
                    return num2;
                }
                else
                {
                    return num3;
                }
            }

        }
        static void Main(string[] args)
        {
            // Enter 3 Numbers, Clear console after each input.
            Console.WriteLine("Please enter number 1:");
            int number1 = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Please enter number 2:");
            int number2 = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Please enter number 3:");
            int number3 = int.Parse(Console.ReadLine());
            Console.Clear();

            // Print Highest Number
            Console.WriteLine("The Highest Value is: " + GetMax(number1, number2, number3));

            Console.Write("Press any key to continue\n");
            Console.ReadKey();


        }
    }
}
