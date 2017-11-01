#include "kolo.h"
#include "punkt.h"
#include <math.h>
#include <string>

Kolo::Kolo(string np,string nk,float xx,float yy ,float pr)
:Punkt(np,xx,yy)
{
  nazwa=nk;
  r=pr;
}

void Kolo::wczytaj()
{
    cout<<"Podaj nazwe kola: ";
    cin>>nazwa;
    cout<<endl<<"Podaj promien kola: ";
    cin>>r;
    cout<<endl;

}
void Kolo::wyswietl()
{
    cout<<"Srodek kola: ";
    Punkt::wyswietl();
    cout<<endl;
    cout<<"Promien kola: "<<r<<endl;
    cout<<"Pole kola: "<<M_PI*r*r<<endl;
}

//Kolo::~Kolo()
//{
//    //dtor
//}
