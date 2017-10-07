#include <iostream>
#include <windows.h>
#include <cstdlib>
#include <string>
#include <algorithm>
using namespace std;

int main()
{
    string napis="Ala ma kota";
    string szukaj="Ala";

    size_t pozycja=napis.find(szukaj);
    if (pozycja!=string::npos)
        cout<<"znaleziono na pozycji "<<pozycja<<endl;
    else
        cout<<"nie znaleziono"<<pozycja<<endl;
       return 0;
    system("pause");
}
