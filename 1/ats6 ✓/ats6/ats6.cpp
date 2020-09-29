// ats6.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>
#include <ctime>
#include <set>
#include <iterator>
#include <fstream>

using namespace std;

bool strzs(char a1[256], char a2[256], int delta)
{
	bool res = true;
	char temp;
	for (int i = 0; i < strlen(a1); i++)
	{
		if (i + delta >= strlen(a1))
			temp = a2[i + delta - strlen(a1)];
		else
			temp = a2[i + delta];
		cout << temp << " " << a1[i] << endl;

		if (temp != a1[i])
			res = false;
	}

	return res;
}

int main()
{
	char T[256] = "";
	char Q[256] = "";
	cout << "Write string T : ";
	cin >> T;
	cout << "Write string T* : ";
	cin >> Q;

	cout << T << " " << Q << endl;
	if (strlen(T) == strlen(Q))
	{
		if (T != Q)
		{

			int i = 0;
			bool b = false;

			while (!b && i < strlen(T))
			{ 
				cout << i <<endl;
				if (strzs(T, Q, i))
				{
					b = true;
					cout << endl << " true on " << i << endl;

				}

				i++;
			}



		}
		else
			cout << endl << "T == T*" << endl;

	}
	else
		cout << endl << "lenghts different" << endl;

	system("pause");
    return 0;
}

