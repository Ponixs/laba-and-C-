#include<iostream>

using namespace std;

extern "C"  int mult();
extern "C" unsigned int a_asm = 0;


int main() {
	register int a = 10, b = 32;
	for (int i = 1; i < b; i *= 2)
	{
		a_asm = a;
		mult();
	}
	cout << a;
	return 0;
}