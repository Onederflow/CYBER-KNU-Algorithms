// ats4.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>
#include <queue>
#include <ctime>
#include <stdlib.h>

using namespace std;
const int nmax = 20;

class MyMass
{
public:
	int *arr = new int[nmax];

	void create()
	{
		for (int i = 0;i<nmax;i++)
		{
			arr[i] = rand() % 2;
		}
	};
	void print()
	{
		cout << "Array: ";
		for (int i = 0;i<nmax;i++)
			cout << arr[i] << ' ';
		cout << endl;
	}
	void sort1()
	{
		queue<int> ones, zeros;
		for (int i = 0;i<nmax;i++)
		{
			if (arr[i] == 0) zeros.push(i); else ones.push(i);
		}
		int k = 0;

		while (!zeros.empty())
		{
			arr[k++] = 0;
			zeros.pop();
		}

		while (!ones.empty())
		{
			arr[k++] = 1;
			ones.pop();
		}


	}
	void sort2()
	{
		int ones = 0, zeros = 0;
		for (int i = 0;i<nmax;i++)
		{
			if (arr[i] == 0) zeros++; else ones++;
		}
		int k = 0;
		while (zeros > 0)
		{
			arr[k++] = 0;
			zeros--;
		};
		while (ones > 0)
		{
			arr[k++] = 1;
			ones--;
		};
	}
	void sort3()
	{
		for (int i = 0;i<nmax;i++)
		{
			for (int j = 0;j<nmax - 1;j++)
			{
				if (arr[j]>arr[j + 1]) swap(arr[j], arr[j + 1]);
			}
		}


	}
};





int main()
{
	srand(time(0));
	MyMass now;
	now.create();
	now.print();
	

	int number_sort;
	cout << "Write number of sorting : ";
	cin >> number_sort;

	if (number_sort > 0 && number_sort < 4)
	{
		if (number_sort == 1)
			now.sort1();
		else if (number_sort == 2)
			now.sort2();
		else if (number_sort == 3)
			now.sort3();


		cout << "Sorting " << number_sort << endl;

		cout << "Result:" << endl;
		now.print();
	}
	else
		cout << "Error: number is invalid" << endl;
	system("pause");
	return 0;
}
