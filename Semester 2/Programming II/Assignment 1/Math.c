#include <stdio.h>


float addMath(float number1, float number2) {
    float total;
    total = number1+number2;
    return total;
    
}


float subMath(float number1, float number2) {
    float total;
    total = number1-number2;
    return total;
    
}


float divMath(float number1, float number2) {
    float total;
    total = number1/number2;
    return total;
    
}


float multMath(float number1, float number2) {
    float total;
    total = number1*number2;
    return total;
}

int main () {



    float numb1, numb2, divi, mult, addi, subt;
    int ch;
  
    puts("Please enter First Number:");
    scanf("%f", &numb1);
    while ( ( ch = getchar() ) != '\n' && ch != EOF );

    puts("Please enter Second Number:");
    scanf("%f", &numb2);
    while ( ( ch = getchar() ) != '\n' && ch != EOF );

    addi = addMath(numb1, numb2);
    subt = subMath(numb1, numb2);
    divi = divMath(numb1, numb2);
    mult = multMath(numb1, numb2);

    printf("Adding Number is: %.2f \n", addi);
    printf("Subtracting Number is: %.2f \n", subt);
    printf("Dividing Number is: %.2f \n", divi);
    printf("Multiplying Number is: %.2f \n", mult);
}