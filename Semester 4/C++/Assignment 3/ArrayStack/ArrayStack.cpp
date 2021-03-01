#include <Windows.h>
#include <iostream>
#include <fstream>
#include <string>
#include <sstream>
#include <cstdlib>
#include <ctime>
#include <algorithm>


// Define of Files and Maxes

#define MAX 1

using namespace std;

class Stack {
	int top;

	public:

		Stack() { top = -1; }
		bool push(int x);
		int pop();
		void setMax(int x);
		int peek();
		bool isEmpty();
		int maxval = MAX;
		int* a = new int[maxval];
};


string line;

class Stack s;

void Stack::setMax(int x){
	maxval = x;
	cout << maxval << endl;
}

bool Stack::push(int x) {

	if (top >= (maxval - 1)) {
		cout << "OverFlow";
		return false;
	}
	else {
		a[++top] = x;
		return true;
	}
}



int Stack::pop() {

	if (top < 0) {
		//cout << "Stack Underflow";
		return 0;
	}
	else {
		int x = a[top--];
		return x;
	}
}

int Stack::peek() {
	if (top < 0) {
		cout << "Stack is Empty";
		return 0;
	}
	else {
		int x = a[top];
		return x;
	}
}

bool Stack::isEmpty() {
	return (top < 0);
}


// Will take Information from a file, and add it to the Array
void readfromfile() {
	ostringstream oss;
	oss << "Data1000.txt";
	string newfile = oss.str();
	int count = 1;


	ifstream myfile(newfile);

	if (myfile.is_open()) {
		while (!myfile.eof()) {
			getline(myfile, line);
			s.push(stoi(line));
			count++;

		}
		cout << "===============================================" << endl;
		cout << "Push Complete " << endl;
		cout << "===============================================" << endl;
		cout << "#" << count << " Entries Added to Stack" << endl << endl;
		myfile.close();
	}
	else {
		cout << "Unable to open file";
	}
}


static void PrintStack()
{
	int tmpnum = 1;
	int cntnumb = 1;
	class Stack temp;

	while (s.isEmpty() == false)
	{
		temp.push(s.peek());
		s.pop();
	}

	while (temp.isEmpty() == false)
	{
		tmpnum++;
		cntnumb++;
		int t = temp.peek();
		cout << "#" << t << " ";
		if (cntnumb == 20) {
			cout << endl;
			cntnumb = 1;
		}
		temp.pop();
		s.push(t);

	}
}


int main()
{

	int numLines = 0;
	ifstream in("Data100000.txt");
	//while ( ! in.eof() )
	while (in.good())
	{
		std::string line;
		std::getline(in, line);
		++numLines;
	}

	s.setMax(numLines+1);
	// Push from File into Stack (Push found inside readfromfile function)
	readfromfile();

	cout << "===============================================" << endl;
	cout << "Pop Function" << endl;
	cout << "===============================================" << endl;
	// LILO
	cout << s.pop() << " Popped from stack" << endl << endl;
	cout << s.pop() << " Popped from stack" << endl << endl;
	cout << s.pop() << " Popped from stack" << endl << endl;
	cout << s.pop() << " Popped from stack" << endl << endl;



	cout << "===============================================" << endl;
	cout << "All Entries in stack" << endl;
	cout << "===============================================" << endl;
	//PrintStack();
	cout << endl << endl;
	system("pause");

}
