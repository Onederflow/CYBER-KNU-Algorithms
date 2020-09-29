#include "stdafx.h"
#include <conio.h>
#include <iostream>
#include <ctime>
#include <vector>

using namespace std;



vector<int> mas;
int nmax;
int d;

void shiftUp(int i)
{
	int parent = (i - 1) / d;
	while (i>0 && mas[i]>mas[parent])
	{
		swap(mas[i], mas[parent]);
		i = parent;
		parent = (i - 1) / d;
	}
}

void shiftDown(int i)
{
	if (i*d + 1 >= nmax) return;
	int maxSon = i*d + 1, last = (i + 1)*d;
	if (last >= nmax) last = nmax - 1;
	for (int j = i*d + 1;j <= last;j++)
	{
		if (mas[j]>mas[maxSon]) maxSon = j;
	}
	if (mas[i]<mas[maxSon])
	{
		swap(mas[i], mas[maxSon]);
		shiftDown(maxSon);
	}
}

void Insert(int key)
{
	mas.push_back(key);
	nmax = mas.size();
	shiftUp(nmax - 1);
}

void Extract_Max()
{
	if (nmax == 0) { cout << "Heap is empty\n";return; }
	cout << "max value: " << mas[0] << endl;
	mas[0] = mas[nmax - 1];
	mas.erase(mas.begin() + nmax - 1);
	nmax = mas.size();
	shiftDown(0);
}

int findKey(int key)
{
	for (int i = 0;i<nmax;i++)
	{
		if (mas[i] == key) return i;
	}
	return -1;
}

void Increase_Key(int key, int del)
{
	int index = findKey(key);
	if (index == -1)
	{
		cout << "Incorrect index\n";
		return;
	}
	mas[index] += del;
	shiftUp(index);
}
void print()
{
	cout << endl << "Massive: ";
	if (nmax == 0) { cout << "Heap is empty\n";return; }
	for (int i = 0;i<nmax;i++)
		cout << mas[i] << ' ';
	cout << endl;
}




bool Main_all();
void Comands(int num);
int main()
{
	srand(time(0));

	cout << "Write d: ";
	cin >> d;

	while (Main_all())
	{
		system("Pause");
	}
    return 0;
}



bool Main_all()
{
	bool working = true;
	int num;
	cout << endl;
	cout << "Press '1' to Insert value" << endl;
	cout << "Press '2' to Extract Max" << endl;
	cout << "Press '3' to Increase_Key" << endl;
	cout << "print n < 0 to generation (-n) new random items" << endl;
	cout << "Press '0' to quite" << endl;
	cin >> num;
	Comands(num);
	if (num == 0)
		working = false;
	return working;
}
void Comands(int num)
{
	if (num == 1)
	{
		cout << "Write data: ";
		int data;
		cin >> data;
		Insert(data);
		print();
	}else
	if (num == 2)
	{
		Extract_Max();
		print();
	}else
	if (num == 3)
	{
		int i, del;
		cout << "Write index and delta: ";
		cin >> i >> del;
		Increase_Key(i, del);
		print();
	}
	else
	if (num < 0 )
	{
		for (int i = 1; i <= -num;i++)
			Insert(rand() % 100);
		print();
	};

}