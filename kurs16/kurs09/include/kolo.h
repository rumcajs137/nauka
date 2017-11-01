#ifndef KOLO_H
#define KOLO_H
#include "punkt.h"
#include <iostream>
#include <string>

using namespace std;

class Kolo : public Punkt
{
    protected:
    string nazwa;

    float r;
public:
    Kolo(string="brak", string="brak",float=0, float=0, float=1);
    void wczytaj();
    void wyswietl();
};

#endif // KOLO_H
