#include <stdio.h>
#include <stdlib.h>
#include <Windows.h>



int main(void)
{

    // Declare Storages of Variables
    char writestr[10];
    char filename[100];
    int inpexit = 0;

    char readValues[255];

    
    // Ask for File Name.
    puts("Please enter a  Filename:");
    fgets(filename, 150, stdin);


    // Remove any \n that may be in filename. to prevent problems creating file
    strtok(filename, "\n");

    // Open File if Exists
    FILE *fp = fopen(filename, "ab+");

    // If File is not present, Create a new File
    if(fp == NULL) 
        {
            fp = fopen(filename, "wb");
        }

    while (fgets(readValues, sizeof(readValues), fp) != NULL) 
    {
    fputs(readValues, stdout);
    }



}