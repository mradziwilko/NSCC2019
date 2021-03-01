// Queue Array.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <fstream>
#include <string>
#include <cstdlib>
#include <ctime>
#include <chrono>

using namespace std;

// Variables
string line;
int i;
string newfile = "Data1000.txt";


// A structure to represent a queue 
class Queue {
public:
	int front, rear, size;
	unsigned capacity;
	int* array;
};

// function to create a queue 
// of given capacity. 
// It initializes size of queue as 0 
Queue* createQueue(unsigned capacity)
{
	Queue* queue = new Queue();
	queue->capacity = capacity;
	queue->front = queue->size = 0;

	// This is important, see the enqueue 
	queue->rear = capacity - 1;
	queue->array = new int[(
		queue->capacity * sizeof(int))];
	return queue;
}

// Queue is full when size 
// becomes equal to the capacity 
int isFull(Queue* queue)
{
	return (queue->size == queue->capacity);
}

// Queue is empty when size is 0 
int isEmpty(Queue* queue)
{
	return (queue->size == 0);
}

// Function to add an item to the queue. 
// It changes rear and size 
void add(Queue* queue, int item)
{
	if (isFull(queue))
		return;
	queue->rear = (queue->rear + 1)
		% queue->capacity;
	queue->array[queue->rear] = item;
	queue->size = queue->size + 1;
}

// Function to remove an item from queue. 
// It changes front and size 
int remove(Queue* queue)
{
	if (isEmpty(queue))
		return INT_MIN;
	int item = queue->array[queue->front];
	queue->front = (queue->front + 1)
		% queue->capacity;
	queue->size = queue->size - 1;
	return item;
}

// Function to get front of queue 
int front(Queue* queue)
{
	if (isEmpty(queue))
		return INT_MIN;
	return queue->array[queue->front];
}

// Function to get rear of queue 
int rear(Queue* queue)
{
	if (isEmpty(queue))
		return INT_MIN;
	return queue->array[queue->rear];
}

// Will take Information from a file, and add it to the Array
void readfromfile(Queue* queue) {
	int count = 1;


	ifstream myfile(newfile);
	if (myfile.is_open()) {

		chrono::high_resolution_clock::time_point t1 = chrono::high_resolution_clock::now();

		while (!myfile.eof()) {
			getline(myfile, line);
		//	remove(queue);
			add(queue, stoi(line));
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

void Display(Queue* queue) {
	int count = 0;
	for (int i = 0; i < queue->capacity - 1; i++) {
		count++;
		cout << "#" << count << ": " <<queue->array[i] << endl;
	}
	/*
	for (int i = queue->size - 1; i >= 0; i--) {
		cout << queue->array[i];
	}
	*/
}

int CountLines(string& fileName)
{
	char newLine = '.';
	int numLines = 0;
	int count = 1;
	string line;

	/* Creating input filestream */
	ifstream file(fileName);
	while (getline(file, line))
		count++;

	return count;
}
// Driver code 
int main()
{
	int Lines = CountLines(newfile);
	cout << Lines << endl; 
	Queue* queue = createQueue(Lines);

	int ch, numb;
	do {
		cout << "1) Insert elements from file" << endl;
		cout << "2) Insert element to queue" << endl;
		cout << "3) Delete element from queue" << endl;
		cout << "4) Display First Element" << endl;
		cout << "5) Display Last Element" << endl;
		cout << "6) Display All" << endl;
		cout << "7) Exit" << endl;
		cout << "Enter your choice : " << endl;
		cin >> ch;
		switch (ch) {
		case 1:
			system("CLS");
			readfromfile(queue);		
			break;
		case 2:

			system("CLS");
			cout << "Enter Number: " << endl;
			cin >> numb;

			system("CLS");
			if (numb != NULL) {
				add(queue, numb);
			}
			else {
				cout << "Empty Number, Can not insert.";
			}
			break;
		case 3:
			system("CLS");
			cout << remove(queue) << " Removed from Queue\n";
			break;
		case 4:
			system("CLS");
			cout << "First item is " << front(queue) << endl;
			break;
		case 5:
			system("CLS");
			cout << "Last item is " << rear(queue) << endl;
			break;
		case 6: 
			Display(queue);
			break;
		case 7: cout << "Exit" << endl;
			break;
		default:
			system("CLS");
			cout << "Invalid choice" << endl;
		}
	} while (ch != 7);



	system("PAUSE");
	return 0;
}

