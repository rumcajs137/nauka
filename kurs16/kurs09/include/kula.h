#ifndef KULA_H
#define KULA_H
#include "kolo.h"
#include <iostream>
#include <string>

using namespace std;

class Kula :public Kolo
{
    protected:
    string nazwa;
public:
    Kula(string="brak",string="brak",string="brak",float=0,float=0,float=5);
    void wczytaj();
    void wyswietl();
};

#endif // KULA_H
