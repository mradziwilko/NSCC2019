/*
   _____ _          _____                        _____     _
; |_   _| |_ ___   |   __|___ ___ ___ ___ ___   |  |  |___| |___ ___ ___
    | | |   | -_|  |  |  | .'|  _| .'| . | -_|  |     | -_| | . | -_|  _|
    |_| |_|_|___|  |_____|__,|_| |__,|_  |___|  |__|__|___|_|  _|___|_|
                                   |___|                  |_|
-------------------------------------------------------------------------------------
Program: FinalProject.c
Date: 06/04/2020
Autor: Marshall Radziwilko
Program Details:

PROG2007 Project (C) Garage
This project is intended to incorporate many of the C programming features learned in this course for application in a practical “real-life” situation.
Your task is to construct a working program which uses a linked list of structures to manage 8 fields.

Information to keep track of for each driver: Name of Mechanic
Name of Garage
Car Info (Year, Make, Model, owner) Automotive Problem
Part required Cost of Part Labor (in hours)
Cost of repair (calculated)

-------------------------------------------------------------------------------------
                                        Commits
-------------------------------------------------------------------------------------
|       Date        |        Programmer        |                Changelog           | 
|   Apr-06-2020     |   Marshall Radziwilko    |           First Version  1.0       |
-------------------------------------------------------------------------------------
*/
// Includes
#include <locale.h>
#include <ctype.h>
#include <stdio.h>
#include <string.h>
#include <stdlib.h>
#include <Windows.h>
#include <unistd.h>

// Defines
#define size 5
#define NULL ((void*)0)
#define INPUT_BUFFER 64
#define LSIZ 128 
#define RSIZ 10 


    typedef char text;
    typedef double rNum;
    typedef int numb;

    numb c;
    FILE *inpf;

    int cID, cSet;
    int MainOption, EditOption, DelOption;
    int i = 0;

    struct cInfo
    {
        int clientID;
        char nameMechanic [100];
        char nameGarage [100];
        int carYear;
        char carMake [100];
        char carModel [100];
        char carOwner [100];
        char automotiveProblem [100];
        char partRequired [100];
        double partCost;
        double labor;
        double repairCost;
    };
    
    
    struct cInfoTmp
    {
        char carOwner [100];
    };
    
    struct cInfo s[size];
    struct cInfoTmp t[size];
    struct cInfoTmp temp[size];
    struct cInfo tmp;
    struct cInfo r;
    struct cInfo z;
    struct cInfo *p;
    struct cInfoTmp zero_struct = {NULL};
    

int main(){
  
    do{    

        // Clear Screen Show Header
        clearScreen();
        HeaderLogo();
        // If Data is set, Show main menu, else show Import/Add new Menu
        if(cSet != 0 || cSet != NULL) {        
            puts("#1: Create Client ");
            puts("#2: List all Clients");
            puts("#3: Edit Client");
            puts("#4: Remove Client");
            puts("#5: Save All Clients");
            puts("#6: Sort Clients Alphabetically");
            puts("#7: Search for Client");
            puts("#8: Annual Income");
            puts("Please enter a  Option #:");
            scanf("%d", &MainOption);
    
            if(MainOption == 1) {
                
                AddNewPerson();

            }else if(MainOption == 2) {
                BrowseClients();
            }else if(MainOption == 3) {
                ModifyClient();

            }else if(MainOption == 4) {

                DelectClient();

            }else if(MainOption == 5) {
                
                saveallpeople();

            }else if(MainOption == 6) {
                sortClients();
            }else if(MainOption == 7) {    
                SearchPerson();                
            }else if(MainOption == 8) {    
                tallyTotals();
            }else {
                puts("Invalid Option Selected. Exiting.");

            }
            
        } else {

            puts("\n#1: Add New Client ");
            puts("#2: Import Clients");
            scanf("%d", &MainOption);

            if(MainOption == 1) {        
                AddNewPerson();
            }else if(MainOption == 2) {
                FillStructs();      
            }else {
                puts("Invalid Option Selected. Exiting.");
            }
        }
    }while(MainOption != 0);
    return 0;
}

