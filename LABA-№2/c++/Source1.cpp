#include<iostream>

using namespace std;

extern "C" mult();

int main() {
	mult(10, 32);
	return 0;
}