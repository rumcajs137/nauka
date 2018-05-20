#include <iostream>
#include <string>
#include <fstream>
#include <regex>
#include <sstream>
#include <conio.h>

using namespace std;

void exit(void)
{
	_getch();
	exit(1);
}

int main()
{
	string swzorzec;
	regex wzorzec;
	string in;
	ifstream inf;
	cout << "Witam\n";
	cout << "Podaj wzorzec:";
	getline(cin, swzorzec);
	try
	{
		wzorzec = swzorzec;
		cout << "Wzorzec: " << swzorzec << endl;
	}
	catch (...)
	{
		cerr << endl << swzorzec << " nie jest poprawnym wzorcem";
		exit();
	}
	cout << "Podaj plik wejsciowy:";
	cin >> in;
	inf.open(in);
	if (!inf)
	{
		cerr << "Zly plik";
		exit();
	}

	int lineo = 0;
	string line;
	while (getline(inf, line))
	{
		++lineo;
		smatch wynik;
		if (regex_search(line, wynik, wzorzec))
		{
			cout << "Wiersz " << lineo << " : " << line;
			for (int i; i < wynik.size(); ++i)
				cout << "\tpasuje.[" << i << "]: " << wynik[i] << endl;

		}
		else
			cout << "nie pasuje.\n";

	}
	system("pause");
	return 0;
}