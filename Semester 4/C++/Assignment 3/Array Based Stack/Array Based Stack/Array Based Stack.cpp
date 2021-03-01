#include <Windows.h>
#include <iostream>
#include <fstream>
#include <string>
#include <sstream>
#include <cstdlib>
#include <ctime>

using namespace std;
class Stack {
	int top;

public:
	int size = 5;
	int* a = new int[size];

	Stack() { top = -1; }
	bool push(int x, int maxentries);
	int pop();
	void newsize(int size);
	void clear();
	int peek();
	bool isEmpty();
};



void showMainMenu();
void showSubMenu();
void cls();
void readfromfile(int maxentries);
void PrintStack(int maxentries);
string line;

int curmax = 5;

class Stack s;
class Stack old;

int main()
{


	int choice;

	do {
		showMainMenu();
		cin >> choice;
		switch (choice) {

		case 1:
			s.clear();
			s.newsize(1000);
			curmax = 1000;
			readfromfile(1000);
			showSubMenu();
			
			break;
		case 2:

			s.clear();
			s.newsize(10000);
			curmax = 10000;
			readfromfile(10000);
			showSubMenu();
			break;
		case 3:

			s.clear();
			s.newsize(100000);
			curmax = 100000;
			readfromfile(100000);
			showSubMenu();
			break;
		case 4:
			
			break;
		default:

			cout << "Invalid Choice.\n\n\n";
		}

	} while (choice != 4);


	return 0;

}

// Will take Information from a file, and add it to the Array
void readfromfile(int maxentries) {
	ostringstream oss;
	oss << "Data" << maxentries << ".txt";
	string newfile = oss.str();

	ifstream myfile(newfile);
	if (myfile.is_open()) {
		while (!myfile.eof()) {
			getline(myfile, line);

			s.push(stoi(line), maxentries);

		}
		myfile.close();
	}
	else {
		cout << "Unable to open file";
	}
}

bool Stack::push(int x,int maxentries)
{
	if (top >= (maxentries - 1)) {
		return false;
	}
	else {
		a[++top] = x;
		return true;
	}
}


void Stack::clear()
{
	class Stack empty;
	swap(s, empty);
}


void Stack::newsize(int newSize)
{

	int* temp = new int[newSize];

	delete[] s.a;

	s.a = temp;
}



int Stack::pop()
{
	if (top < 0) {
		cout << "Stack Underflow";
		return 0;
	}
	else {
		int x = a[top--];
		return x;
	}
}
int Stack::peek()
{
	if (top < 0) {
		cout << "Stack is Empty";
		return 0;
	}
	else {
		int x = a[top];
		return x;
	}
}

bool Stack::isEmpty()
{
	return (top < 0);
}

static void PrintStack(int maxentries)
{
	int tmpnum = 1;
	int cntnumb = 1;
	class Stack temp; 

	while (s.isEmpty() == false)
	{
		temp.push(s.peek(), maxentries);
		s.pop();
	}

	while (temp.isEmpty() == false)
	{
		tmpnum++;
		cntnumb++;
		int t = temp.peek();
		cout << "#" << t << ", ";
		if (cntnumb == 20) {
			cout << endl;
			cntnumb = 1;
		}
		temp.pop();
		s.push(t, maxentries);

	}
}


void showMainMenu() {

	cout << "Menu \n";
	cout << "1. Add 1000 Entries \n";
	cout << "2. Add 10000 Entries \n";
	cout << "3. Add 100000 Entries \n";
	cout << "4. Exit program \n";

}
void showSubMenu() {

	int choice2;
	do {
		cout << "Sub Menu \n";
		cout << "1. Push to stack \n";
		cout << "2. Pop from stack \n";
		cout << "3. Display Stack \n";
		cout << "4. New Stack \n";
		cin >> choice2;
		switch (choice2) {

		case 1:

			break;
		case 2:

			break;
		case 3:
			PrintStack(curmax);
			cout << endl;
			break;
		case 4:
			s.clear();
			break;
		default:

			cout << "Invalid Choice.\n\n\n";
		}

	} while (choice2 != 4);

}


// Clears Console window Simple function.
void cls() {
	system("CLS");
}


