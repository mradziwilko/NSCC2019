#include "MyLinkedList.h"
#include "LinkedListNode.h"
#include <iostream>
#include <fstream>
#include <string>
#include <cstdlib>
#include <ctime>


using namespace std;
// Variables
int singlearr[5];
int p1search, p1removevalue, p1removepos, p2search, p2removevalue, p2removepos, p1AddData, p1AddPos, p2AddData, p2AddPos;
string line;
unsigned int arr_length = 0;
int i;

// Will take Information from a file, and add it to the Array
void readfromfile(string TxtFile) {
    ifstream myfile(TxtFile);
    if (myfile.is_open()) {
        while (!myfile.eof()) {
            getline(myfile, line);
            if (arr_length < 5) {
                singlearr[arr_length++] = stoi(line);
            }
        }
        myfile.close();
    }
    else {
        cout << "Unable to open file";
    }
}

int main()
{

    // Base LinkedList
	MyLinkedList* list = new MyLinkedList();

    // Add Number
    list->add(55);

    // Append Number (To the end(
    list->append(25);
    list->append(31);
    list->append(24);
    list->append(66);
    list->append(756);
    list->append(453);



    // Display Current Values
    cout << "\n=============================================\n";
    cout << "Displaying Initial Values:";
    cout << "\n=============================================\n";
    list->display();


    // Insert new Value in a Position
    cout << "\n=============================================\n";
    cout << "Inserting New Value:";
    cout << "\n=============================================\n";

    cout << "Add Number?\n";
    cin >> p1AddData;
    cout << "At Position?\n";
    cin >> p1AddPos;

    list->insert(p1AddData, p1AddPos);
    list->display();




    // Search for a Value
    cout << "\n=============================================\n";
    cout << "Search for: \n";
    cin >> p1search;
    list->search(p1search);
    cout << "============================================\n\n";


    // Remove a Value
    cout << "=============================================\n";
    cout << "What Value to remove?";
    cout << "\n=============================================\n";
    cin >> p1removevalue;
    list->removeval(p1removevalue);

    cout << "\nDisplay Resaults : \n";
    list->display();

    // Remove a item in a Position
    cout << "\n============================================\n";
    cout << "Remove Value at Position?";
    cout << "\n=============================================\n";
    cin >> p1removepos;
    list->removepos(p1removepos);
    cout << "\n\nDisplay Resaults : \n";
    list->display();


    // Read File, Put into an array, then put array into a new Linked List
    cout << "\n\n\n";
    cout << "\n============================================\n";
    cout << "Read File and Put into new List";
    cout << "\n=============================================\n";



    MyLinkedList* FileLL = new MyLinkedList();
    string filename = "numbers.txt";
    readfromfile(filename);
    for (i = 0; i < 5; i++) {
        FileLL->append(singlearr[i]);
    }
    FileLL->display();



    // Insert new Value in a position
    cout << "\n=============================================\n";
    cout << "Inserting New Value:";
    cout << "\n=============================================\n";

    cout << "Add Number?\n";
    cin >> p2AddData;
    cout << "At Position?\n";
    cin >> p2AddPos;
    FileLL->insert(p2AddData, p2AddPos);
    FileLL->display();


    // Search for item in List
    cout << "\n=============================================\n";
    cout << "Search for?";
    cout << "\n=============================================\n";
    cin >> p2search;
    FileLL->search(p2search);

    // Remove a Value
    cout << "\n=============================================\n";
    cout << "What Value to Remove ?";
    cout << "\n=============================================\n";
    cin >> p2removevalue;
    FileLL->removeval(p2removevalue);
    cout << "\n\nDisplay Resaults : \n";
    FileLL->display();


    // Remove a Item in a Position
    cout << "\n=============================================\n";
    cout << "What Position you want to remove? (#) ?";
    cout << "\n=============================================\n";
    cin >> p2removepos;
    FileLL->removepos(p2removepos);
    cout << "\n\nDisplay Resaults : \n";
    FileLL->display();



    system("pause");

}

