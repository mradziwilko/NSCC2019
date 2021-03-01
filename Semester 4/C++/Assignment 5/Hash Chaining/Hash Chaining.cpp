#include <iostream>
#include <list> 
#include <iterator> 
using namespace std;

class Hash
{
    int Cont;
    list<int>* table;
public:
    Hash(int V); 
    void addItem(int x);
    void deleteItem(int key);
    void searchItem(int key);
    void editItem(int key, int newKey);
    int hashFunction(int x) {
        return (x % Cont);
    }
    void displayHash();
};

Hash::Hash(int b)
{
    this->Cont = b;
    table = new list<int>[Cont];
}

void Hash::addItem(int key)
{


    int index = hashFunction(key);
    bool found = false;
    list <int> ::iterator i;
    for (i = table[index].begin();
        i != table[index].end(); i++) {
        if (*i == key) {
            found = true;
            break;
        }
        else {

        }
    }
    if (i != table[index].end()) {
    }

    if (found == false) {

        int index = hashFunction(key);
        table[index].push_back(key);
        cout << "Added Entry " << key << " at position #" << index << endl;
    }
    else {
        cout << "Error Key Found at position " << index << " Unable to Add to List." <<endl;
    }
}
void Hash::deleteItem(int key)
{
    int index = hashFunction(key);
    list <int> ::iterator i;
    for (i = table[index].begin();
        i != table[index].end(); i++) {
        if (*i == key)
            break;
    }
    if (i != table[index].end())
        table[index].erase(i);

}
void Hash::searchItem(int key)
{
    int index = hashFunction(key);
    bool found = false;
    list <int> ::iterator i;
    for (i = table[index].begin();
        i != table[index].end(); i++) {
        if (*i == key) {
            found = true;
            break;
        }
        else {

        }
    }
    if (i != table[index].end()) {
    }

    if (found == false) {
        cout << "No Hash Found" << endl;
    }
    else {
        cout << "Key Found: " << key << " at position " << index << endl;
    }
}


void Hash::editItem(int key, int newKey)
{

    int index = hashFunction(key);
    bool found = false;
    list <int> ::iterator i;
    for (i = table[index].begin();
        i != table[index].end(); i++) {
        if (*i == key) {
            found = true;
            break;
        }
    }
    if (i != table[index].end()) {}

    if (found == false) {
        cout << "No Hash Found" << endl;

    }
    else {
        table[index].erase(i);
        table[index].push_back(newKey);
        cout << "Edited Value " << key << " with new value " << newKey << endl;
    }

}


void Hash::displayHash() {
    for (int i = 0; i < Cont; i++) {
        
        for (auto x : table[i])
            cout << " --> " << x;
        cout << endl;
    }
}

void ShowMenu();

int main()
{


    int k, v, c, d;

    cout << "How Many Hash values to Allow? " << endl;
    cin >> d;

    Hash numbHash(d);  

    
    while (1) {
        ShowMenu();
        cout << "Please Enter a Option:" << endl;
        cin >> c;
        system("cls");
        switch (c) {
        case 1:
            cout << "Enter a Value: ";
            cin >> v;
            system("cls");
            numbHash.addItem(v);
            break;
        case 2:
            cout << "Enter Key Value to search for: ";
            cin >> k;
            system("cls");
            numbHash.searchItem(k);
            cout << endl;
            break;


            // Remove Entry
        case 3:

            cout << "Remove what key Entry? ";
            cin >> k;
            numbHash.deleteItem(k);
            system("cls");
            cout << "Entry " << v << " Removed" << endl;
            break;


            // Edit Entry
        case 4:
            cout << "What key to edit? ";
            cin >> v;
            cout << "Replace with? ";
            cin >> k;
            system("cls");
            numbHash.editItem(v, k);

            break;



            // Quit
        case 5:

            numbHash.displayHash();

            break;
            // Quit
        case 6:

            exit(1);
            break;

        default:
            cout << "Invalid Entry, Please try again." << endl;
            break;
        }


    }








    system("pause");
    return 0;
}




void ShowMenu() {
    cout << "Main Menu" << endl;
    cout << "=====================================" << endl;
    cout << "#1 - Add New Hash" << endl;
    cout << "#2 - Search Hash" << endl;
    cout << "#3 - Remove Hash" << endl;
    cout << "#4 - Edit Hash" << endl;
    cout << "#5 - Display Hash" << endl;
    cout << "#6 - Exit Program." << endl;


}