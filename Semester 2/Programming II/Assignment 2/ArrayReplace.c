#include <stdio.h>


void ReplaceNum(int inpNum[], int pos, int num) {

    // Clear Console (Personal Prefrence)
    printf("\e[1;1H\e[2J");

    // Current Number, New Number and Position output
    printf("  Previous Number: %d\n", inpNum[pos]);
    printf("       New Number: %d\n", num);
    printf("         Position: #%d\n", pos+1);


    // Set and Print the New Array
    inpNum[pos] = num;
    printf("New Array Numbers: ");
    for (int i = 0; i < 10; ++i) {
      printf("%d  ", inpNum[i]);
    }

}
void main()
{


    int numbers[10] = {11,12,13,14,15,16,17,18,19,20}, pos, num, tmpPos, tmpNum;


    for (int si = 0; i < 10; ++i) {
      printf("Number #%d: %d \n", i, numbers[i]);
    }

    
    // Ask Questions and Get Input
    printf("Please Enter Position in array:  \n",  tmpPos);
    scanf("%d", &pos);
    printf("\e[1;1H\e[2J");

    printf("Position Entered: %d \n", pos);
    printf("Please Enter Replacment Number:  \n",  tmpNum);
    scanf("%d", &num);
    printf("Number Entered: %d \n", num);

    // Replace Array
    ReplaceNum(numbers, pos, num);
}