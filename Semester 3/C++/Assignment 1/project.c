/*
-------------------------------------------------------------------------------------
Program: project.c
Date: 09/27/2020
Autor: Marshall Radziwilko
Program Details:

1. From the linked list project file supplied, write a sorting routine to put the movie titles in alphabetical order. 
   The sorting must be done using pointer swaps, not copying the data into a temporary structure.

2. Restructure the linked list project to include a "previous" pointer within the defined structure.
   Modify the "Add Node" function to link to the previous node in the list. Modify the Browse function to go to the next or 
   previous entries in the list (i.e. traverse forward and backward in the list).

-------------------------------------------------------------------------------------
                                        Commits
-------------------------------------------------------------------------------------
|       Date        |        Programmer        |                Changelog           | 
|   Unknown         |   Darren Andrews         |           First Version  1.0       | 
|   2020-09-27      |   Marshall Radziwilko    |           Remade Functions         |
-------------------------------------------------------------------------------------
*/

#include<stdio.h>
#include<string.h>
#include<stdlib.h>

//movie struct definition
// Add new Prev Struct - Marshall
struct movie {
    char name[50];
    char director[50];
    int year;
    float rating;
    float price;
    int views;
    int renter;
    char dueDate[15];
    struct movie *next;
    struct movie *prev;
};

struct movie *NewMovie();
void addMovie(struct movie *start);
void browseMovies(struct movie *start);
void showMovie(struct movie *current);
void changeMovie(struct movie *start);
void editMovie(struct movie *current);
struct movie *deleteMovie(struct movie *start);
void save(struct movie *start, FILE *p_file);
struct movie *load(FILE *p_file);
struct movie *sort(struct movie *start);
void searchMovie(struct movie *start);
float calculateEarnings(struct movie *start);
struct movie *exitProgram(struct movie *start);

void showMainMenu();
void showLoadMenu();

int main () {
    struct movie *start = NULL;
    int choice = 0;
    int ch;
    FILE *p_file;
    float total = 0.00;

    showLoadMenu();
    scanf("%d", &choice);
    while ((ch = getchar()) != '\n' && ch != EOF);

    switch (choice) {
        case 1: start = load(p_file); break;
        default: break;
    }

    choice = 0;
    while (choice != 9)
    {
        showMainMenu();

        scanf("%d", &choice);
        int ch;
        while ((ch = getchar()) != '\n' && ch != EOF);

        //call function for different options
        switch(choice) 
        {
            case 1:
            if (start == NULL)
            {
                start = NewMovie();
            }
            else
            {
                addMovie(start);
            };
            break;
            case 2: browseMovies(start); break;
            case 3: changeMovie(start); break;
            case 4: start = deleteMovie(start); break;
            case 5: save(start, p_file); break;
            case 6: start = sort(start); break;
            case 7: searchMovie(start); break;
            case 8: total = calculateEarnings(start); printf("\nStore has earned $%.2f\n", total); break;
            case 9: start = exitProgram(start); break;
            default: fputs("\nError. Choice not found.", stdout);
        }
    }

    return 0;
}

struct movie *NewMovie() {
    struct movie *new = NULL;
    int ch;

    new = (struct movie *)malloc(sizeof(struct movie));
    if (new == NULL)
    {
        fputs("\n\nMemory allocation error", stdout);
        exit(1);
    }

    fputs("\n\nEnter Movie Details...", stdout);
    fputs("\nName:", stdout);
    fgets(new->name, 50, stdin);
    new->name[strcspn(new->name, "\n")] = 0; //strip trailing \n
    
        fputs("Director:", stdout);
        fgets(new->director, 50, stdin);
        new->director[strcspn(new->director, "\n")] = 0;

        fputs("Year:", stdout);
        scanf("%d", &new->year);
        while ((ch = getchar()) != '\n' && ch != EOF);

        fputs("Rating:", stdout);
        scanf("%f", &new->rating);
        while ((ch = getchar()) != '\n' && ch != EOF);

