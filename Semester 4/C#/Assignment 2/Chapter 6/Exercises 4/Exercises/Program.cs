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

            // Hex Codes for Spades, Hearts, Diamonds, Clubs
            char club = '\u2663';
            char spade = '\u2660';
            char diamond = '\u2666';
            char heart = '\u2665';

            // Cards
            string card;

            // Header Teasers 
            Console.WriteLine("-------------------------");
            Console.WriteLine("|  {0}  |   {1} |   {2} |   {3} |", club, spade, diamond, heart);
            Console.WriteLine("-------------------------");


            // For each card from 1 to 13.
            for (int i = 1; i <= 13; i++)

            {
                card = i.ToString();

                // If card is 11, 12, 13 or 1 Create symble instead of number
                switch (i)
                {
                    case 11:
                        card = "J";
                        break;
                    case 12:
                        card = "Q";
                        break;
                    case 13:
                        card = "K";
                        break;
                    case 1:
                        card = "A";
                        break;


                }

                // For Spacing, if Number is 10, do less Spaces, else normal spaces
                // Print out Card Value and Card Shape.
                if(i == 10)
                {

                    Console.WriteLine("| {0}{1} | {0}{2} | {0}{3} | {0}{4} |", card, club, spade, diamond, heart);
                }
                else
                {
                    Console.WriteLine("|  {0}{1} |  {0}{2} |  {0}{3} |  {0}{4} |", card, club, spade, diamond, heart);

                }
            }

            // end
            Console.WriteLine("-------------------------");
            Console.Write("Press any key to continue\n");
            Console.ReadKey();
        }
    }
}
