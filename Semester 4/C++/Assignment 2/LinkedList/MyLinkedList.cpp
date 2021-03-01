
#include "MyLinkedList.h"
#include "LinkedListNode.h"
#include <iostream>

using namespace std;


// Size of linked list
int size = 0;

LinkedListNode::LinkedListNode(int nodeData)
{
	this->data = nodeData;
	this->next = NULL;
}

LinkedListNode::LinkedListNode(int nodeData, LinkedListNode* prevNode)
{
	this->data = nodeData;
	this->next = NULL;
	prevNode->next = this;
}


MyLinkedList::MyLinkedList()
{
	this->head = NULL;
	this->current = NULL;
	this->temp = NULL;
	this->tail = NULL;
	this->length = 0;
}

MyLinkedList::MyLinkedList(int data)
{
	this->append(data);
}

MyLinkedList::~MyLinkedList(){}

void MyLinkedList::append(int NodeData)
{
	if (head == NULL)
	{
		this->add(NodeData);
	}
	else
	{
		LinkedListNode* newNode = new LinkedListNode(NodeData, this->tail);
		this->tail = newNode;
		this->length++;
	}

}

void MyLinkedList::add(int NodeData)
{
	if (head == NULL)
	{
		LinkedListNode* linkedNode = new LinkedListNode(NodeData);
		this->head = linkedNode;
		this->tail = linkedNode;
	}
	else
	{
		LinkedListNode* newNode = new LinkedListNode(NodeData);
		newNode->next = this->head;
		this->head = newNode;
	}
	this->length++;
}

void MyLinkedList::removeval(int remValue) {

	LinkedListNode* curNode = NULL;
	current = head;
	temp = head;

	while (current != NULL && current->data != remValue) {
		temp = current;
		current = current->next;
	}
	if (current == NULL) {
		cout << "Data not present\n" << endl;
	}
	else {
		if (current == head) {
			current = current->next;
			head = current;
		}
		else {
			curNode = current;
			current = current->next;
			temp->next = current;
		}

		cout << "Removed Value.\n" << endl;
	}


}

void MyLinkedList::removepos(int remValue) {
	int counter = 0;
	LinkedListNode* curNode = NULL;
	current = head;
	temp = head;

	while (current != NULL && counter != remValue) {
		temp = current;
		current = current->next;
		counter++;
	}


	if (current == NULL) {
		cout << "Data not present\n" << endl;
	}
	else {
		if (current == head) {
			current = current->next;
			head = current;
		}
		else {
			curNode = current;
			current = current->next;
			temp->next = current;
		}
	}


}



void MyLinkedList::insert(int data, int pos)
{
	LinkedListNode* node = new LinkedListNode(data);
	node->data = data;
	node->next = NULL;

	if (this->head == NULL) {
		if (pos != 0) {
			return;
		}
		else { 
			this->head = node;
		}
	}

	if (head != NULL && pos == 0) {
		node->next = this->head;
		this->head = node;
		return;
	}

	LinkedListNode* current = this->head;
	LinkedListNode* previous = NULL;

	int i = 0;

	while (i < pos) {
		previous = current;
		current = current->next;

		if (current == NULL) {
			break;
		}

		i++;
	}

	node->next = current;
	previous->next = node;
}


void MyLinkedList::search(int data) {

	if (head != NULL)
	{
		int count = 0, pos = 0;
		bool found = false;
		
		LinkedListNode* curNode = head;
		while (curNode != NULL)
		{
			if (curNode->data == data) {
				found = true;
				pos = count;
				break;
			}

			curNode = curNode->next;

			count++;
		}
		if (found == true) {

			cout << "Found Value: " << data << " at position: " << count << "\n";
		}
		else {

			cout << "Value not found.";
		}
	}
	else
	{
		cout << "No Elements";
	}


}

void MyLinkedList::display()
{
	int count = 0;
	if (head != NULL)
	{
		LinkedListNode* curNode = head;
		while (curNode != NULL)
		{
			cout << "(" << count << ") " << curNode->data << endl;
			curNode = curNode->next;
			count++;
		}
	}
	else
	{
		cout << "No Elements";
	}

}

