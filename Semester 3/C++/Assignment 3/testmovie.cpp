#include <iostream>
#include <vector>
#include <algorithm>
#include <string>

#include "movie.h"

using namespace std;

// Meathods   

void addMovie(vector<movie>& myMovies);
void browseMovies(vector<movie>& myMovies);
void changeMovie(vector<movie>& myMovies);
void deleteMovie(vector<movie>& myMovies);
void sort(vector<movie>& myMovies);
void searchMovie(vector<movie>& mymmyMoviesovies);
float calculateEarnings(std::vector<movie>& myMovies);
void exitProgram();
void showMainMenu();


int main() {
    
    vector<movie> myMovies;

    int choice = 0;
    int ch;
    FILE *p_file;
    float total = 0.00;

    choice = 0;
    while (choice != 9)
    {
        showMainMenu();
        cin >> choice;
        
        switch(choice) 
        {
            case 1: addMovie(myMovies); break;
            case 2: browseMovies(myMovies); break;
            case 3: changeMovie(myMovies); break;
            case 4: deleteMovie(myMovies); break;
            case 5: sort(myMovies); break;
            case 6: searchMovie(myMovies); break;
             case 7: total = calculateEarnings(myMovies); printf("\nStore has earned $%.2f\n", total); break;
             case 8: exitProgram(); break;
            default: cout << "\nError. Choice not found.";
        }
    }


    return 0;
}


void addMovie(vector<movie>& myMovies) {
            string n, d, dd;
            int y, v, re;
            float ra, p;
            // Fill out Infomration of the movie
            
            cout << "Enter Movie Name: ";
            cin >> n;
            
            cout << "Enter Movie Director: ";
            cin >> d;

            cout << "Enter Movie year: ";
            cin >> y;

            cout << "Enter Movie Rating: ";
            cin >> ra;

            cout << "Enter Movie Price: ";
            cin >> p;

            cout << "Enter Movie Views: ";
            cin >> v;

            cout << "Enter Movie Renter: ";
            cin >> re;

            cout << "Enter Movie Date Due: ";
            cin >> dd;
            
            movie newMovie(n, d, y, ra, p, v, re, dd);

            myMovies.push_back(newMovie);

}

void browseMovies(vector<movie>& myMovies) {
    //Input variable for choice.
    string input;

    // Go though the whole vector printing out its contents
    for (int i = 0; i < myMovies.size(); i++) {
      
        myMovies[i].Display();


        // Ask to Continue or go back to main menu.
        cout << "(C)ontinue or (B)ack to menu? " << endl;
        cin >> input;

        // if B or B, go back to main menu, if C or c go to next entry.
        if(input == "B" || input == "b") {
            break;
        }else if(input == "C" || input == "c") {
            // Dont break.
        } else{
            break;
        }

    }
    
    cout << endl;
}

void changeMovie(vector <movie>& myMovies) {
    // Get Input variables.
    string input;

            string n, d, dd;
            int y, v, re;
            float ra, p;
    // Set Edit Vector
    

    // Count to check where you are in the vector.
    int count = 0;

    // Ask what movie to edit.
    cout << "Search for movie: " << endl;
    cin >> input;

    for (int i = 0; i < myMovies.size(); i++) {
            

            // If Element matches input, edit, if not Add to count go to next entry.
            if(myMovies[i].getName() == input) {           
                
                cout << "Enter Movie Name: (" << myMovies[i].getName() << "): ";
                cin >> n;
                
                cout << "Enter Movie Director: (" << myMovies[i].getDirector() << "): ";
                cin >> d;

                cout << "Enter Movie year: (" << myMovies[i].getYear() << "): ";
                cin >> y;

                cout << "Enter Movie Rating: (" << myMovies[i].getRating() << "): ";
                cin >> ra;

                cout << "Enter Movie Price: (" << myMovies[i].getPrice() << "): ";
                cin >> p;

                cout << "Enter Movie Views: (" << myMovies[i].getViews() << "): ";
                cin >> v;

                cout << "Enter Movie Renter: (" << myMovies[i].getRenter() << "): ";
                cin >> re;

                cout << "Enter Movie Date Due: (" << myMovies[i].getDueDate() << "): ";
                cin >> dd;

                movie editMovie(n, d, y, ra, p, v, re, dd);

                // Erase the Entry at current spot, then add new entry into that spot.
                myMovies.erase(myMovies.begin() + i);
                myMovies.insert(myMovies.begin() + i , editMovie);



                // Print exit notice
                cout << "Movie Edited, Press anykey to go back.";
                cin.ignore();
                cin.get();
                break;



            }
            count++;
        }
    cout << endl;
}



// Sort Container by name function
bool sortByName(movie lhs,movie rhs) { return lhs.getName() < rhs.getName(); }

void sort(vector <movie>& myMovies) {

    // Sort by name and then display.  (Using custom Sort by name function.)
    sort(myMovies.begin(), myMovies.end(), sortByName);
    browseMovies(myMovies);
}


void deleteMovie(vector <movie>& myMovies) {
      string eraseInp;    
      int newcount = 0;
        cout << "Remove movie: " << endl;
        cin >> eraseInp;
    for (int i = 0; i < myMovies.size(); i++) {

        if(myMovies[i].getName() == eraseInp) {
            
            myMovies.erase(myMovies.begin() + i);
            cout << "Movie: " << eraseInp << " erased" << endl;
            cout << "Press anykey to go back."<< endl;
            cin.ignore();
            cin.get();
            break;
        }     
    }
  
}

void searchMovie(vector <movie>& myMovies) {
    // Get Input
    string input;
    int count = 0;
    cout << "Search for movie: " << endl;
    cin >> input;

    // Go though loop on vector untill Name = Input
    for (int i = 0; i < myMovies.size(); i++) {          

        // If Found, Print result, if not found Print message and go bakc to main menu.
        if(myMovies[i].getName() == input) {
            
            myMovies[i].Display();
            cout << "Press anykey to go back.";
            cin.ignore();
            cin.get();
        count = 1;
        }

        
    }
    if(count == 0) {
            cout << "No Movie found by the name: " << input << endl;
            cout << "Press anykey to go back.";
            cin.ignore();
            cin.get();

        }
    cout << endl;
}


float calculateEarnings(vector <movie>& myMovies) {
    // Number to add to decliration
    float numberAdded = 0.0;
    // Go though the Vector, Multiply price by # of views and add to number added.
    for (int i = 0; i < myMovies.size(); i++) {   
        float temp = myMovies[i].getPrice() * myMovies[i].getViews();
        numberAdded = numberAdded + temp;
    }

    // Return Number added after complete.
    return numberAdded;
}

void showMainMenu() {

    // Fixed Darrens Number Mixup after removing couple entries and spelled "Calculate" properly
        puts("\nPlease choose an option:");
        puts("1. Add new entry");
        puts("2. Browse entries");
        puts("3. Modify existing entry ");
        puts("4. Delete entry");
        puts("5. Sort entries");
        puts("6. Search for entry");
        puts("7. Calculate total");
        puts("8. Exit");
}


void exitProgram() {
    exit;
}