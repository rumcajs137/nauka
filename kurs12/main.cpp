#include <iostream>
#include <time.h>
#include <cstdlib>

using namespace std;
double czas;
int s,p,w;
long double wynik=1,wynik2=1;
clock_t start, stop;



long double silnia(int n)
{
    if (n==0) return 1;
    else return n*silnia(n-1);
}

long double potega(int p, int w)
{
    if (w==0) return 1;
    else return p*potega(p,w-1);
}



int main()
{

    //silnia rekurencyjnie
    cout<<"obliczamy silnie - podaj liczbe: ";
    cin>>s;
    start=clock();
    cout << "silnia rekurencyjnie wynosi: "<< silnia(s) << endl;
    stop=clock();
    czas=(double)(stop-start)/CLOCKS_PER_SEC;
    cout<<"czas silnia rekurencyjnie wynosi: "<<czas<<endl;


    //silnia normalnie
    start=clock();
    for(int i=1;i<=s;i++)
    {
        wynik*=i;
    }
    stop=clock();
    cout<<"silnia normalnie wynosi: "<<wynik<<endl;
    czas=(double)(stop-start)/CLOCKS_PER_SEC;
    cout<<"czas silnia normalnie wynosi: "<<czas<<endl;

    //potega rekurencyjnie
    cout<<"obliczamy potege - podaj podstawe i po spacji wykladnik: ";
    cin>>p>>w;
    start=clock();
    cout << "potega rekurencyjnie wynosi: "<< potega(p,w) << endl;
    stop=clock();
    czas=(double)(stop-start)/CLOCKS_PER_SEC;
    cout<<"czas potega rekurencyjnie wynosi: "<<czas<<endl;

    //potega normalnie
    start=clock();
    for (int i=0;i<w;i++)
    {
        wynik2*=p;
    }
    stop=clock();
    cout<<"potega normalnie wynosi: " <<wynik2<<endl;
    czas=(double)(stop-start)/CLOCKS_PER_SEC;
    cout<<"czas potega normalnie wynosi: "<<czas<<endl;



    return 0;
}
