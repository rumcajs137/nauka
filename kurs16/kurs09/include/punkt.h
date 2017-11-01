#ifndef PUNKT_H
#define PUNKT_H
#include <iostream>
#include <string>

using namespace std;

class Punkt
{
    protected:
    string nazwa;
    float x,y;
public:
    Punkt (string="brak",float=0, float=0);
    void wczytaj();
    void wyswietl();
};

#endif // PUNKT_H
