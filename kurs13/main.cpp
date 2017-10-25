#include <iostream>
#include <windows.h>
#include <time.h>
#include <stdlib.h>

using namespace std;
int ile;
clock_t start,stop;
double czas;

void quicksort(int *tablica, int lewy, int prawy)
{
    int v=tablica[(lewy+prawy)/2];
    int i,j,x;
    i=lewy;
    j=prawy;
    do
    {
        while (tablica[i]<v) i++;
        while (tablica[j]>v) j--;
        if (i<=j)
        {
            x=tablica[i];
            tablica[i]=tablica[j];
            tablica[j]=x;
            i++;
            j--;
        }
    }
    while (i<=j);
    if (j>lewy) quicksort(tablica,lewy, j);
    if (i<prawy) quicksort(tablica, i, prawy);
}

void sortowanie_babelkowe(int *tab,int n)
{

    for (int i=1; i<n; i++)
    {
        for(int j=n-1; j>=1; j--)
        {
            if (tab[j]<tab[j-1])
            {
                int bufor;
                bufor=tab[j-1];
                tab[j-1]=tab[j];
                tab[j]=bufor;
            }
        }
    }
}


int main()
{
    cout << "Porownanie czasow sortowania v.1" << endl;
    Sleep(500);
    cout << "Ile losowych liczb w tablicy: ";
    cin>>ile;

    //dynamiczna alokacja tablicy
    int *tablica;
    tablica=new int [ile];
    int *tablica2;
    tablica2=new int[ile];

    //inicjowanie generatora
    srand(time(NULL));
    //wczytywanie losowych liczb do tabllicy
    for(int i=0; i<ile; i++)
    {
        tablica[i]=rand()%100000+1;

    }
//przepisywanie tablicy do tablicy2
for(int i=0; i<ile; i++)
    {
        tablica2[i]=tablica[i];
    }


//    cout<<"przed posortowaniem"<<endl;
//    for(int i=0; i<ile; i++)
//    {
//        cout<<tablica2[i]<<" ";
//    }

    cout<<endl<<"sortuje teraz babelkowo. prosze czekac!"<<endl;
    start=clock();
    sortowanie_babelkowe(tablica,ile);
    stop=clock();
    czas=(double)(stop-start)/CLOCKS_PER_SEC;

//    cout<<"po posortowaniu"<<endl;
//    for(int i=0; i<ile; i++)
//    {
//        cout<<tablica[i]<<" ";
//    }


    cout<<endl<<"czas sortowania babelkowego "<<czas<<"s"<<endl;


    cout<<"sortuje teraz algorytmem quicksort. prosze czekac!"<<endl;
    start=clock();
   quicksort(tablica2,0,ile-1);
    stop=clock();
    czas=(double)(stop-start)/CLOCKS_PER_SEC;

//    cout<<"po posortowaniu"<<endl;
//    for(int i=0; i<ile; i++)
//    {
//        cout<<tablica2[i]<<" ";
//    }


    cout<<endl<<"czas sortowania quicksort "<<czas<<"s"<<endl;


    delete [] tablica;
    delete [] tablica2;

    return 0;
}
