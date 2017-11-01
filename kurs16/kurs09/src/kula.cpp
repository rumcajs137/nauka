#include "kula.h"
#include <iostream>
#include <string.>
#include <math.h>

using namespace std;

Kula::Kula(string np,string nk,string nku,float xx, float yy, float pr)
:Kolo(np,nk,xx,yy,pr)
{
nazwa=nku;
}

void Kula::wczytaj()
{
    cout<<"Podaj nazwe kuli: ";
    cin>>nazwa;
    cout<<endl;
}
void Kula::wyswietl()
{
    cout<<"Objetosc kuli wynosi: "<<(4/3)*M_PI*pow(r,3)<<endl;
}


//Kula::~Kula()
//{
//    //dtor
//}
