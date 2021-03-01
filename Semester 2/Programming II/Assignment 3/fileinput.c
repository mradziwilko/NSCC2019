#include <stdio.h>
#include <stdlib.h>
#include <Windows.h>



int main(void)
{

    // Declare Storages of Variables
    char writestr[10];
    char filename[100];
    int inpexit = 0;

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

    // Do Loop, ask for Variable, then append it to File, if -1 is entered Exit application.
   do{
        
  
    puts("Enter a Value to append to file (Type -1 to Exit):");
    fgets(writestr, 150, stdin);

    strtok(writestr, "\n");

    //inpexit = strcmp(writestr, "-1\n");
    inpexit = strcmp(writestr, "-1");

    if(inpexit == 0) {
        puts("Exiting");
        exit(1);
    }else{ 
        if(fp)
                {
                fputs(writestr,fp);
                fputs("\n",fp);
                
            }else{
                puts("Cannot open the file. Exiting");
                exit(1);
            }
        }
    }while(inpexit != 0);




}