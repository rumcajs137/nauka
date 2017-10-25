#include <iostream>
#include <windows.h>

using namespace std;

void pieniaszki(float p)
{
    int dst, st, pdz, ddsz, dsz, pia, dw, zl, pdzgr, ddzgr, dzgr, pgr, dgr, gr,suma;


        if (p / 200 > 0)
        {
            dst = p / 200;
            p = p - dst * 200;
        }
         if (p / 100 > 0)
        {
            st = p / 100;
            p = p - st * 100;
        }

        if (p / 50 > 0)
        {
            pdz = p / 50;
            p = p - pdz * 50;
        }
         if (p / 20 > 0)
        {
            ddsz = p / 20;
            p = p - ddsz * 20;
        }
         if (p / 10 > 0)
        {
            dsz = p / 10;
            p = p - dsz * 10;
        }
         if (p / 5 > 0)
        {
            pia = p / 5;
            p = p - pia * 5;
        }
         if (p / 2 > 0)
        {
            dw = p / 2;
            p = p - dw * 2;
        }
         if (p / 1 > 0)
        {
            zl = p / 1;
            p = p - zl * 1;
        }
         if (p / 0.5 > 0)
        {
            pdzgr = p / 0.5;
            p = p - pdzgr * 0.5;
        }
         if (p / 0.2 > 0)
        {
            ddzgr = p / 0.2;
            p = p - ddzgr * 0.2;
        }
         if (p / 0.1 > 0)
        {
            dzgr = p / 0.1;
            p = p - dzgr * 0.1;
        }
         if (p / 0.05 > 0)
        {
            pgr = p / 0.05;
            p = p - pgr * 0.05;
        }
         if (p / 0.02 > 0)
        {
            dgr = p / 0.02;
            p = p - dgr * 0.02;
        }
        if (p / 0.01 > 0)
        {
            gr = p / 0.01;
            p = p - gr * 0.01;
        }

    suma = dst + st + pdz + ddsz + dsz + pia + dw + zl + pdzgr + ddzgr + dzgr + pgr + dgr + gr;
    cout << "minimalna ilosc pieniaszkow: " << suma << endl;
    cout << "dwusetek: " << dst << endl;
    cout << "stowek: " << st << endl;
    cout << "piedziesiatek: " << pdz << endl;
    cout << "dwudyszek: " << ddsz << endl;
    cout << "dyszek: " << dsz << endl;
    cout << "piatek: " << pia << endl;
    cout << "dwojek: " << dw << endl;
    cout << "zlotowek: " << zl << endl;
    cout << "50 gr: " << pdzgr << endl;
    cout << "20 gr: " << ddzgr << endl;
    cout << "10 gr: " << dzgr << endl;
    cout << "5 gr: " << pgr << endl;
    cout << "2 gr: " << dgr << endl;
    cout << "1 gr: " << gr << endl;

    }


int main()
{
    float p;
    cout << "podaj ilosc pieniaszkow: ";
    cin >> p;
    pieniaszki(p);


    system("pause");
}
