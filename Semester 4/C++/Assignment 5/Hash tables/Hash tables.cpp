#include <iostream>

const int T_S = 1000;

using namespace std;


struct HashTableEntry {
    int v, k;
    HashTableEntry* n;
    HashTableEntry* p;
    HashTableEntry(int k, int v) {
        this->k = k;
        this->v = v;
        this->n = NULL;
    }
};


class HashMapTable {
public:
    HashTableEntry** ht, ** top;
    HashMapTable() {
        ht = new HashTableEntry * [T_S];
        for (int i = 0; i < T_S; i++)
            ht[i] = NULL;
    }
    int HashFunc(int key) {
        return key % T_S;
    }
    void Insert(int k, int v) {
        int hash_v = HashFunc(k);
        HashTableEntry* p = NULL;
        HashTableEntry* en = ht[hash_v];
        while (en != NULL) {
            p = en;
            en = en->n;
        }
        if (en == NULL) {
            en = new HashTableEntry(k, v);
            if (p == NULL) {
                ht[hash_v] = en;
            }
            else {
                p->n = en;
            }
        }
        else {
            en->v = v;
        }
    }

    void Remove2(int k) {
        int hash_v = HashFunc(k);
        HashTableEntry* en = ht[hash_v];
        HashTableEntry* p = NULL;
        if (en == NULL || en->k != k) {
            cout << "No Element found at key " << k << endl;
            return;
        }
        while (en->n != NULL) {
            p = en;
            en = en->n;
        }
        if (p != NULL) {
            p->n = en->n;
        }
        delete en;
        cout << "Element Deleted" << endl;
    }

    void Remove(int k) {
        int hash_v = HashFunc(k);
        HashTableEntry* en = ht[hash_v];
        HashTableEntry* p = NULL;
        if (en == NULL || en->k != k) {
            cout << "No Element found at key " << k << endl;
            return;
        }
        while (en->n != NULL) {
            p = en;
            en = en->n;
        }
        if (p != NULL) {
            p->n = en->n;
        }
        delete en;
        cout << "Removed Entry";
        cout << endl;
    }

    void SearchKey(int k) {
        int hash_v = HashFunc(k);
        bool flag = false;
        HashTableEntry* en = ht[hash_v];
        if (en != NULL) {
            while (en != NULL) {
                if (en->k == k) {
                    flag = true;
                }
                if (flag) {
                    cout << "Element found at key " << k << ": ";
                    cout << en->v << endl;
                }
                en = en->n;
                
            }
        }
        if (!flag)
            cout << "No Element found at key " << k << endl;
    }


    void EditKey(int k, int value) {
        int hash_v = HashFunc(k);
        bool flag = false;
        HashTableEntry* en = ht[hash_v];
        if (en != NULL) {
          
                if (en->k == k) {
                    flag = true;
                }
                if (flag) {
                    en->v = value;
                    cout << "Key Modified." << endl;
                }
                en = en->n;
        }
        if (!flag)
            cout << "No Element found at key " << k << endl;
    }

    ~HashMapTable() {
        delete[] ht;
    }
};


void ShowMenu();


int main() {
    HashMapTable hash;

    int k, v;
    int c;

    while (1) {
        ShowMenu();
        cout << "Please Enter a Option:" << endl;
        cin >> c;
        system("cls");


        switch (c) {


            // Create new Entry in Hash Table
            case 1:
                cout << "Enter Client ID #?: ";
                cin >> k;
                cout << "What Value?: ";
                cin >> v;
                hash.Insert(k, v);
                system("cls");
            break;


            // Search for a specific Key
            case 2:
                cout << "Enter Key Value to search for: ";
                cin >> k;
                system("cls");
                hash.SearchKey(k);
                cout << endl;
            break;


            // Remove Entry
            case 3:

                cout << "Remove what key Entry? ";
                cin >> k;
                hash.Remove(k);
                system("cls");

            break;


            // Edit Entry
            case 4:

                cout << "Enter Key Entry #: ";
                cin >> k;
                cout << "Enter New Value: ";
                cin >> v;

                system("cls");
                hash.EditKey(k, v);

            break;



            // Quit
            case 5:

                exit(1);
            break;

            default:
                cout << "Invalid Entry, Please try again." << endl;
            break;
        }


    }

    return 0;
}


void ShowMenu() {
    cout << "Main Menu" << endl;
    cout << "=====================================" << endl;
    cout << "#1 - Add New Entry" << endl;
    cout << "#2 - Search Entry " << endl;
    cout << "#3 - Remove Entry" << endl;
    cout << "#4 - Edit Entry" << endl;
    cout << "#5 - Exit Program." << endl;


}