#include <iostream>
#include <vector>
#include <algorithm>
#include <string>

using namespace std;

//movie struct definition
struct movie {
    string name;
    string director;
    int year;
    float rating;
    float price;
    int views;
    int renter;
    string dueDate;
};

void addMovie(vector<movie>& movies);
void browseMovies(vector<movie>& movies);
void changeMovie(vector <movie>& mymovies);
void deleteMovie(vector <movie>& mymovies);
void sort(vector <movie>& mymovies);
void searchMovie(vector <movie>& mymovies);
float calculateEarnings(std::vector <movie>& mymovies);
void exitProgram();

void showMainMenu();


int main () {
    vector <movie> mymovies;
    int choice = 0;
    int ch;
    FILE *p_file;
    float total = 0.00;

    choice = 0;
    while (choice != 9)
    {
        showMainMenu();
        cin >> choice;
        //scanf("%d", &choice);
        //int ch;
        //while ((ch = getchar()) != '\n' && ch != EOF);

        //call function for different options
        switch(choice) 
        {
            case 1: addMovie(mymovies); break;
            case 2: browseMovies(mymovies); break;
            case 3: changeMovie(mymovies); break;
            case 4: deleteMovie(mymovies); break;
            case 5: sort(mymovies); break;
            case 6: searchMovie(mymovies); break;
            case 7: total = calculateEarnings(mymovies); printf("\nStore has earned $%.2f\n", total); break;
            case 8: exitProgram(); break;
            default: cout << "\nError. Choice not found.";
        }
    }

    return 0;
}

void addMovie(vector<movie>& movies) {

    // Get Constructor for newMovie.
    movie newMovie;
    // Fill out Infomration of the movie
    cout << "Enter Movie Name: ";
    cin >> newMovie.name;
    
    cout << "Enter Movie Director: ";
    cin >> newMovie.director;

    cout << "Enter Movie year: ";
    cin >> newMovie.year;

    cout << "Enter Movie Rating: ";
    cin >> newMovie.rating;

    cout << "Enter Movie Price: ";
    cin >> newMovie.price;

    cout << "Enter Movie Views: ";
    cin >> newMovie.views;

    cout << "Enter Movie Renter: ";
    cin >> newMovie.renter;

    cout << "Enter Movie Date Due: ";
    cin >> newMovie.dueDate;

    // Add Movie to main Vector.
    movies.push_back(newMovie);
}

void browseMovies(vector<movie>& movies) {
    //Input variable for choice.
    string input;

    // Go though the whole vector printing out its contents
    for (auto element = movies.cbegin(); element != movies.cend(); ++element) {
        cout << "Movie Name: " << element->name << endl;
        cout << "Director: " << element->director << endl;
        cout << "Year: " << element->year << endl;
        cout << "Rating: " << element->rating << endl;
        cout << "Price: " << element->price << endl;
        cout << "# of Views: " << element->views << endl;
        cout << "Renter: " << element->renter << endl;
        cout << "Due Date: " << element->dueDate << endl;
        
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

void changeMovie(vector <movie>& movies) {
    // Get Input variables.
    string input;

    // Set Edit Vector
    movie editMovie;

    // Count to check where you are in the vector.
    int count = 0;

    // Ask what movie to edit.
    cout << "Search for movie: " << endl;
    cin >> input;

    for (auto element = movies.cbegin(); element != movies.cend(); ++element) {
            

            // If Element matches input, edit, if not Add to count go to next entry.
            if(element->name == input) {           
                
                cout << "Enter Movie Name: (" << element->name << "): ";
                cin >> editMovie.name;
                
                cout << "Enter Movie Director: (" << element->director << "): ";
                cin >> editMovie.director;

                cout << "Enter Movie year: (" << element->year << "): ";
                cin >> editMovie.year;

                cout << "Enter Movie Rating: (" << element->rating << "): ";
                cin >> editMovie.rating;

                cout << "Enter Movie Price: (" << element->price << "): ";
                cin >> editMovie.price;

                cout << "Enter Movie Views: (" << element->views << "): ";
                cin >> editMovie.views;

                cout << "Enter Movie Renter: (" << element->renter << "): ";
                cin >> editMovie.renter;

                cout << "Enter Movie Date Due: (" << element->dueDate << "): ";
                cin >> editMovie.dueDate;


                // Erase the Entry at current spot, then add new entry into that spot.
                movies.erase(movies.begin() + count);
                movies.insert(movies.begin() +count , editMovie);


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

void deleteMovie(vector <movie>& movies) {
      string input;      
      int count = 0;
      int newcount = 0;
        cout << "Remove movie: " << endl;
        cin >> input;
 for (auto element = movies.cbegin(); element != movies.cend(); ++element) {
        count = 1;

        if(element->name == input) {
            
            movies.erase(movies.begin() + count);
        cout << "Press anykey to go back.";
        cout << endl;
        cin.ignore();
        cin.get();
            break;
        }     
        count++; 
    }
  
}


// Sort Container by name function
bool sortByName(const movie &lhs, const movie &rhs) { return lhs.name < rhs.name; }

void sort(vector <movie>& movies) {
    
    string input;
    
    // Sort by name and then display.  (Using custom Sort by name function.)
    sort(movies.begin(), movies.end(), sortByName);
    browseMovies(movies);
}

void searchMovie(vector <movie>& movies) {
    // Get Input
    string input;
    cout << "Search for movie: " << endl;
    cin >> input;

    // Go though loop on vector untill Name = Input
    for (auto element = movies.cbegin(); element != movies.cend(); ++element) {            

        // If Found, Print result, if not found Print message and go bakc to main menu.
        if(element->name == input) {
            cout << "Movie Name: " << element->name << endl;
            cout << "Director: " << element->director << endl;
            cout << "Year: " << element->year << endl;
            cout << "Rating: " << element->rating << endl;
            cout << "Price: " << element->price << endl;
            cout << "# of Views: " << element->views << endl;
            cout << "Renter: " << element->renter << endl;
            cout << "Due Date: " << element->dueDate << endl;
            cout << "Press anykey to go back.";
            cin.ignore();
            cin.get();
        }else{
            cout << "No Movie found by the name: " << input << endl;
            cout << "Press anykey to go back.";
            cin.ignore();
            cin.get();

        }
    }
    cout << endl;
}

float calculateEarnings(vector <movie>& movies) {
    // Number to add to decliration
    float numberAdded = 0.0;
    // Go though the Vector, Multiply price by # of views and add to number added.
    for (auto element = movies.cbegin(); element != movies.cend(); ++element) {
        float temp = element->price * element->views;
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
}