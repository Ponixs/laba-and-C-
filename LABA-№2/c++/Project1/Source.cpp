#include<iostream>

using namespace std;

extern "C"  int mult(register int, register int);

int main() {
	register int a = 10, b = 32;
	mult(a, b);
	return 0;
}