void AddNewPerson() {
    // Clear Screen Show Header
    clearScreen();
    HeaderLogo();
    
    // Temp Variables
    int strucPos;
    char tmpMN [50], tmpGN [50], tmpCO [50], tmpCM [50], tmpCMO [50], tmpAP [50], tmpPR [50];   


    // Check which struct is Empty, if empty it will select the struct to use. If all struct are used, then set message to delete entry.
    if (s[0].clientID  == 0 ||  s[0].clientID == NULL){ 
        strucPos = 0;
    }else if (s[1].clientID  == 0 ||  s[1].clientID == NULL){
        strucPos = 1;                
    }else if (s[2].clientID  == 0 ||  s[2].clientID == NULL){
        strucPos = 2;            
    }else if (s[3].clientID  == 0 ||  s[3].clientID == NULL){                
        strucPos = 3;
    }else if (s[4].clientID  == 0 ||  s[4].clientID == NULL){               
        strucPos = 4;
    }else{
        puts("Client Database Full. Please remove a Client.");
    }
    

    // Enter Information, set to proper struct.
    puts("Enter Customer ID: ");
    scanf(" %d", &s[strucPos].clientID);
    fflush (stdin);

    puts("Enter Mechanic Name: ");
    fgets(tmpMN,100, stdin);
    strtok(tmpMN, "\n");
    sprintf(s[strucPos].nameMechanic, "%s", tmpMN);    
    fflush (stdin);

    puts("Enter Garage Name: ");
    fgets(tmpGN,100, stdin);
    strtok(tmpGN, "\n");
    sprintf(s[strucPos].nameGarage, "%s", tmpGN);
    fflush (stdin);

    puts("Enter Car Year: ");
    scanf("%d", &s[strucPos].carYear);
    fflush (stdin);
        
    puts("Enter Car Make: ");
    fgets(tmpCM,100, stdin);
    strtok(tmpCM, "\n");
    sprintf(s[strucPos].carMake, "%s", tmpCM);
    
    fflush (stdin);
    puts("Enter Car Model: ");
    fgets(tmpCMO,100, stdin);
    strtok(tmpCMO, "\n");
    sprintf(s[strucPos].carModel, "%s", tmpCMO);
    fflush (stdin);
    
        
    puts("Enter Car Owner: ");
    fgets(tmpCO,100, stdin);
    strtok(tmpCO, "\n");
    sprintf(s[strucPos].carOwner, "%s", tmpCO);
    fflush (stdin);
    
    puts("Enter Car Problem: ");
    fgets(tmpAP,100, stdin);
    strtok(tmpAP, "\n");
    sprintf(s[strucPos].automotiveProblem, "%s", tmpAP);
    fflush (stdin);
    
        
    puts("Enter Part Required: ");
    fgets(tmpPR,100, stdin);
    strtok(tmpPR, "\n");
    sprintf(s[strucPos].partRequired, "%s", tmpPR);
    fflush (stdin);
    
        
    puts("Enter Part Cost: ");
    scanf("%lf", &s[strucPos].partCost);
    fflush (stdin);
        
    puts("Enter Labour Cost: ");
    scanf("%lf", &s[strucPos].labor);
    fflush (stdin);
        
        double total =  s[strucPos].partCost + s[strucPos].labor;
        s[strucPos].repairCost = total;

    // Add user to file system.
    addNewUser(strucPos);
}


void BrowseClients() {
    // Clear Screen Show Header    
    clearScreen();
    HeaderLogo();

    // Goes though all structs that have data inside, and displays entries.
    for (i=0; i<5; i++){

        if(s[i].clientID == NULL || s[i].clientID == 0) {
  
        }else {

        printf("Client ID: %d \n", s[i].clientID);   
        printf("Mechanic Name: %s \n", s[i].nameMechanic);
        printf("Garage Name: %s \n", s[i].nameGarage);
        printf("Car Year: %d \n", s[i].carYear);
        printf("Car Make: %s \n", s[i].carMake);
        printf("Car Model: %s \n", s[i].carModel);
        printf("Car Owner: %s \n", s[i].carOwner);
        printf("Car Problem: %s \n", s[i].automotiveProblem);
        printf("Part Required: %s \n", s[i].partRequired);
        printf("Part Cost: $%.2lf \n", s[i].partCost);
        printf("Labor Cost: $%.2lf \n", s[i].labor);
        printf("Repair Cost: $%.2lf \n", s[i].repairCost);
        puts("============================= \n");
    }
    }
        // Just if no Items have Data, show empty database message.
        if(s[0].clientID == NULL || s[0].clientID == 0) {
            printf("%d Client's in System. \n", 0); 
        }
        

        // Stops console from going back directly to main menu.
		puts("Press Any Key to go to Menu.");
        getch(); 
}

