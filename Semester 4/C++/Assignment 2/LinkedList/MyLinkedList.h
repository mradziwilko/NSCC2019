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
	void removepos(int pos);
	void insert(int data, int position);
	void append(int data);
	void search(int data);
	void display();
};

