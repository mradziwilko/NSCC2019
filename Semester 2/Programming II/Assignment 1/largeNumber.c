#include <stdio.h>

float maxval(float numb1,float numb2,float numb3) {
    
    // if Number 1 is greater then or Equal to Number 2, and Number 1 is greater then or equal too Number 3 Return number 1
    // If Number 2 is greater then or euqal to Number 1, or Number 2 is greater then or equal to Number 3 return number 2
    // else return number 3.

   if(numb1>=numb2 && numb1>=numb3) {
       return numb1;
   }else if(numb2>=numb1 && numb2>=numb3) {
       return numb2;
   }else{
       return numb3;
   } 

}

int main () {

    // Assign Variables
    float numb1, numb2, numb3;
    int ch;
  
    // Ask first number store in numb1
    puts("Please enter First Number:");
    scanf("%f", &numb1);
    while ( ( ch = getchar() ) != '\n' && ch != EOF );

    // Ask second number store in numb2
    puts("Please enter Second Number:");
    scanf("%f", &numb2);
    while ( ( ch = getchar() ) != '\n' && ch != EOF );

    // Ask third number store in numb3
    puts("Please enter Third Number:");
    scanf("%f", &numb3);
    while ( ( ch = getchar() ) != '\n' && ch != EOF );

    // Get largest number, and print out result.
    printf("The highest value of the numbers is: %.2f", maxval(numb1, numb2, numb3));



}