        fputs("Price:", stdout);
        scanf("%f", &new->price);
        while ((ch = getchar()) != '\n' && ch != EOF);

        fputs("Number of Rentals:", stdout);
        scanf("%d", &new->views);
        while ((ch = getchar()) != '\n' && ch != EOF);

        fputs("Renter ID:", stdout);
        scanf("%d", &new->renter);
        while ((ch = getchar()) != '\n' && ch != EOF);

        fputs("Due Date:", stdout);
        fgets(new->dueDate, 15, stdin);
        new->dueDate[strcspn(new->dueDate, "\n")] = 0;
    

    new->next = NULL;

    return new;
}

void addMovie(struct movie *start) {
    fputs("\n\nAdding new node...", stdout);

    //scroll to last node
    struct movie *current = start;
    while (current->next != NULL)
    {
        current = current->next;
    }
    // Make sure a pointer to previous on the next entry equals this entry.  - Marshall
    current->next = NewMovie();
    current->next->prev = current;
}

// Rebuilt Function, if Person selects N for nExt goes to next entry, if person types P then goes to previous entry and if presses B Exits to main Menu.  - Marshall
void browseMovies(struct movie *start) {
    fputs("\n\nBrowsing through entries...", stdout);
    char choice;
    choice = 'Y';
    int ch;
    int count = 1;

    struct movie *current = start;


    // Changed from N to B for Back instead of No - Marshall
    while (current != NULL && choice != 'B' && choice != 'b') {
    
        printf("\n\nMovie #%d\n", count);

        showMovie(current);

        // Created new Menu Fuction if is start ask for Next or Back, if is Greter then first but not last then Ask Next, Previous and Back. if is last Ask for Previous and back.  - Marshall
        if (current == start) {
            fputs("\n (N)ext Entry - (B)ack (N/B)?", stdout);
            choice = fgetc(stdin);
            while ((ch = getchar()) != '\n' && ch != EOF);

            
        }else if (current->next != NULL) {
            
            fputs("\n(P)revious Entry - (N)ext Entry - (B)ack (P/N/B)?", stdout);
            choice = fgetc(stdin);
            while ((ch = getchar()) != '\n' && ch != EOF);
 
        }else{
            fputs("\n(P)revious Entry - (B)ack (P/B)?", stdout);
            choice = fgetc(stdin);
            while ((ch = getchar()) != '\n' && ch != EOF);
        }

        if(choice == 'B' || choice == 'b' ) {
            break;
        }
        
        if(choice == 'N' || choice == 'n' ) {
                count++;
                current = current->next;
        }
        
        if(choice == 'P' || choice == 'p' ) {
                count--;
                current = current->prev;
        }


            
    }

}

void showMovie(struct movie *current) {
    if (current != NULL) {
        printf("Name: %s\n", current->name);
        printf("Director: %s\n", current->director);
        printf("Year: %d\n", current->year);
        printf("Rating: %.1f\n", current->rating);
        printf("Price: %.2f\n", current->price);
        printf("Number of Rentals: %d\n", current->views);
        printf("Current Renter: %d\n", current->renter);
        printf("Due Date: %s\n\n", current->dueDate);
    } 
}

void changeMovie(struct movie *start) {
    fputs("\n\nModifying entry...", stdout);
    int position, counter = 1;
    int ch;
    struct movie *current = start;

    fputs("\n\nEnter position: ", stdout);
    scanf("%d", &position);
    while ((ch = getchar()) != '\n' && ch != EOF);

    
    while (counter < position && current != NULL)
    {
        counter++;
        current = current->next;
    }

    if (current == NULL) {
        puts("\nError! Out of Bounds:\n");
    } else {
        editMovie(current);
    }

    puts("\nFinished editing...\n");
}

