// ConsoleApplication1.cpp: определяет точку входа для консольного приложения.
//

# include "stdafx.h"
# include <iostream>
# include <conio.h>
using namespace std;
void insertComma(char *);
int main(){
	setlocale(LC_ALL, "Russian");
	cout << "Введите ваши строки: " << endl;
	char Arr[2][255];
	for (int i = 0; i<1; i++){
		cin.getline(Arr[i], 255);
		insertComma(Arr[i]);

	}
	for (int i = 0; i < 1; i++)
		cout << "Результат: " << Arr[i] << endl;
	return 0;



}
void insertComma(char *s)
{

	int j = 0;
	while (s[j] != '\0') {
		if (s[j] == ' ')
		{
			for (int i = strlen(s); i > j; i--)
				s[i + 1] = s[i];
			s[j + 1] = '.';

		}
		j++;
	}
}

