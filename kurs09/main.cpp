#include <iostream>

using namespace std;

int main()
{
    int S[2];
   for(int i=0;i<2;i++)
   {
       cin>>S[i];
   }
   if(S[0]<200&&S[1]<200)
   cout<<S[0]+S[1];
   else return 0;
    return 0;
}
