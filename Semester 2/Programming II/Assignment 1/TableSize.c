#include <stdio.h>

int main () {

    // Assign Variables
    int cSize , ch ;
    int chosenType;
    float total, pine, oak, mahogany, largeTable;
    
    // Assign variables to each one that needs a constant variable.
    pine=100.00;
    oak=225.00;
    mahogany=310.00;
    largeTable=35.00;
    chosenType=0;

    // Display Menu if a invalid choice is made then display menu again until valid menu is visable.
    do{
        
    // Clear Screen
    printf("\e[1;1H\e[2J");
        puts("Please Choose a Option: ");
        puts("1. Pine ");
        puts("2. Oak");
        puts("3. Mahogany");
        scanf("%i", &chosenType);
        // used to clear the buffer and accept the next string 
        fflush(stdin); 
    } while ((chosenType < 1) || (chosenType > 3 ));

    // used to clear the buffer and accept the next string 
    fflush(stdin); 

    // check for what kind of type is chosen, if is valid, insert price in total and a varaible into title.
    switch (chosenType)
    {
        case 1:
            total = pine;
        break;
        case 2:
            total = oak;
        break;
        case 3:
            total = mahogany;
        break;
    }

    // Clear Screen
    printf("\e[1;1H\e[2J");

    // Print Price of Chosen Table.
    printf("Price $%.2f \n \n",  total);

    // Ask for Size of Table.
    do{
        puts("Please Choose a Table Size: ");
        puts("1. Small ");
        puts("2. Large");
        scanf("%d", &cSize);
        // used to clear the buffer and accept the next string 
        fflush(stdin); 
    } while ((cSize < 1) || (cSize > 2));

        // used to clear the buffer and accept the next string 
        fflush(stdin); 

    // 1 = Small Table, 2 = Large Table.
    switch (cSize)
    {
    case 1:
        // Nothing added in Small
        break;
    case 2:            
        total +=  largeTable;
        break;    
    }
    
    // Clear Screen
    printf("\e[1;1H\e[2J");

    // Print Price of Table, including Size.
    printf("Table price = $%.2f", total);
    return 0;
}