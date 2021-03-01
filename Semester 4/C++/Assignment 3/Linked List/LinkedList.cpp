#include <iostream>
#include <fstream>
#include <string>
#include <cstdlib>
#include <ctime>
#include "MyLinkedList.h"
#include "LinkedListNode.h"

#include <chrono>
using namespace std;

#define MAX 1000000

// Variables
string line;
int i;


MyLinkedList* list;

// Will take Information from a file, and add it to the Array
void readfromfile() {
    int count = 1;

	string newfile = "Data1000000.txt";
	
    ifstream myfile(newfile);
    if (myfile.is_open()) {

        chrono::high_resolution_clock::time_point t1 = chrono::high_resolution_clock::now();

        while (!myfile.eof()) {
            getline(myfile, line);

            list->push(stoi(line));
            count++;
        }

        myfile.close();
        chrono::high_resolution_clock::time_point t2 = chrono::high_resolution_clock::now();

        chrono::duration<double> time_span = chrono::duration_cast<chrono::duration<double>>(t2 - t1);

        cout << "============================================" << endl;
        cout << "Read File and Put into new List" << endl;
        cout << "=============================================" << endl ;
        cout << "#" << count << " Entries Added to list" << endl << endl;

        std::cout << "Load time of " << MAX << " Entries : " << time_span.count() << " seconds." << endl << endl;
    }
    else {
        cout << "Unable to open file";
    }
}

int main()
{


    // My List is a FILO List, First in last out. Normaly people do LIFO which is Last In First Out. 


    list = new MyLinkedList();
        // Read File, Put into an array, then put array into a new Linked List
    readfromfile();
    list->peek();
    list->pop();
    list->peek();

    system("pause");

}

