// stroki_18.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>
#include <string>

int main()
{
	setlocale(LC_ALL, "Russian");
	const int SZ = 100;
	std::string a = "Вот рабочая программа   ";
	std::string b;
	b += a[0];

	for (int i = 1; i < a.size(); i++)
	{
		if ((a[i] != ' ') || ((a[i] == ' ') && (a[i - 1] != ' '))) b += a[i];
		for (int i = 0; i < b.size() - 1; i++)
		if (b[i] == ' ')
			b[i] = '.';
	}
	std::cout << std::endl;
	std::cout << b << std::endl;


	system("pause");
	return 0;
}