void editMovie(struct movie *current) {
    puts("\nYou have selected the following movie:\n");
    char choice = 'N';
    int field = 0;
    int ch;

    printf("Name: %s\n", current->name);
    puts("\nDo you want to edit this record (Y/N)?");
    choice = fgetc(stdin);
    while ((ch = getchar()) != '\n' && ch != EOF);
    
    if (choice == 'Y' || choice == 'y') {

        char choice2 = 'Y';
        int field = 0;

        while (choice2 == 'Y' || choice2 == 'y') {

            puts("\nDo you want to edit this record (Y/N)?");
            puts("Please enter the number corresponding to the field you wish to change: \n");
            puts("1. Name");
            puts("2. Director");
            puts("3. Year");
            puts("4. Rating");
            puts("5. Price");
            puts("6. Number of Rentals");
            puts("7. Renter ID");
            puts("8. Due Date");
            scanf("%d", &field);
            while ((ch = getchar()) != '\n' && ch != EOF);

            switch (field) {
                case 1: 
                    fputs("New Name:", stdout);
                    fgets(current->name, 50, stdin);
                    current->name[strcspn(current->name, "\n")] = 0;
                    break;
                case 2:
                    fputs("New Director:", stdout);
                    fgets(current->director, 50, stdin);
                    current->director[strcspn(current->director, "\n")] = 0;
                    break;
                case 3:
                    fputs("New Year:", stdout);
                    scanf("%d", &current->year);
                    while ((ch = getchar()) != '\n' && ch != EOF);
                    break;
                case 4:
                    fputs("New Rating:", stdout);
                    scanf("%f", &current->rating);
                    while ((ch = getchar()) != '\n' && ch != EOF);
                    break;
                case 5:
                    fputs("New Price:", stdout);
                    scanf("%f", &current->price);
                    while ((ch = getchar()) != '\n' && ch != EOF);
                    break;
                case 6:
                    fputs("Number of Rentals:", stdout);
                    scanf("%d", &current->views);
                    while ((ch = getchar()) != '\n' && ch != EOF);
                    break;
                case 7:
                    fputs("Renter ID:", stdout);
                    scanf("%d", &current->renter);
                    while ((ch = getchar()) != '\n' && ch != EOF);
                    break;
                case 8:
                    fputs("Due Date:", stdout);
                    fgets(current->dueDate, 10, stdin);
                    current->dueDate[strcspn(current->dueDate, "\n")] = 0;
                    break;
            }

            puts("\nDo you want to keep editing this record (Y/N)?");
            choice2 = fgetc(stdin);
            while ((ch = getchar()) != '\n' && ch != EOF);
        }
    }

}

struct movie *deleteMovie(struct movie *start) {
    fputs("\n\nDelete entry...", stdout);
    int position, counter = 1;
    int ch;
    struct movie *current = start, *last = start;
    struct movie *next = NULL;

    fputs("\n\nEnter position: ", stdout);
    scanf("%d", &position);
    while ((ch = getchar()) != '\n' && ch != EOF);

    if (current != NULL) {
        next = current->next;
    } 
    
    while (counter < position && current != NULL)
    {
        last = current;
        current = current->next;
        next = current->next;
        counter++;
    }

    if (current == NULL) {
        puts("\nError! Out of Bounds:\n");
    } else {
        
        puts("\nYou have selected the following movie:\n");
        char choice = 'N';
        int field = 0;
        int ch;

        printf("Name: %s\n", current->name);
        puts("\nDo you want to delete this record (Y/N)?");
        choice = fgetc(stdin);
        while ((ch = getchar()) != '\n' && ch != EOF);
        
        if (choice == 'Y' || choice == 'y') {

            if (position == 1) {
                //remove head node, reassign start
                start = next;
            } else if (next == NULL) {
                //remove tail node
                last->next = NULL;
            } else {
                //remove middle node
                last->next = next;
            }
            free(current);

            puts("\nEntry Removed...\n");
        } else {
            puts("\nEntry NOT Removed...\n");
        }

    }

    return start;
}

