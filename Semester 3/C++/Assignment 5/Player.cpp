#include "Player.h"


using namespace std;



        Player::Player(){
                name = "";
                score = 0;
        };
        Player::Player(string val, int val2){
                name = val;
                score = val2;
        };
        Player::~Player(){};

        void Player::setName(string temp){ name = temp; };
        void Player::setScore(int temp){ score = temp; };
        
        string Player::getName(){ return name; };
        int Player::getScore(){ return score;};

