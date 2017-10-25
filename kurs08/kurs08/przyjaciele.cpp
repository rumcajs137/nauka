#include <iostream>
#include <string>
#include "przyjaciele.h"

using namespace std;

Punkt::Punkt(string n, float xx, float yy)
{
	nazwa=n;
	x = xx; y = yy;
	}
void Punkt::wczytaj()
{
	cout << "Podaj x: "; cin >> x;
	cout << "Podaj y: "; cin >> y;
	cout << "Nazwa punktu: "; cin >> nazwa;

}
