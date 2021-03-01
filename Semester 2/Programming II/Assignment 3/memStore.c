#include <stdio.h>
#include <stdlib.h>


int Display(int *arr, int limit) {
    

     
    printf("Numbers Stored are:");
    for(int i=0; i<limit; i++)
        printf("%3d ",*(arr+i));

return 0;
}
int main () {
    
    int *arr;

    int limit;

    limit = 10;
    
    if(arr==NULL)
    {
        printf("Insufficient Memory, Exiting... \n");
        return 0;
    }
     

     
    printf("Enter %d Numbers:\n",limit);

    for(int i=0; i<limit; i++)
    {
        printf("Enter Number %d: ",i+1);
        scanf("%d",(arr+i));
    }
     
    Display(arr, limit);

    return 0;
}