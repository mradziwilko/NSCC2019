/*
-------------------------------------------------------------------------------------
Program: project.c
Date: 11/19/2020
Autor: Marshall Radziwilko
Program Details:

Blackjack Game

Create a command-line blackjack game using OOP principles and the following criteria:

-Player is prompted for first name

-Use an array to represent the 52 cards (values 1-52). Store as attribute within card class

-When the game starts, randomize entries in card array, calculate the user's current score (cards 0,1 in array) and the house score 
(cards 2,3 in array) and display. Prompt the user to hit or stay

-Each time the player indicates "hit", a new card value is added to their score (the next value from the array) and displayed.

-If the player score exceeds 21, the player loses (remember the ace can be a 1 OR 11 => value is 11 while the score <= 21 and 
downward adjusted when a value of 11 would exceed 21).

-When the "stay" option is indicated, the "house" starts drawing cards from the array from where the player left off. After 
each card is drawn, the house score is adjusted and checked. Card are continually drawn until the house score is equal or 
greater to the player score.

-If the house score is > 21, the house busts and the player is awarded 50pts.

-If the player busts or the house score is >= player score (without busting), 50pts is deducted from the player score.

-At the end of the hand, the player may continue or quit

-Class member functions are used to calculate the score.

-------------------------------------------------------------------------------------
                                        Commits
-------------------------------------------------------------------------------------
|       Date        |        Programmer        |                Changelog           | 
|   2020-11-19      |   Marshall Radziwilko    |           Blackjack Version 1      |
-------------------------------------------------------------------------------------
*/

#include <iostream>
#include <algorithm>
#include <vector>
#include <random>
#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include "card.cpp"
#include "player.cpp"

using namespace std;

    // Vectors and Objects and Variables
    vector<Card> CardVect;
    string PlrName;
    vector<int> PlrCards, DlrCards;
    Player plr;
    Card crds;
    int choice;
    int CurrCard, cardgive, plrTotal, dlrTotal;

    // Main Calls
    void showMainMenu();
    void exitProgram();
    void cls();
    int getRandomCardNumber();
    void newGame();
    void showGameMenu();
    int getCardValue();
    void CountScore();
    void setNewGame();
    void PlayLose();
    void PlayWin();
    void PlayDisplayCardsLose();
    void DisplayVector();
    void CalcTotal();
    void DisplayCards();
    int AddDealerCard();
    int AddPlayerCard();
    string GetCardFace();
    int GetCardValue();
    string GetCardType();
    int GetCard();
    int myrandom ();


// New Game set, clears prior cards dealer cards, remixes the cards, set variables back to 0.
void setNewGame() {
    
        PlrCards.clear();
        DlrCards.clear();
        crds.MixCards();
        CurrCard = 0;
        cardgive = 0;
        plrTotal = 0;
        dlrTotal = 0;
}



int main() {  

    // Main Player Vectors
    plr = Player();
    crds = Card();

    // Set Player name if set.
    PlrName = plr.getName();

    // set current card 0
    CurrCard = 0;

    // clear screen
    cls();

    // Add Cards to Vector.
    for(int i=1; i<=52; i++) {
        crds.addCard(i);        
    }


    


    // if no name is set, ask for new name.
    do{

        cout << "Please enter your name: ";
        cin >> PlrName;


    }while(PlrName.empty());


    // Clear screen
    cls();
    // Make sure new game is set

    setNewGame();

    // Set Player name into Player Object
    plr.setName(PlrName);

    choice = 0;
    // Main Menu
    while (choice != 10000)
    {

    cls();
        showMainMenu();
        cin >> choice;
        switch(choice) {
             case 1: newGame(); break;
             case 2:  exitProgram(); break;             
            default: system("CLS"); cout << "\nError. Choice not found." << endl;
        }
    }
    
    
    return 0;
}

// Clears Console window Simple function.
void cls() {
    system("CLS");
}

// Main Menu
void showMainMenu() {

    int PlrOAScore = plr.getScore();

    if(PlrOAScore == NULL) {
        
    cout << "Current Overall Score: 0" << endl << endl;
    } else{
    cout << "Current Overall Score: " << PlrOAScore << endl << endl;
    }
    // Fixed Darrens Number Mixup after removing couple entries and spelled "Calculate" properly
        cout << PlrName  << ", Please  choose an option:" << endl;
        puts("1. New game");
        puts("2. Exit");
}

