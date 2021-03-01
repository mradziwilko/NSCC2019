#include <stdio.h>


void numSorter(int inpNum[])
{

   // Local Variables
   int temp, number2, number3;

   // NUmber check if number is higher, then another, if not go to next number if higher then put back in array.
   for (number2 = 0; number2 < 10; ++number2)
   {
      for (number3 = number2 + 1; number3 < 10; ++number3)
      {
         if (inpNum[number2] > inpNum[number3])
         {
            temp = inpNum[number2];
            inpNum[number2] = inpNum[number3];
            inpNum[number3] = temp;
         }
      }
   }

   // Print Results
   printf("Numbers in ascending order:\n");
   for (int i = 0; i < 10; ++i)
      printf("%d ", inpNum[i]);
}


void main()
{
   int  count = 10, number[10], tmpnum = 0;
 
   
   for (int i = 0; i < count; ++i) {
      // Just for String output 1,2,3,4,5 ETC
       tmpnum++;
      printf("Please Enter Number  %d : ",  tmpnum);
      scanf("%d", &number[i]);
      }
 
   numSorter(number);
}