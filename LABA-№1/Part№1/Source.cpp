#include <iostream>

using namespace std;



int main() {
	const int x = 32;
	register int N;
	cin >> N;
	for (int i = 1; i < x; i*=2)
	{
		N = N << 1;
	}
	cout << N;

	return 0;
}