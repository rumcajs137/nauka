#include <iostream>
#include <string>
#include <windows.h>

using namespace std;
//-----------------------------------

class Samochod
{
public:
    string marka, nazwa;
    int rocznik,przebieg,moc;

    //-----------------------------------
    void podaj_dane()
    {
        cout<<"WPROWADZ NOWY SAMOCHOD"<<endl;
        cout<<"Podaj marke: "<<endl;
        cin>>marka;
        cout<<"Podaj nazwe: "<<endl;
        cin>>nazwa;
        cout<< "Podaj rocznik: "<<endl;
        cin>> rocznik;
        cout<<"Podaj przebieg: "<<endl;
        cin>>przebieg;
        cout<<"Jaka jest moc silnika w KM: "<<endl;
        cin>>moc;
    }
    //-----------------------------------
    void wypisz_dane()
    {
        SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE),14);
        cout<<"Marka samochodu "<<marka<<endl;
        cout<<"Nazwa samochodu "<<nazwa<<endl;
        cout<<"Rocznik samochodu "<<rocznik<<endl;
        cout<<"Przebieg samochodu "<<przebieg<<endl;
        cout<<"Moc silnika - "<<moc<<endl;
        SetConsoleTextAttribute(GetStdHandle(STD_OUTPUT_HANDLE),15);
    }

};
//-----------------------------------

int main()
{
    Samochod s1;
    Samochod s2;
    s1.podaj_dane();
    s1.wypisz_dane();
    s2.podaj_dane();
    s2.wypisz_dane();

    system("pause");
    return 0;
}
