#include <iostream>
#include <string>
#include "przyjaciele.h"
#include <windows.h>
using namespace std;
void sedzia(Punkt &pkt,Prostokat &p)
{
    if((pkt.x>=p.x)&&(pkt.x<=p.x+p.szerokosc)&&(pkt.y>=p.y)&&(pkt.y<=p.y+p.wysokosc))
        cout<<endl<<"Punkt "<<pkt.nazwa<<" nalezy do prostokata: "<<p.nazwa<<endl;
    else cout<<"Punkt "<<pkt.nazwa<<" lezy poza prostokatem"<<endl;
}

int main()
{
    Punkt pkt1;
    pkt1.wczytaj();
    Prostokat p1;
    p1.wczytaj();
    sedzia(pkt1,p1);


    system("pause");
    return 0;
}
