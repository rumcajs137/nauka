#include "punkt.h"
#include <iostream>
#include <string>

using namespace std;


Punkt::Punkt(string np, float xx, float yy)
{
    nazwa=np;
    x=xx;
    y=yy;
}
void Punkt::wczytaj()
{
    cout<<"Podaj nazwe punktu: ";
    cin>>nazwa;
    cout<<endl;
    cout<<"Podaj wspolrzedne punktu: "<<endl<<"x: ";
    cin>>x;
    cout<<"y: ";
    cin>>y;
}
void Punkt::wyswietl()
{
    cout<<nazwa<<" "<<"x: "<<x<<" "<<"y: "<<y<<endl;
}
//Punkt::~Punkt()
//{
//    //dtor
//}