void tallyTotals() {
    // Clear Screen Show Header
    clearScreen();
    HeaderLogo();

    // Temp Variables
    double total = 0;
    

    // calculate repair cost for all data in structs.
    for (i=0; i<5; i++){        
        total += s[i].repairCost;
    }
    

 
    // Display message.
    printf("Total of all current clients is $%.2lf\n", total);


	// Input back to menu
    puts("Press Any Key to go to Menu.");
    getch(); 

}

void ModifyClient() {
    
    // Clear Screen Show Header
    clearScreen();
    HeaderLogo();

    // Temp Variables
    int strucPos;
    char tmpMN [50], tmpGN [50], tmpCO [50], tmpCM [50], tmpCMO [50], tmpAP [50], tmpPR [50];


    // Show Client Menu
    ShowCMenu();
    scanf("%d", &EditOption);

    // Get Option on which person to modify
    if(EditOption == 1) {        
        strucPos = 0;
    }else if(EditOption == 2) {
        strucPos = 1;

    }else if(EditOption == 3) {
        strucPos = 2;        
    }else if(EditOption == 4) {       
        strucPos = 3;
    }else if(EditOption == 5) {
        strucPos = 4;    
    }
  
    // asks for questions to editdata
    printf("Enter Customer ID: (Current: %d) ", s[strucPos].clientID);
    scanf(" %d", &s[strucPos].clientID);
    fflush (stdin);

    printf("Enter Mechanic Name: (Current: %s) ", s[strucPos].nameMechanic);
    fgets(tmpMN,100, stdin);
    strtok(tmpMN, "\n");
    sprintf(s[strucPos].nameMechanic, "%s", tmpMN);    
    fflush (stdin);

    printf("Enter Garage Name: (Current: %s) ", s[strucPos].nameGarage);
    fgets(tmpGN,100, stdin);
    strtok(tmpGN, "\n");
    sprintf(s[strucPos].nameGarage, "%s", tmpGN);
    fflush (stdin);

    printf("Enter Car Year: (Current: %d) ", s[strucPos].carYear);
    scanf("%d", &s[strucPos].carYear);
    fflush (stdin);
        
    printf("Enter Car Make: (Current: %s) ", s[strucPos].carMake);
    fgets(tmpCM,100, stdin);
    strtok(tmpCM, "\n");
    sprintf(s[strucPos].carMake, "%s", tmpCM);
    
    fflush (stdin);
    printf("Enter Car Model: (Current: %s) ", s[strucPos].carModel);;
    fgets(tmpCMO,100, stdin);
    strtok(tmpCMO, "\n");
    sprintf(s[strucPos].carModel, "%s", tmpCMO);
    fflush (stdin);    
        
    printf("Enter Car Owner: (Current: %s) ", s[strucPos].carOwner);
    fgets(tmpCO,100, stdin);
    strtok(tmpCO, "\n");
    sprintf(s[strucPos].carOwner, "%s", tmpCO);
    fflush (stdin);
    
    printf("Enter Car Problem: (Current: %s) ", s[strucPos].automotiveProblem);
    fgets(tmpAP,100, stdin);
    strtok(tmpAP, "\n");
    sprintf(s[strucPos].automotiveProblem, "%s", tmpAP);
    fflush (stdin);    
        
    printf("Enter Part Required: (Current: %s) ", s[strucPos].partRequired);
    fgets(tmpPR,100, stdin);
    strtok(tmpPR, "\n");
    sprintf(s[strucPos].partRequired, "%s", tmpPR);
    fflush (stdin);    
        
    printf("Enter Part Cost: (Current: %.2lf) ", s[strucPos].partCost);
    scanf("%lf", &s[strucPos].partCost);
    fflush (stdin);
        
    printf("Enter Labour Cost: (Current: %.2lf) ", s[strucPos].labor);
    scanf("%lf", &s[strucPos].labor);
    fflush (stdin);
        
    // calc total.
    double total =  s[strucPos].partCost + s[strucPos].labor;
    s[strucPos].repairCost = total;
    
    // Replace user in struct.
    addNewUser(strucPos);
}