// Game Menu
void showGameMenu() {
        //DisplayVector(pCards);
        cout << endl << PlrName  << ", Would you like to:" << endl;
        puts("H. Hit");
        puts("S. Stand");
}

// Exit Program
void exitProgram() {
    exit( 3 );
}

// Get new Card in Deck. Increase counter to select next one in Deck.
int GetCard() {
    int randcard = crds.getCard(CurrCard);
    CurrCard++;
    return randcard;
}

// Get if card is a Ace, Jack, Queen, King.
string GetCardType(int id) {
    int newid;
    string newFace;
    if(id >= 1 && id <= 13) {
        // HEARTS
        newid = id;
    }else if(id >= 14 && id <= 26) {

        newid = id - 14;


    }else if(id >= 27 && id <= 39) {

        newid = id - 26;
    }else if(id >= 40 && id <= 52) {

        newid = id - 39;
    }


    if(newid == 1) {

        newFace = "A";
    }else if(newid == 2) {
        newFace = "2";
    }else if(newid == 3) {
        newFace = "3";
    }else if(newid == 4) {
        newFace = "4";
    }else if(newid == 5) {
        newFace = "5";
    }else if(newid == 6) {
        newFace = "6";
    }else if(newid == 7) {
        newFace = "7";
    }else if(newid == 8) {
        newFace = "8";
    }else if(newid == 9) {
        newFace = "9";
    }else if(newid == 10) {
        newFace = "10";
    }else if(newid == 11) {
        newFace = "J";
    }else if(newid == 12) {
        newFace = "Q";
    }else if(newid == 13) {
        newFace = "K";

    }


    return newFace;
}

// Get Value of card
int GetCardValue(int id) {
    int newid;
    int value;
    if(id >= 1 && id <= 13) {
        newid = id;
    }else if(id >= 14 && id <= 26) {
        newid = id - 14;
    }else if(id >= 27 && id <= 39) {
        newid = id - 26;
    }else if(id >= 40 && id <= 52) {
        newid = id - 39;
    }

    if(newid == 1) {
        value = 1;
    }else if(newid == 2) {
        value = 2;
    }else if(newid == 3) {
        value = 3;
    }else if(newid == 4) {
        value = 4;
    }else if(newid == 5) {
        value = 5;
    }else if(newid == 6) {
        value = 6;
    }else if(newid == 7) {
        value = 7;
    }else if(newid == 8) {
        value = 8;
    }else if(newid == 9) {
        value = 9;
    }else if(newid == 10) {
        value = 10;
    }else if(newid == 11) {
        value = 10;
    }else if(newid == 12) {
        value = 10;
    }else if(newid == 13) {
        value = 10;

    }
    return value;
}


// Get if it is a Hearts, Diamonds, Clubs or Spaid
string GetCardFace(int id) {

    string FaceCard;    
    if(id >= 1 && id <= 13) {
    
    FaceCard = "\3";
    }else if(id >= 14 && id <= 26) {

    FaceCard = "\4";
    }else if(id >= 27 && id <= 39) {

    FaceCard = "\5";
    }else if(id >= 40 && id <= 52) {

    FaceCard = "\6";
    }


    return FaceCard;
}

// Add Player to Card
int AddPlayerCard() {

    cardgive = GetCard();
    PlrCards.insert(PlrCards.end(), cardgive);    

    return cardgive;
}

// Add Card to Dealer
int AddDealerCard() {

    cardgive = GetCard();
    DlrCards.insert(DlrCards.end(), cardgive);    
    return cardgive;
}

// this function is called everytime a new card is added, goes though all cards, gets values adds to total.
int CalcTotal(vector<int> cards) {
    int total;
    int elemid;

    for(auto element = cards.cbegin(); element != cards.cend(); ++element)
    {
        elemid = *element;
        if(elemid == 1 || elemid == 14 || elemid == 27 || elemid == 40) {
            if(plrTotal >= 10) {
                total += 1;
            } else {
                total +=11;
            }
        }else{
            total += GetCardValue(elemid);
        }

    }

    return total;
}


// Display what Cards in what hands to show easy display cards function.
void DisplayCards(vector<int> pCards, string Plr) {
    std::cout << Plr << " Cards: ";
    for(auto element = pCards.cbegin(); element != pCards.cend(); ++element)
    {
 
        cout << " " << GetCardType(*element)  << GetCardFace(*element);
   
    }

    std::cout << endl << Plr << " Total: " << CalcTotal(pCards);
       
    std::cout << endl;
}


