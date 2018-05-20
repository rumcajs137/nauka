#include <cstdio>
#include <vector>
#include <ctime>
#include <cstdlib>
#include <algorithm>
#include <Windows.h>
using namespace std;

int main()
{
	srand(time(NULL));
	typedef vector  <int>  VDaneT;
	VDaneT dane(10);
	for (int i = 0; i < dane.size(); ++i)
		dane[i] = rand() % 50 + 1;

	sort(dane.begin(), dane.end(), [](const int & a, const int & b)->bool { return a > b; });

	for (int i = 0; i < dane.size(); ++i)
		printf("%d, ", dane[i]);

	system("pause");
	return 0;
}