#include <stdio.h>
#include <stdlib.h>
#include <string.h>


int *newInt() {
    int *newInt;
         newInt =  (int *)malloc(sizeof(int));
         return newInt;
}


double *newDouble() {
    double *newDouble;
            newDouble =  (double *)malloc(sizeof(double));
            return newDouble;
}


float *newFloat() {
    float *newFloat;
           newFloat =  (float *)malloc(sizeof(float));
           return newFloat;
}

char *newCharArray(int size) {
    char *newCharArray;
          
          newCharArray = (char *)malloc(sizeof(char) * (size+1));
          return newCharArray;
}


int main () {


    int *new_i = newInt();
    double *new_d = newDouble();
    float *new_f = newFloat();
    char *new_c = newCharArray(100);


    char temp;
    printf("Please enter a Integer Value:");
    scanf("%i", new_i);
    
    printf("Please enter a Double Value:");
    scanf("%lf", new_d);

    printf("Please enter a Float Value:");
    scanf("%f", new_f);


    printf("Please enter a String Value:");
    scanf("%s", new_c);


    printf("Numbers Entered:\n");
    
    printf("Integer: %i\n", *new_i);
    printf("Double: %lf\n", *new_d);
    printf("Float: %f\n", *new_f);
    printf("Character: %s\n", new_c);




    return 0;
}