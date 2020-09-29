#include "stdafx.h"
#include <iostream>
#include <ctime>
#include <set>
#include <iterator>
#include <fstream>


const int nmax = 20;
using namespace std;


void swipe(int &a1, int &a2)
{
	int temp = a1;
	a1 = a2;
	a2 = a1;
};

class mech
{
public:
	int *bolt = new int[nmax];
	int *nut = new int [nmax];

	int result[nmax];

	void set_value()
	{
		set<int> usles;
		set<int> not_nut;

		for (int i = 0; i < nmax; i++)
		{
			int new_int = rand() % 1000;

			bolt[i] = new_int;
			nut[i] = new_int;
		};

		for (int i = 1; i < nmax; i++)
		{
			int j = rand() % (nmax - 1);
			if(i != j)
				swap(nut[i], nut[j]);
		};

	}

	void print_all()
	{
		cout << endl;
		cout << "mas bolts: ";
		for (int i = 0; i < nmax; i++)
			cout << bolt[i] << "  ";
		cout << endl << "mas nuts:  ";
		for (int i = 0; i < nmax; i++)
			cout << nut[i] << "  ";

	}

	void sorting(int *bolts, int *nuts, int l, int r)
	{
		int pivot = bolts[(l + r) / 2];
		int first = l, last = r;
		while (first <= last)
		{
			while (nuts[first]<pivot) first++;
			while (nuts[last]>pivot) last--;
			if (first <= last)
			{
				swap(nuts[first], nuts[last]), first++, last--;
			};
		}
		int i = l, j = r;
		while (i <= j)
		{
			while (bolts[i]<pivot) i++;
			while (bolts[j]>pivot) j--;
			if (i <= j)
				swap(bolts[i], bolts[j]), i++, j--;
		}
		if (first<r) sorting(bolts, nuts, first, r);
		if (last>l) sorting(bolts, nuts, l, last);
	}

};

int main()
{
	srand(time(0));
	mech now;
	now.set_value();
	now.print_all();
	now.sorting(now.bolt, now.nut, 0, nmax - 1);
	cout << endl << endl <<  "Sorting";
	now.print_all();
	system("pause");
	return 0;
}
