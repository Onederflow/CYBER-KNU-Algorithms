#include "stdafx.h"
#include <iostream>
#include <vector>
#include <algorithm>
#include <fstream>
#include <ctime>

using namespace std;
const int nmax = 20;

int dimension(vector<vector<int>>, vector<vector<int>>);
int log2(int);

//functions
vector<vector<int>> standartMatrix(vector<vector<int>>, vector<vector<int>>);
vector<vector<int>> toSquare(vector<vector<int>>, int);
vector<vector<int>> sum(vector<vector<int>>, vector<vector<int>>);
vector<vector<int>> subs(vector<vector<int>>, vector<vector<int>>);
vector<vector<int>> add_unit(vector<vector<int>> &, vector<vector<int>> &, vector<vector<int>> &, vector<vector<int>> &);
vector<vector<int>> shtrassenMatrix(vector<vector<int>>, vector<vector<int>>, int);


void split(vector<vector<int>> &, vector<vector<int>> &, vector<vector<int>> &, vector<vector<int>> &, vector<vector<int>> &);
void Print_matrix(vector<vector<int>>, char[255]);
vector<vector<int>> new_random_matrix(int);


//MAIN
int main()
{
	srand(time(0));
	//створенн€ нових матриць
	vector<vector<int>> A = new_random_matrix(nmax);
	vector<vector<int>> B = new_random_matrix(nmax);
	Print_matrix(A, "A");
	Print_matrix(B, "B");

	//звичайне множенн€
	int Standart_time = clock();
	vector<vector<int>> standart = standartMatrix(A, B);
	Standart_time = clock() - Standart_time;

	cout << "Time:" << Standart_time << endl;
	cout << "============================================" << endl;
	Print_matrix(standart, "Standart");

	//Ўтрассена
	int Shtrassen_time = clock();
	vector<vector<int>> A1, B1;
	int newSize = dimension(A, B);
	A1 = toSquare(A, newSize);
	B1 = toSquare(B, newSize);
	vector<vector<int>> shtrassen = shtrassenMatrix(A1, B1, newSize);
	Shtrassen_time = clock() - Shtrassen_time;

	cout << "Time:" << Shtrassen_time << endl;
	cout << "============================================" << endl;
	Print_matrix(shtrassen, "Shtrassen");

	system("Pause");
	return 0;
}

//вив≥д матриц≥
void Print_matrix(vector<vector<int>> now, char s[255])
{
	cout << s << endl;
	for (int i = 0; i < nmax; i++)
	{
		for (int j = 0; j < nmax; j++)
		{
			cout << now[i][j] << " ";
		}
		cout << endl;
	}
	cout << "================================================================================================" << endl;
}
//генерац≥€
vector<vector<int>> new_random_matrix(int count)
{
	vector<vector<int>> now;
	now.resize(count);
	for (int i = 0; i < count; i++)
	{
		now[i].resize(count);
		for (int j = 0; j < count; j++)
		{
			now[i][j] = rand() % 10;
		}
	}
	return now;
}
//звичайна матриц€
vector<vector<int>> standartMatrix(vector<vector<int>> A, vector<vector<int>> B)
{
	vector<vector<int>> C;
	C.resize(A.size());
	for (int i = 0; i < A.size(); i++)
	{
		C[i].resize(B[i].size());
		for (int j = 0; j < B[i].size(); j++)
		{
			for (int k = 0; k < A[0].size(); k++)
			{
				C[i][j] += A[i][k] * B[k][j];
			}
		}
	}
	return C;
}

//
int log2(int x)
{
	int res = 1;
	while ((x >>= 1) != 0)
	{
		res++;
	}
	return res;
}

