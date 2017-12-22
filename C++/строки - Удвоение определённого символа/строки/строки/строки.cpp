// строки.cpp: определяет точку входа для консольного приложения.
//
#include "stdafx.h"
#include <iostream>
#include <cstring>

int main()
{
	using namespace std;//Если более-менее новый компилятор
	const int max_size = 1000;
	char s[max_size];
	cin >> s;
	int l = strlen(s);
	char c;
	cout << "Enter symbol for double: ";
	cin >> c;
	for (int i = 0; i < l; i++)
	{
		if (s[i] == c)
			cout << s[i] << s[i];
		else
			cout << s[i];
	}
	return 0;
}

