#include <iostream>
#include <vector>


using namespace std;

class Player {

    private:
        string name;
        int score;

    public:
        Player();
        Player(string val, int val2);
        ~Player();

        void setName(string temp);
        void setScore(int temp);
        
        string getName();
        int getScore();


};