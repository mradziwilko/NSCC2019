#include "card.h"

using namespace std;

Card::Card() {}

Card::Card(int a) {}

Card::~Card(){}

void Card::setCard(int temp){
    cardnumb = temp;
};

int Card::getCard(int id){
    return cards[id];
};

void Card::addCard(int card) {
    cards.insert(cards.end(), card);            
}

void Card::DisplayVector()
{
    for(auto element = cards.cbegin(); element != cards.cend(); ++element)
    {
        cout << *element << " ";
    }
    cout << endl;
}




void Card::MixCards() {
    srand(static_cast<unsigned int>(time(nullptr)));

     random_shuffle ( cards.begin(), cards.end());
}