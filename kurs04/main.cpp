#include <iostream>
#include <windows.h>
#include <cstdlib>

using namespace std;

int main()
{
    cout<<"Identyfikator plci v2.0"<<endl;
    string imie;
    int dlugosc;
    cout<<"podaj imie: "<<endl;
    cin>>imie;
    dlugosc=imie.length()-1;
//    cout<<dlugosc+1<<endl;

    if ((imie[dlugosc]=='a')&& (imie!="kuba"))

            cout<<"jest to kobieta"<<endl;
    else

    cout<<"jest to facet"<<endl;


return 0;
system("pause");
}
