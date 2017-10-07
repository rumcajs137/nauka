#include <iostream>
#include <windows.h>
#include <cstdlib>
#include <string>
#include <algorithm>

using namespace std;

int main()
{
   string napis="Ala ma Kota";
   napis.erase(0,3);
   napis.insert(0,"Mysza");
   cout<<napis<<endl;
   napis.replace(6,2,"na zawsze ma");
   cout<<napis<<endl;
   string nowynapis=napis.substr(0,5);
   cout<<nowynapis<<endl;


    system("pause");
}
