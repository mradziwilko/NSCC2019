#include <iostream>
#include <fstream>
#include <string>
#include <cstdlib>
#include <ctime>
#include <chrono>
using namespace std;
struct node {
    int data;
    struct node* next;
};
struct node* front = NULL;
struct node* rear = NULL;
struct node* temp;

// Variables
string line;
int i;
string newfile = "Data1000.txt";

void Insert() {
    int val;
    cout << "Insert the element in queue : " << endl;
    cin >> val;
    if (rear == NULL) {
        rear = (struct node*)malloc(sizeof(struct node));
        rear->next = NULL;
        rear->data = val;
        front = rear;
    }
    else {
        temp = (struct node*)malloc(sizeof(struct node));
        rear->next = temp;
        temp->data = val;
        temp->next = NULL;
        rear = temp;
    }
}


void fileInsert(int val) {

    if (rear == NULL) {
        rear = (struct node*)malloc(sizeof(struct node));
        rear->next = NULL;
        rear->data = val;
        front = rear;
    }
    else {
        temp = (struct node*)malloc(sizeof(struct node));
        rear->next = temp;
        temp->data = val;
        temp->next = NULL;
        rear = temp;
    }
}

void Delete() {
    temp = front;
    if (front == NULL) {
        cout << "Underflow" << endl;
        return;
    }
    else
        if (temp->next != NULL) {
            temp = temp->next;
            cout << "Element deleted from queue is : " << front->data << endl;
            free(front);
            front = temp;
        }
        else {
            cout << "Element deleted from queue is : " << front->data << endl;
            free(front);
            front = NULL;
            rear = NULL;
        }
}

void Display() {
    temp = front;
    if ((front == NULL) && (rear == NULL)) {
        cout << "Queue is empty" << endl;
        return;
    }
    cout << "Queue elements are: ";
    while (temp != NULL) {
        cout << temp->data << " ";
        temp = temp->next;
    }
    cout << endl;
}

// Will take Information from a file, and add it to the Array
void readfromfile() {
    int count = 1;


    ifstream myfile(newfile);
    if (myfile.is_open()) {

        chrono::high_resolution_clock::time_point t1 = chrono::high_resolution_clock::now();

        while (!myfile.eof()) {
            getline(myfile, line);
            
            fileInsert(stoi(line));

            count++;
        }

        myfile.close();
        chrono::high_resolution_clock::time_point t2 = chrono::high_resolution_clock::now();

        chrono::duration<double> time_span = chrono::duration_cast<chrono::duration<double>>(t2 - t1);

        cout << "============================================" << endl;
        cout << "Read File and Put into new List" << endl;
        cout << "=============================================" << endl;
        cout << "#" << count << " Entries Added to list" << endl << endl;

        std::cout << "Load time of Entries : " << time_span.count() << " seconds." << endl << endl;
    }
    else {
        cout << "Unable to open file";
    }
}
int main() {
    int ch;
    do {
        cout << "1) Load Entries from File." << endl;
        cout << "2) Insert element to queue" << endl;
        cout << "3) Delete element from queue" << endl;
        cout << "4) Display all the elements of queue" << endl;
        cout << "5) Exit" << endl;
        cout << "Enter your choice : " << endl;
        cin >> ch;
        switch (ch) {
        case 1:
            system("CLS");
            readfromfile();
            break;
        case 2:
            system("CLS");
            Insert();
            break;
        case 3:
            system("CLS"); Delete();
            break;
        case 4:
            system("CLS"); Display();
            break;
        case 5: cout << "Exit" << endl;
            break;
        default:
            system("CLS");  cout << "Invalid choice" << endl;
        }
    } while (ch != 5);
    return 0;
}