#include <iostream>
using namespace std;

class movie {

    private:
        string name;
        string director;
        int year;
        float rating;
        float price;
        int views;
        int renter;
        string dueDate;


    public:

        // Constructors:
        movie();
        movie(string n, string d, int y, float ra, float p, int v, int re, string dd);
        // Destructor:
        ~movie();     

        // Setters
        void setName(string n);
        void setDirector(string d);
        void setYear(int y);
        void setRating(float ra);
        void setPrice(float p);
        void setViews(int v);
        void setRenter(int re);
        void setDueDate(string dd);

        // Getters
        string getName();
        string getDirector();
        int getYear();
        float getRating();
        float getPrice();
        int getViews();
        int getRenter();
        string getDueDate();
        
        void Display();
};