#include <iostream>

using namespace std;

void fizzbuzz(int liczba)
{
    if (liczba%3==0)
        cout<<"fizz";
    if(liczba%5==0)
        cout<<"buzz";
}

int main()
{
    int liczba;
    cout<<"podaj liczbe: "<<endl;
    cin>>liczba;
    fizzbuzz(liczba);
    return 0;
}