void save(struct movie *start, FILE *p_file) {
    fputs("\n\nSaving data...", stdout);

    char filename[15] = "database.txt";
    struct movie *current = start;
    int nodes=0;

    while (current != NULL) {
        current = current->next;
        nodes++;
    }

    p_file = fopen(filename, "wb");
    if (p_file == NULL) {
        puts("Error opening file.");
        exit(1);
    }
    fprintf(p_file, "%d", nodes);

    current = start;
    while(current != NULL) {
        fwrite(current, sizeof(struct movie), 1, p_file);
        current = current->next;
    }

    if (&fwrite != 0) {
        puts("\nSave Successful.\n");
    } else {
        puts("\nError saving.\n");
    }
    fclose(p_file);

}


// Added Last feild, and Previous pointers to load. - Marshall
struct movie *load(FILE *p_file) {
    fputs("\n\nLoading data\n", stdout);

    char filename[15] = "database.txt";
    struct movie *current = NULL, *new = NULL, *start = NULL, *last = NULL;
    int nodes = 0, counter = 0;

    p_file = fopen(filename, "rb");
    if (p_file == NULL) {
        puts("\nError opening file.");
        exit(1);
    }
    
    fscanf(p_file, "%d", &nodes);

    printf("%d nodes",nodes );
    while (counter < nodes) {
        puts("new node");

        new = (struct movie *)malloc(sizeof(struct movie));
        if (new == NULL) {
            puts("Memory allocation error");
            exit(1);
        }

        if (current != NULL) {
            current->next = new; 
            // added previous pointer to current.  - Marshall           
            current->next->prev = current;
        } 
        puts("here");
        current = new;
        if (start == NULL) {
            start = current;
        }

        fread(new, sizeof(struct movie), 1, p_file);
        new->next = NULL;
        // added Pointer to last and set last to current  - Marshall
        current->prev = last;
        last = current;

        counter ++;
    }
    

    fclose(p_file);
   
    return start;
}

struct movie *sort(struct movie *start) {
    fputs("\n\nSorting data\n", stdout);    

    // added Start and last pointer calls - Marshall
    struct movie *current = start, *last = start;


    // Sorting function - Marshall
    while(current->next != NULL){        
        if(strcmp(current->name,current->next->name) > 0) {
           if(current == start) {
                current = current->next;
                start = current;
                last->next = current->next;
                current->next = last;
            } else {
                last->next = current->next;
                last = current;
                current = current->next;
                last->next = current->next;
                current->next = last;
            }
            last = start;
            current = start;
        } else {
            current = current->next;
            if(last->next!=current) {
                last = last->next;
            }
        }   
    }
    return start;
}

void searchMovie(struct movie *start) {
    fputs("\n\nSearching for movie", stdout);

    struct movie *current = start;

    char name[50];
    int matches = 0;

    puts("\nPlease enter an movie name to search for:");
    fgets(name, 50, stdin);
    name[strcspn(name, "\n")] = 0;
    
    while(current != NULL) {
        if(strstr(current->name, name)) {
            showMovie(current);
            matches++;
        }
        current = current->next;
    }
    printf("There were %d match(es).\n", matches);
}

float calculateEarnings(struct movie *current) {
    fputs("\n\nCalculating for earnings...", stdout);

    float total = 0.00;

    while (current != NULL)
    {
        total += current->price * current->views;
        current = current->next;
    }

    return total;
}

void showMainMenu() {
        puts("\nPlease choose an option:");
        puts("1. Add new entry");
        puts("2. Browse entries");
        puts("3. Modify existing entry ");
        puts("4. Delete entry");
        puts("5. Save entries ");
        puts("6. Sort entries");
        puts("7. Search for entry");
        puts("8. Calcuate total");
        puts("9. Exit");
}

void showLoadMenu() {
    puts("\nWould you like to:");
    puts("1. Load a previously saved library database");
    puts("2. Load a new database\n");
}

struct movie *exitProgram(struct movie *start) {
    fputs("\n\nFreeing Memory...", stdout);

    struct movie *current = start;
    struct movie *next = NULL;

    while (current != NULL)
    {
        next = current->next;
        free(current);
        current = next;
    }

    fputs("\nCleanup complete. Exiting...", stdout);
    return start;
}