#include <iostream>
#include <windows.h>
#include <cstdlib>
#include <string>

using namespace std;

int main()
{
    int dlugosc;
    string imie;
    cout<<"Podaj imie: "<<endl;
    cin>>imie;
    dlugosc=imie.length();
    string wspak;
    for(int i=dlugosc-1;i>=0;i--)
    {wspak=imie[i];
    cout<<wspak;}


    system("pause");
}