void DelectClient() {

    // Clear Screen Show Header
    clearScreen();
    HeaderLogo();
    // Show Client menu
    ShowCMenu();
    scanf("%d", &DelOption);

    // Run Remove function for specific client
    if(DelOption == 1) {
        cremove(0);
    }else if(DelOption == 2) {
        cremove(1);        
    }else if(DelOption == 3) {
        cremove(2);        
    }else if(DelOption == 4) {
        cremove(3);
    }else if(DelOption == 5) {
        cremove(4);        
    }else if(DelOption == 0) {
        // Go back.
		puts("Press Any Key to go to Menu.");
        getch(); 
    }else {
        // Go back
		puts("Press Any Key to go to Menu.");
        getch(); 

    }

}

void cremove(int cID) {

   int ret;
   char fName [100];
    if(cID != NULL) {
        
            // Opens Client File, Closes, and Saves Clean document and sets Client ID to 0;
            s[cID].clientID = 0;
            if(cID == 0) {
                fclose(fopen("data/client1.txt", "w"));               
            }else if(cID == 1) {
                fclose(fopen("data/client2.txt", "w"));
            }else if(cID == 2) {
                fclose(fopen("data/client3.txt", "w"));
            }else if(cID == 3) {
                fclose(fopen("data/client4.txt", "w"));
            }else if(cID == 4) {
                fclose(fopen("data/client5.txt", "w"));
            }            
  }



}
void ShowCMenu() {

    // Gets Clients in Struct, if empty desn't add user to List.

    puts("#0: Go Back");

    if(s[0].clientID != 0 || s[0].clientID != NULL) {
    printf("#1: Client #%d\n", s[0].clientID);
    }
    if(s[1].clientID != 0 || s[1].clientID != NULL) {
    printf("#2: Client #%d\n", s[1].clientID);
    }
    if(s[2].clientID != 0 || s[2].clientID != NULL) {
    printf("#3: Client #%d\n", s[2].clientID);
    }
    if(s[3].clientID != 0 || s[3].clientID != NULL) {
    printf("#4: Client #%d\n", s[3].clientID);
    }
    if(s[4].clientID != 0 || s[4].clientID != NULL) {
    printf("#5: Client #%d\n", s[4].clientID);
    }
    
    
}

void addNewUser(int StructPoS) {
    // Opens file depends on position. saves data to File from proper struct.
  if(StructPoS == 0) {

   if (( inpf=fopen("data/client1.txt","w+")) == NULL){
        puts("File Doesn't Exist!");       
        puts("Press Any Key to go back to Menu.");
        getch();
    } 
  }else if(StructPoS == 1) {
     
   if (( inpf=fopen("data/client2.txt","w+")) == NULL){
        puts("File Doesn't Exist!");       
        puts("Press Any Key to go back to Menu.");
        getch();
    } 
  }else if(StructPoS == 2) {
     
   if (( inpf=fopen("data/client3.txt","w+")) == NULL){
        puts("File Doesn't Exist!");       
        puts("Press Any Key to go back to Menu.");
        getch();
    } 
  }else if(StructPoS == 3) {
     
   if (( inpf=fopen("data/client4.txt","w+")) == NULL){
        puts("File Doesn't Exist!");       
        puts("Press Any Key to go back to Menu.");
        getch();
    } 
  }else if(StructPoS == 4) {
   if (( inpf=fopen("data/client5.txt","w+")) == NULL){
        puts("File Doesn't Exist!");       
        puts("Press Any Key to go back to Menu.");
        getch();
    }
  }
  
        fprintf(inpf," %d\n", s[StructPoS].clientID);
        fprintf(inpf,"%s\n", s[StructPoS].nameMechanic);
        fprintf(inpf,"%s\n", s[StructPoS].nameGarage);
        fprintf(inpf,"%d\n", s[StructPoS].carYear);
        fprintf(inpf,"%s\n", s[StructPoS].carMake);
        fprintf(inpf,"%s\n", s[StructPoS].carModel);
        fprintf(inpf,"%s\n", s[StructPoS].carOwner);
        fprintf(inpf,"%s\n", s[StructPoS].automotiveProblem);
        fprintf(inpf,"%s\n", s[StructPoS].partRequired);
        fprintf(inpf,"%.2lf\n", s[StructPoS].partCost);
        fprintf(inpf,"%.2lf\n", s[StructPoS].labor);
        fprintf(inpf,"%.2lf", s[StructPoS].repairCost);
        
        
        fclose(inpf);
		puts("\n Press Any Key to go to Menu.");
        getch();  
}

