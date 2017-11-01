#include <iostream>
#include "punkt.h"
#include "kolo.h"
#include "kula.h"
#include <windows.h>
#include <string>

using namespace std;

int main()
{

    Kula ku1;
    ku1.wczytaj();
    ku1.wyswietl();



    system ("pause");
    return 0;
}
