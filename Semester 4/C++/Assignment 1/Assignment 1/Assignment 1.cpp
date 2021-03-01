#include <iostream>
#include <fstream>
#include <string>


using namespace std;

int singlearr[5];
int MDArray[3][2] = { {0,1}, {2,3}, {4,5} };
int jagged0[4] = { 1, 2, 3, 4 };
int jagged1[2] = { 5, 6 };

int* JaggedArr[2] = { jagged0, jagged1 };


int Size[2] = { 4, 2 };

int i, result = 0, k = 0;
short loop;
short loop2;
string line;

unsigned int arr_length = 0;


void readfromfile(string TxtFile) {

    ifstream myfile(TxtFile);
            if (myfile.is_open()) {
            while (!myfile.eof()) {
                getline(myfile, line);
                if (arr_length < 5) {
                    singlearr[arr_length++] = stoi(line);
                }
            }
            myfile.close();
        }
        else {
            cout << "Unable to open file";
        }
}

int main()
{
    // Get Numbers from a File, read them, and insert them into the SingleArr Array.
    readfromfile("numbers.txt");


    cout << "Single Dimentional Array \n";
    cout << "======================== \n";
    for (i = 0; i < 5; i++){
        cout << "Single Array Number: " << singlearr[i] << "\n";
    }

    cout << "\n\nMultidimentional Array \n";
    cout << "======================== \n";

    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            cout << "Multidimentional Array Number at  [" << i << "][" << j << "]:" << MDArray[i][j] << endl;
        }
    }


    cout << "\n\nJagged Array \n";
    cout << "======================== \n";


    for (int i = 0; i < 2; i++) {

        int* ptr = JaggedArr[i];

        for (int j = 0; j < Size[k]; j++) {
            printf("Jagged Array Number: %d\n", *ptr);
            ptr++;
        }
        k++;

        JaggedArr[i]++;
    }
    cout << "Press any key to continue";
    cin.get();
    
    return 0;
}