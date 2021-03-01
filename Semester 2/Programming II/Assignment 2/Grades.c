#include <stdio.h>
#include <string.h>
#define int MAX 6;


    // Course Structure.
    struct Courses
    {
        char Name[30];
        int Id;
        double gradeC;
        double gradeSAAD;
        double gradeOOP;
        double gradeAPPD;
        double gradeJS;
        double Average;
    };
    

    // Student Set function, the Courses variable, get ID, NAME, StudentID, and Grades. Calculate Total Average. Combine into proper ID.
    int SetStudent(struct Courses myCourse[], int id, char* name, int sid, double gradC, double gradSAAD, double gradOOP, double gradAPPD, double gradJ) {

        // Set Proper Structure
        strcpy(myCourse[id].Name, name);
        myCourse[id].Id = sid;
        myCourse[id].gradeC = gradC; 
        myCourse[id].gradeSAAD = gradSAAD;
        myCourse[id].gradeOOP = gradOOP;
        myCourse[id].gradeAPPD = gradAPPD;
        myCourse[id].gradeJS = gradJ;

        double average = 0.00;

        // Calculat Average
        average = (gradC + gradSAAD + gradOOP + gradAPPD + gradJ) / 5;

        // Set Average into Courses Structure.
        myCourse[id].Average = average;
        return 0;
    }


    void Display(struct Courses myCourse[]) {
        
      for ( int j = 0; j < MAX; j++ ) { 
                // Display values in myCourse.
                printf("===================== \n");
                printf("Student Name: %s \n", myCourse[j].Name );
                printf("  Student ID: %d \n", myCourse[j].Id );
                printf("===================== \n");
                printf("     Grade C: %%%.2f \n", myCourse[j].gradeC );
                printf("  Grade SAAD: %%%.2f \n", myCourse[j].gradeSAAD );
                printf("   Grade OOP: %%%.2f \n", myCourse[j].gradeOOP );
                printf("  Grade APPD: %%%.2f \n", myCourse[j].gradeAPPD );
                printf("    Grade JS: %%%.2f \n", myCourse[j].gradeJS );
                printf("     Average: %%%.2f \n", myCourse[j].Average );
                printf("\n");
      }
    }



    int main () {

        
    struct Courses myCourse[6];


        // Call Function to set Each Student's Name, ID, And Grades
        SetStudent(myCourse, 0, "Dale", 54353, 67 ,56 ,48, 57, 95);
        SetStudent(myCourse, 1, "Don", 54354, 87, 84, 78, 96, 60);
        SetStudent(myCourse, 2, "David", 54355, 67, 82, 63, 45, 95);
        SetStudent(myCourse, 3, "Marshall", 54356, 59, 65, 89, 67, 71);
        SetStudent(myCourse, 4, "Jim", 54357, 57, 84, 59, 99, 0);
        SetStudent(myCourse, 5, "Tom", 54358, 45, 76, 46, 87, 99);

        // Display Resaults
        Display(myCourse);

        return 0;
    } 