int dimension(vector<vector<int>> A, vector<vector<int>> B)
{
	int maximum = max(A.size(), max(A[0].size(), B[0].size()));
	int pow = log2(maximum);
	return 1 << pow;
}
// to ...
vector<vector<int>> toSquare(vector<vector<int>> A, int size)
{
	vector<vector<int>> res;
	res.resize(size);

	for (int i = 0; i < size; i++)
	{
		res[i].resize(size);
		for (int j = 0; j < size; j++)
		{
			res[i][j] = 0;
		}
	}

	for (int i = 0; i < A.size(); i++)
	{
		for (int j = 0; j < A[0].size(); j++)
		{
			res[i][j] = A[i][j];
		}
	}
	return res;
}
//2*2 matrix 1212
void split(vector<vector<int>> & a, vector<vector<int>> &a11, vector<vector<int>> &a12, vector<vector<int>> &a21, vector<vector<int>> &a22)
{
	int size = a.size() >> 1;
	a11.resize(size);
	a12.resize(size);
	a21.resize(size);
	a22.resize(size);
	for (int i = 0; i < size; i++)
	{
		a11[i].resize(size);
		a12[i].resize(size);
		a21[i].resize(size);
		a22[i].resize(size);
		for (int j = 0; j < size; j++)
		{
			a11[i][j] = a[i][j];
			a12[i][j] = a[i][j + size];
			a21[i][j] = a[i + size][j];
			a22[i][j] = a[i + size][j + size];
		}
	}
}
//результат
vector<vector<int>> add_unit(vector<vector<int>> &a11, vector<vector<int>> &a12, vector<vector<int>> &a21, vector<vector<int>> &a22)
{
	int size = a11.size();
	vector<vector<int>> a;
	a.resize(size << 1);
	for (int i = 0; i < size << 1; i++)
	{
		a[i].resize(size << 1);
		for (int j = 0; j < size << 1; j++)
		{
			a[i][j] = 0;
		}
	}
	for (int i = 0; i < size; i++)
	{
		for (int j = 0; j < size; j++)
		{
			a[i][j] = a11[i][j];
			a[i][j + size] = a12[i][j];
			a[i + size][j] = a21[i][j];
			a[i + size][j + size] = a22[i][j];
		}
	}
	return a;
}
//сума
vector<vector<int>> sum(vector<vector<int>> A, vector<vector<int>> B)
{
	vector<vector<int>> C;
	C.resize(A.size());
	for (int i = 0; i < A.size(); i++)
	{
		C[i].resize(A[0].size());
		for (int j = 0; j < A[0].size(); j++)
		{
			C[i][j] = A[i][j] + B[i][j];
		}
	}
	return C;
}
//р≥зниц€
vector<vector<int>> subs(vector<vector<int>> A, vector<vector<int>> B)
{
	vector<vector<int>> C;
	C.resize(A.size());
	for (int i = 0; i < A.size(); i++)
	{
		C[i].resize(A[0].size());
		for (int j = 0; j < A[0].size(); j++)
		{
			C[i][j] = A[i][j] - B[i][j];
		}
	}
	return C;
}


vector<vector<int>> shtrassenMatrix(vector<vector<int>> A, vector<vector<int>> B, int size)
{
	if (size == 1)
	{
		return standartMatrix(A, B);
	}

	size = size >> 1;

	vector<vector<int>> a11;
	vector<vector<int>> a12;
	vector<vector<int>> a21;
	vector<vector<int>> a22;

	vector<vector<int>> b11;
	vector<vector<int>> b12;
	vector<vector<int>> b21;
	vector<vector<int>> b22;

	split(A, a11, a12, a21, a22);
	split(B, b11, b12, b21, b22);

	vector<vector<int>> p1 = shtrassenMatrix(sum(a11, a22), sum(b11, b22), size);
	vector<vector<int>> p2 = shtrassenMatrix(sum(a21, a22), b11, size);
	vector<vector<int>> p3 = shtrassenMatrix(a11, subs(b12, b22), size);
	vector<vector<int>> p4 = shtrassenMatrix(a22, subs(b21, b11), size);
	vector<vector<int>> p5 = shtrassenMatrix(sum(a11, a12), b22, size);
	vector<vector<int>> p6 = shtrassenMatrix(subs(a21, a11), sum(b11, b12), size);
	vector<vector<int>> p7 = shtrassenMatrix(subs(a12, a22), sum(b21, b22), size);

	vector<vector<int>> standart1 = sum(sum(p1, p4), subs(p7, p5));
	vector<vector<int>> standart2 = sum(p3, p5);
	vector<vector<int>> c21 = sum(p2, p4);
	vector<vector<int>> c22 = sum(subs(p1, p2), sum(p3, p6));

	return add_unit(standart1, standart2, c21, c22);
}