void SearchPerson() {
    // Clear Screen Show Header
    clearScreen();
    HeaderLogo();

    // Variables
    char result [100]; 
    char sresult [100]; 
    int sr2, sr3, sr4, sr5, sr6, position;
    

    // Asks for search 
    puts("Please enter a  Client Name:");
    scanf("%s", result);
    

    // String compairs to each Struct to carOwner  0 = Not found 1 = Found
    sr2 = string_contains(s[0].carOwner,result);
    sr3 = string_contains(s[1].carOwner,result);
    sr4 = string_contains(s[2].carOwner,result);
    sr5 = string_contains(s[3].carOwner,result);
    sr6 = string_contains(s[4].carOwner,result);
    // sets current position in struct
        if(sr2 == 1) {
            position = 0;
        }else if(sr3 == -1) {
            position = 1;
        }else if(sr4 == 1) {
            position = 2;
        }else if(sr5 == 1) {
            position = 3;
        }else if(sr6 == 1) {
            position = 4;
        }else
        {
            position = -1;
        }
        
    // Clear Screen Show Header
    clearScreen();
    HeaderLogo();

    // Displays current search result. if -1 = Show none.
        if(position != -1) {
            printf("Client ID: %d \n", s[position].clientID);   
            printf("Mechanic Name: %s \n", s[position].nameMechanic);
            printf("Garage Name: %s \n", s[position].nameGarage);
            printf("Car Year: %d \n", s[position].carYear);
            printf("Car Make: %s \n", s[position].carMake);
            printf("Car Model: %s \n", s[position].carModel);
            printf("Car Owner: %s \n", s[position].carOwner);
            printf("Car Problem: %s \n", s[position].automotiveProblem);
            printf("Part Required: %s \n", s[position].partRequired);
            printf("Part Cost: $%.2lf \n", s[position].partCost);
            printf("Labor Cost: $%.2lf \n", s[position].labor);
            printf("Repair Cost: $%.2lf \n", s[position].repairCost);
        }else{
            puts("Nothing in Database");
        }


        // back to home on key press
		puts("Press Any Key to go to Menu.");
        getch(); 
}

void tmpVarOpen(char CleintFile [100]) {
    // variables
    char line[RSIZ][LSIZ];
    int i = 0;
    int tot = 0;

    // Make sure no n's in client file.
    strtok(CleintFile, "\n");

    // open file
    inpf = fopen(CleintFile, "r");


    // get Each line from File
    while(fgets(line[i], LSIZ, inpf)) 
	{
        line[i][strlen(line[i]) - 1] = '\0';
        i++;
    }
     

     // Insert Data into Temp Struct.
        r.clientID = atoi(line[0]);
        strcpy(r.nameMechanic, line[1]); 
        strcpy(r.nameGarage, line[2]); 
        r.carYear = atoi(line[3]);
        strcpy(r.carMake, line[4]);
        strcpy(r.carModel, line[5]);
        strcpy(r.carOwner, line[6]);
        strcpy(r.automotiveProblem, line[7]);
        strcpy(r.partRequired, line[8]);
        r.partCost = strtod(line[9], &tmp);
        r.labor = strtod(line[10], &tmp);
        r.repairCost = strtod(line[11], &tmp);

}


