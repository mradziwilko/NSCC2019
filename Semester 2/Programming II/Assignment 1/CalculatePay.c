#include <stdio.h>


int main () {
    // Assign variables.
    float pay, subtotal, total, pretotal;
    int hours;
    int ch;
  

  
    // Ask Hours of Work, store in variable "hours"
    puts("Please enter hours worked:");
    scanf("%d", &hours);
    while ( ( ch = getchar() ) != '\n' && ch != EOF );

    // Ask hourly pay, store in variable "pay".
    puts("Please enter a hourly Pay:");
    scanf("%f", &pay);
    while ( ( ch = getchar() ) != '\n' && ch != EOF );

    // Multiply Hours by Pay to get a Total Pay amount, store in variable "Subtotal"
    subtotal = hours*pay;
    printf("Hours $%d \n",  hours);
    printf("Pay $%.2f \n",  pay);
    printf("Subtotal $%.2f \n",  subtotal);



    // if Is 0-300 take 10% off, if 300.01-400 take 12% off, if 400.01-500 take 15% and if 500 above take 20%, 
    // display withholding and final payout.
    if( subtotal >= 0 && subtotal <= 300.00) {
        pretotal = subtotal*0.10;
        total = subtotal-pretotal;
        printf("Withholding: $%.2f \n", pretotal);
        printf("Final Payout: $%.2f", total);
    }else if( subtotal >= 300.01 && subtotal <= 400.00) {
        pretotal = subtotal*0.12;
        total = subtotal-pretotal;
        printf("Withholding: $%.2f \n", pretotal);
        printf("Final Payout: $%.2f", total);        
    }else if( subtotal >= 400.01 && subtotal <= 500.00) {
        pretotal = subtotal*0.15;
        total = subtotal-pretotal;
        printf("Withholding: $%.2f \n", pretotal);
        printf("Final Payout: $%.2f", total);        
    }else if( subtotal >= 500.01) {
        pretotal = subtotal*0.20;
        total = subtotal-pretotal;
        printf("Withholding: $%.2f \n", pretotal);
        printf("Final Payout: $%.2f", total);
    }
} 