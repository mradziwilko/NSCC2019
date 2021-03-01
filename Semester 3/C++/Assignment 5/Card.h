#include <iostream>
#include <algorithm>
#include <vector>
#include <random>
#include <stdio.h>
#include <stdlib.h>
#include <time.h>


using namespace std;


class Card {

    private:
        int cardnumb;
       

    protected:
        vector<int> cards;


    public:
        Card();
        Card(int f);
        ~Card();

        void setCard(int temp);

        int getCard(int id);    
        void addCard(int card);
        void DisplayVector();
        void MixCards();

};

