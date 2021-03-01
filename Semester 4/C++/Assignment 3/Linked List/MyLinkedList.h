#pragma once
#include <string>
#include "LinkedListNode.h"
using namespace std;

class MyLinkedList {
	LinkedListNode* head;
	LinkedListNode* current;
	LinkedListNode* temp;
	LinkedListNode* tail;
	LinkedListNode* next;
	int length;

public:

	MyLinkedList();
	MyLinkedList(int data);

	~MyLinkedList();

	void add(int data);
	void removeval(int data);
	void pop();
	void peek();
	void push(int data);
	void append(int data);
	void search(int data);
	void peek(int data);
	void display();
};

