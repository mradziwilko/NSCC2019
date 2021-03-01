using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {

            // Call Selection sort into a new selection, max of # is 20, can be set to another number higher or lower 
            Selection_Sort selection = new Selection_Sort(20);
            selection.Sort();



            Console.Write("Press any key to continue\n");
            Console.ReadKey();
        }
    }


    // Create Selection Sort
    class Selection_Sort
    {

        // variables generate random numbers for data
        private int[] data;
        private static Random generator = new Random();

        // Add data to a array
        public Selection_Sort(int size)
        {
            data = new int[size];
            for (int i = 0; i < size; i++)
            {
                data[i] = generator.Next(5, 25);
            }
        }


        // Sort Array
        public void Sort()
        {
            Console.Write("\nSorted Array Elements :\n");
            display_array_elements();
            int smallest;
            for (int i = 0; i < data.Length - 1; i++)
            {
                smallest = i;

                for (int index = i + 1; index < data.Length; index++)
                {
                    if (data[index] < data[smallest])
                    {
                        smallest = index;
                    }
                }
                Swap(i, smallest);
                display_array_elements();
            }

        }


        // Swap first and second values in array
        public void Swap(int first, int second)
        {
            int temporary = data[first];
            data[first] = data[second];
            data[second] = temporary;
        }


        // Display function to display the elements of the array.
        public void display_array_elements()
        {
            foreach (var element in data)
            {
                Console.Write(element + " ");
            }
            Console.Write("\n");
        }
    }
}