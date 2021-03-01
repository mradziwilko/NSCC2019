#include "movie.h"
// Namespace
using namespace  std;


    // Constructors:
    movie::movie() {
        name = "";
        director = "";
        year = 0;
        rating = 0;
        price = 0;
        views = 0;
        renter = 0;
        dueDate = "";
    }

    movie::movie(string n, string d, int y, float ra, float p, int v, int re, string dd) {
        name = n;
        director = d;
        year = y;
        rating = ra;
        price = p;
        views = v;
        renter = re;
        dueDate = dd;
    }
    
    // Destructor:
    movie::~movie(){}  
    

    // Setters
    void movie::setName(string n){
        name = n;
    }
    
    void movie::setDirector(string d){
        director = d;
    }
    
    void movie::setYear(int y){
        year = y;
    }
    
    void movie::setRating(float r){
        rating = r;
    }

    void movie::setPrice(float p){
        price = p;
    }

    void movie::setViews(int v){
        views = v;
    }

    void movie::setRenter(int r){
        renter = r;
    }

    void movie::setDueDate(string dd){
        dueDate = dd;
    }


    // Getters
    string movie::getName(){
        return name;
    }

    string movie::getDirector(){
        return director;
    }

    int movie::getYear(){
        return year;
    }

    float movie::getRating(){
        return rating;
    }

    float movie::getPrice(){
        return price;
    }

    int movie::getViews(){
        return views;
    }

    int movie::getRenter(){
        return renter;
    }

    string movie::getDueDate(){
        return dueDate;
    }




    
    void movie::Display() {
            cout << "Movie Name: " << name << endl;
            cout << "Director: " << director << endl;
            cout << "Year: " << year << endl;
            cout << "Rating: " << rating << endl; 
            cout << "Price: " << price << endl;
            cout << "# of Views: " << views << endl;
            cout << "Renter: " << renter << endl;
            cout << "Due Date: " << dueDate << endl;
    }