// This is for testing, to see in cards who has what in ID's not used in game. just for testing.
void DisplayVector(const vector<int> inVec)
{
    for(auto element = inVec.cbegin(); element != inVec.cend(); ++element)
    {
        cout << *element << " ";
    }
    cout << endl;
}


// After Player does Stay, this function then lets the dealer play, if Dealer card total is below or equal to player he will keep playing.
// it also returns if dealer busts.

int DlrPlay() {

    int PlayerTotal = CalcTotal(PlrCards);
    int DealerTotal = CalcTotal(DlrCards);
    string dOpt = "";
    while(dOpt  != "E") {

        if(DealerTotal >= PlayerTotal) {
           
           if(DealerTotal == PlayerTotal) {
                return 1; // TIE

           }else if(DealerTotal > 21) {               
                return 3; // Dealer Busts

           }else if(DealerTotal > PlayerTotal && DealerTotal <= 21){
               
                return 2;

           }else{
                return 0;

           }
        }else if(DealerTotal > 21) {

            // DEALER BUST
                return 3;
                break;
        }else{
            cls();
        AddDealerCard();
        DealerTotal = CalcTotal(DlrCards);
        DisplayCards(DlrCards, "Dealer");

        }

    }


}


// Player wins.
void PlayWin() {
    
                plr.setScore( plr.getScore() + 50);
}


// Dealer Wins.
void PlayLose() {    
                plr.setScore( plr.getScore() - 50);
}


// Main new game function, adds 2 cards at start, then asks player what he wants to do, if player stays, dealer goes.
void newGame(){ 
    int gamestatus = 0;
    cls();
    int currCard, dlrCard;
    dlrCard = AddDealerCard();
    dlrCard = AddDealerCard();
    dlrTotal = CalcTotal(DlrCards);
    //DisplayCards(DlrCards, "Dealer");
    currCard = AddPlayerCard();
    currCard = AddPlayerCard();
    DisplayCards(PlrCards, "Player");


    string Option;

    while(Option != "E") {

        showGameMenu();
        cin >> Option;
        cout << endl;
        
        if(Option == "H" || Option == "h" ) {    
            cls();
            currCard = AddPlayerCard();
            DisplayCards(PlrCards, "Player");
            plrTotal = CalcTotal(PlrCards);

            if(plrTotal > 21) {
                int keyEnd;
                cls();
                    DisplayCards(PlrCards, "Player");
                    cout << endl;            
                    DisplayCards(DlrCards, "Dealer");
                    cout << endl;
                cout << "BUSTED! Player Loses." << endl;
                system("pause");
                setNewGame();
                PlayLose();
                Option = "E";
                break;
            }


        }else if(Option == "S" || Option == "s" ) {
            int Dlrply = DlrPlay();

                if(Dlrply == 0) {
                    cls();                    
                    DisplayCards(PlrCards, "Player");
                    cout << endl;            
                    DisplayCards(DlrCards, "Dealer");
                    cout << endl;
                    // Player Win
                    cout << "Player WINS!." << endl;
                    PlayWin();
                }else if(Dlrply == 1) {
                    cls();
                    DisplayCards(PlrCards, "Player");
                    cout << endl;            
                    DisplayCards(DlrCards, "Dealer");
                    cout << endl;
                    cout << "Game Tie, No Winner." << endl;
                    // Game Tie
                } else if(Dlrply == 2) {
                cls();
                    DisplayCards(PlrCards, "Player"); 
                    cout << endl;           
                    DisplayCards(DlrCards, "Dealer");
                    cout << endl;
                    cout << "Player Loses, Dealer Wins." << endl;
                    // Dealer Win
                    PlayLose();
                }else if( Dlrply == 3) {
                    cls();
                    DisplayCards(PlrCards, "Player");            
                    cout << endl;
                    DisplayCards(DlrCards, "Dealer");
                    cout << endl;
                    cout << "Player Wins! Dealer Busted." << endl;
                    // Player win
                    PlayWin();

                }
                setNewGame();
                system("pause");
            break;
        }else{
            cout << "Invalid Option." << endl;
        }

    }
    

}


int myrandom (int i) { return rand()%i;}