#pragma once
#include <string>
using namespace std;



class  LinkedListNode {
	int data;
	LinkedListNode* next;


public:
	LinkedListNode(int nodeData);
	LinkedListNode(int nodeData, LinkedListNode* prevNode);
	friend class MyLinkedList;
};