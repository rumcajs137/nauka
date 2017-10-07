#include <iostream>
#include<windows.h>

using namespace std;
int ile;
int main()
{
cin>>ile;
int m[ile];
int liczba[ile];
for(int i=0;i<ile;i)
{
    cin>>liczba[i];
    m[i]=0;
    for(int k=2;k<liczba[i];k++)
    {
        if (liczba[i]%k==0)
        {
            m[i]++;
        }
    }
}
for(int s=0;s<ile;s++)
    if(m[s]==0)
{
    cout<<"TAK"<<endl;
}
else
    {
        cout<<"NIE"<<endl;
}
system("pause");
}
