#include <stdio.h>
#include <stdlib.h>
int *createDN() {

    int *number, inc=0;
    number = (int *)malloc(10*sizeof(int));

    for (int i =0; i<10; i++)
    {
        if (inc !=0)
        {
            inc = inc + i;
            *( number + i ) = inc + i;
        } else {      
            *( number + i ) = 1;
            inc++;
        }
    }

    return number;
} 

int main()
{
    
    printf("\e[1;1H\e[2J");
    int *number, position, value;

     number = createDN();

     
        printf ("What number would you like to insert:\n");
        scanf ("%d", &value);
        printf ("What Position would you like to insert value in:\n");
        scanf ("%d", &position);

        for (int x = 10; x>position; x--)
        {
            *(number+x) = *(number+x-1);
        }
    
         *(number + position) = value;


    printf("\e[1;1H\e[2J");
        printf("The Pointer Values are:\n");

        for (int i = 0; i < 10; i++)
        {
            printf("#%d: %d\n", i,  *( number + i ));
        }

    return 0;
}