void tempOpen(char CleintFile [100]) {
    

    // Variables
    char line[RSIZ][LSIZ];
    int i = 0;
    int tot = 0;

    // Check if no n's in file name.
    strtok(CleintFile, "\n");

    // Open File
    inpf = fopen(CleintFile, "r");

    // If nothing in file, set client id to 0;
    int c = fgetc(inpf);
    if (c == EOF) {
            r.clientID = 0;
    } else {
    
        // read Lines
        while(fgets(line[i], LSIZ, inpf)) 
        {
            line[i][strlen(line[i]) - 1] = '\0';
            i++;
        }
            // Put in temp struct.
            r.clientID = atoi(line[0]);
            strcpy(r.nameMechanic, line[1]); 
            strcpy(r.nameGarage, line[2]); 
            r.carYear = atoi(line[3]);
            strcpy(r.carMake, line[4]);
            strcpy(r.carModel, line[5]);
            strcpy(r.carOwner, line[6]);
            strcpy(r.automotiveProblem, line[7]);
            strcpy(r.partRequired, line[8]);
            r.partCost = strtod(line[9], &tmp);
            r.labor = strtod(line[10], &tmp);
            r.repairCost = strtod(line[11], &tmp);

    }
}

void FillStructs() {

    clearScreen();

    // Get file by File information from within set to tempOpen Function.
    for (i=0; i<5; i++){
        if(i == 0) {
        tempOpen("data/client1.txt");
        }
        if(i == 1) {
        tempOpen("data/client2.txt");        
        }
        if(i == 2) {
        tempOpen("data/client3.txt");        
        }
        if(i == 3) {
        tempOpen("data/client4.txt");        
        }
        if(i == 4) {
        tempOpen("data/client5.txt");        
        }

    //  if ID = 0 does not insert into struct, else has info, will insert data into struct.
     if(r.clientID != 0 ) {
        s[i].clientID = r.clientID;
        strcpy(s[i].nameMechanic, r.nameMechanic);
        strcpy(s[i].nameGarage, r.nameGarage);
        s[i].carYear = r.carYear;
        strcpy(s[i].carMake, r.carMake);
        strcpy(s[i].carModel, r.carModel);
        strcpy(s[i].carOwner, r.carOwner);
        strcpy(s[i].automotiveProblem, r.automotiveProblem);
        strcpy(s[i].partRequired, r.partRequired);
        s[i].partCost = r.partCost;
        s[i].labor = r.labor;
        s[i].repairCost = r.repairCost;
        }
        // set that the data has been imported to 1
        cSet = 1;
    }
}

void saveallpeople() {
    // Clear Screen Show Header
    clearScreen();
    HeaderLogo();

    // Loop to all Structs and save info to file
    for (i=0; i<5; i++){
        saveToFile(i);
    }

    // display messaage saved and go back to menu.
        puts("All Clients Saved..\n");
		puts(" Press Any Key to go to Menu.\n");
        getch();  


}


void saveToFile(int StructPoS) {
  

  // same as Add just saves all data to file 1 by 1.
  if(StructPoS == 0) {

   if (( inpf=fopen("data/client1.txt","w+")) == NULL){
        puts("File Doesn't Exist!");       
        puts("Press Any Key to go back to Menu.");
        getch();
    } 
  }else if(StructPoS == 1) {
     
   if (( inpf=fopen("data/client2.txt","w+")) == NULL){
        puts("File Doesn't Exist!");       
        puts("Press Any Key to go back to Menu.");
        getch();
    } 
  }else if(StructPoS == 2) {
     
   if (( inpf=fopen("data/client3.txt","w+")) == NULL){
        puts("File Doesn't Exist!");       
        puts("Press Any Key to go back to Menu.");
        getch();
    } 
  }else if(StructPoS == 3) {
     
   if (( inpf=fopen("data/client4.txt","w+")) == NULL){
        puts("File Doesn't Exist!");       
        puts("Press Any Key to go back to Menu.");
        getch();
    } 
  }else if(StructPoS == 4) {
   if (( inpf=fopen("data/client5.txt","w+")) == NULL){
        puts("File Doesn't Exist!");       
        puts("Press Any Key to go back to Menu.");
        getch();
    }
  }
  
  if(s[StructPoS].clientID != 0) {
        fprintf(inpf," %d\n", s[StructPoS].clientID);
        fprintf(inpf,"%s\n", s[StructPoS].nameMechanic);
        fprintf(inpf,"%s\n", s[StructPoS].nameGarage);
        fprintf(inpf,"%d\n", s[StructPoS].carYear);
        fprintf(inpf,"%s\n", s[StructPoS].carMake);
        fprintf(inpf,"%s\n", s[StructPoS].carModel);
        fprintf(inpf,"%s\n", s[StructPoS].carOwner);
        fprintf(inpf,"%s\n", s[StructPoS].automotiveProblem);
        fprintf(inpf,"%s\n", s[StructPoS].partRequired);
        fprintf(inpf,"%.2lf\n", s[StructPoS].partCost);
        fprintf(inpf,"%.2lf\n", s[StructPoS].labor);
        fprintf(inpf,"%.2lf", s[StructPoS].repairCost);
        }
        
        fclose(inpf);
}
void clearScreen(){

// Detects if you are using Windows, Linux, Mac or Apple product to allow clear of screen.

#ifdef _WIN32
    system("cls");
#elif defined(unix) || defined(__unix__) || defined(__unix) || (defined(__APPLE__) && defined(__MACH__))
    system("clear");
#endif

}





// Search Function to compair strings.
int string_contains(char *string, char *substring){
  int start_index = 0;
  int string_index=0, substring_index=0;
  int substring_len =string_len(substring);
  int s_len = string_len(string);
  while(substring_index<substring_len && string_index<s_len){
    if(*(string+string_index)==*(substring+substring_index)){
      substring_index++;
    }
    string_index++;
    if(substring_index==substring_len){
      return string_index-substring_len+1;
    }
  }

  return 0;

}

// Read lines into buffer for search
char *read_line(){
  int buffer_len = INPUT_BUFFER;
  char *input = malloc(buffer_len*sizeof(char));
  int c, count=0;

  while(1){
    c = getchar();

    if(c==EOF||c=='\n'){
      input[count]='\0';
      return input;
    }else{
      input[count]=c;
      count++;
    }

    if(count==buffer_len){
      buffer_len+=INPUT_BUFFER;
      input = realloc(input, buffer_len*sizeof(char));
    }

  }
}

// Search
int string_len(char * string){
  int len = 0;
  while(*string!='\0'){
    len++;
    string++;
  }
  return len;
}


// Display Header Logo.
void HeaderLogo() {
puts(" _____ _          _____                        _____     _             "); 
puts("|_   _| |_ ___   |   __|___ ___ ___ ___ ___   |  |  |___| |___ ___ ___ "); 
puts("  | | |   | -_|  |  |  | .'|  _| .'| . | -_|  |     | -_| | . | -_|  _|"); 
puts("  |_| |_|_|___|  |_____|__,|_| |__,|_  |___|  |__|__|___|_|  _|___|_|  "); 
puts("                                   |___|                  |_|          "); 

}







void sortClients() {  
   

                clearScreen();
                HeaderLogo();
                 strcpy(t[0].carOwner,s[0].carOwner);                  
                 strcpy(t[1].carOwner,s[1].carOwner);                  
                 strcpy(t[2].carOwner,s[2].carOwner);                  
                 strcpy(t[3].carOwner,s[3].carOwner);                  
                 strcpy(t[4].carOwner,s[4].carOwner); 
                 
                dictionarySort(t);
                for(i = 0; i < 5; i++) {    
                   

                        
                        printf("#%d: %s  \n", i+1, t[i].carOwner);
                
                }

	        	puts(" Press Any Key to go to Menu.\n");
                getch();  
        

}


void dictionarySort(struct cInfoTmp dictionary[]) {
    int i, j;
    char temp[100];
    for(i = -1; i < 4; i++) {
        for(j = i + 1; j < 4; j++) {
            if(dictionary[j].carOwner != NULL || dictionary[i].carOwner != NULL) {
                if(strcmp(dictionary[i].carOwner, dictionary[j].carOwner) > 0) {
                    strcpy(temp, dictionary[i].carOwner);
                    strcpy(dictionary[i].carOwner, dictionary[j].carOwner);
                    strcpy(dictionary[j].carOwner, temp);
                }
            }
        }
    }
}