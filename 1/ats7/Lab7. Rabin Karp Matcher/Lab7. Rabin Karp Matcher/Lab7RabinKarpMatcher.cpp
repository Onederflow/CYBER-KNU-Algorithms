// Lab7RabinKarpMatcher.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <random>
#include <fstream>
#include "string_hash.h"
using uint64 = unsigned long long;
using int64 = long long;

uint64 binpow(uint64 numb, int power,uint64 divider) {
	uint64 res = 1;
	while (power) {
		if (power & 1)
			res = (res*numb)%divider;
		numb *= numb;
		power >>= 1;
	}
	return res;
}
void search(string pat, string txt, int q)
{
	int d = 256;
	int M = pat.length();
	int N = txt.length();
	int i, j;
	int p = 0; // hash value for pattern
	int t = 0; // hash value for txt
	int h = 1;

	// The value of h would be "pow(d, M-1)%q"
	for (i = 0; i < M - 1; i++)
		h = (h*d) % q;

	// Calculate the hash value of pattern and first
	// window of text
	for (i = 0; i < M; i++)
	{
		p = (d*p + pat[i]) % q;
		t = (d*t + txt[i]) % q;
	}

	// Slide the pattern over text one by one
	for (i = 0; i <= N - M; i++)
	{

		// Check the hash values of current window of text
		// and pattern. If the hash values match then only
		// check for characters on by one
		if (p == t)
		{
			/* Check for characters one by one */
			for (j = 0; j < M; j++)
			{
				if (txt[i + j] != pat[j])
					break;
			}

			// if p == t and pat[0...M-1] = txt[i, i+1, ...i+M-1]
			if (j == M)
				printf("Pattern found at index %d \n", i);
		}

		// Calculate hash value for next window of text: Remove
		// leading digit, add trailing digit
		if (i < N - M)
		{
			t = (d*(t - txt[i] * h) + txt[i + M]) % q;

			// We might get negative value of t, converting it
			// to positive
			if (t < 0)
				t = (t + q);
		}
	}
}
vector<int> RabinKarpMatcher(const string& text,const string& string_to_find)
{
	if (text.length() < string_to_find.length())
		return vector<int>();
	uint64 q = (1 << 31) - 1;
	uint64 x = 256;
	size_t n = text.length();
	size_t m = string_to_find.length();

	StringHash hash(m, q, x);
	int64 prev_hash_for_text = 0,hash_for_string = 0;
	vector<int> indices;
	hash_for_string = hash.GetHash(string_to_find);
	prev_hash_for_text = hash.GetHash(text, 0, string_to_find.length());
	for (size_t s = 0; s <= n - m; s++)
	{
		if (hash_for_string == prev_hash_for_text)
			indices.push_back(s);
		if (s != n - m)
		{
			hash.UpdateHash(text, prev_hash_for_text, s + m);
			if (prev_hash_for_text < 0)
			{
				cout << "Waaaat" << endl;
				prev_hash_for_text += q;
			}
		}
	}
	return indices;
}


using matches = vector<std::pair<int, int>>;
vector<std::pair<int, int>> RabinKarpMatrixMatcher(const vector<string>& matrix, const vector<string>& matrix_to_find)
{
	size_t snippet_row_size = matrix_to_find.size();
	matches result;
	if (snippet_row_size == 0)
		return matches();
	size_t snippet_column_size = matrix_to_find.front().length();

	vector<int64> find_string_hashes(snippet_row_size);
	uint64 q = (1 << 31) - 1;
	uint64 x = 256;
	StringHash hash(snippet_column_size, q, x);
	for (size_t i = 0; i < snippet_row_size; ++i)
		find_string_hashes[i] = hash.GetHash(matrix_to_find[i]);
	size_t cur_matrix_row = (matrix_to_find.size() >> 1);
	for (size_t row = 0; row <= matrix.size() - snippet_row_size; ++row)
	{
		vector <int64> cur_matrix_hashes(snippet_row_size);
		for (size_t i = 0; i < snippet_row_size; ++i)
			cur_matrix_hashes[i] = hash.GetHash(matrix[i + row], 0, snippet_column_size);
		for (size_t column = 0; column <= matrix[row].size() - snippet_column_size; ++column)
		{
			if (cur_matrix_hashes == find_string_hashes)
				result.push_back(std::make_pair(row, column));
			if (column!= matrix[row].size() - snippet_column_size)
				for (size_t i = 0; i < snippet_row_size; ++i)
					hash.UpdateHash(matrix[row + i], cur_matrix_hashes[i], column + snippet_column_size);
		}

	}
	return result;
}



vector<int> commonSearch(const string& text, const string& string_to_find)
{
	size_t cur_position = 0;
	vector<int> res;
	do
	{
		cur_position = text.find(string_to_find, cur_position);
		if (cur_position != string::npos)
		{
			res.push_back(cur_position);
			cur_position += string_to_find.length();
		}
	} while (cur_position != string::npos);
	return res;
}

void findInText(const string& file_name, const string& string_to_find);
void getMatricesFromFile(const string& filename, vector<string>& matrix, vector<string>& matrix_to_find);
int main()
{
	//findInText("input.txt", "is");
	vector<string> matrix, matrix_to_find;
	getMatricesFromFile("input.txt", matrix, matrix_to_find);
	auto result = RabinKarpMatrixMatcher(matrix, matrix_to_find);
	for (auto res : result)
		cout << res.first << ' ' << res.second << endl;
	cout << endl;
    return 0;
}
void getMatricesFromFile(const string& filename,vector<string>& matrix, vector<string>& matrix_to_find)
{
	std::ifstream file(filename);
	size_t matrix_rows;
	file >> matrix_rows;
	file.get();
	matrix.resize(matrix_rows);
	for (size_t i = 0; i < matrix_rows;i++)
		std::getline(file, matrix[i]);
	file >> matrix_rows;
	file.get();
	matrix_to_find.resize(matrix_rows);
	for (size_t i = 0; i < matrix_rows; i++)
		std::getline(file, matrix_to_find[i]);
	file.close();
}
void findInText(const string & file_name, const string & string_to_find)
{
	std::ifstream file(file_name);
	size_t str_len = string_to_find.length();
	string cur_string;
	uint64 cur_line_numb = 1;
	while (std::getline(file,cur_string))
	{
		cout << "Rabin Karp:\n";
		vector<int> cur_mathes = RabinKarpMatcher(cur_string, string_to_find);
		for (auto &x : cur_mathes)
			cout << "Line " << cur_line_numb << ", position " << x + 1 <<":\t"<< cur_string.substr(x, str_len) << endl;
		cout << "Common:\n";
		cur_mathes = commonSearch(cur_string, string_to_find);

		for (auto &x : cur_mathes)
			cout << "Line " << cur_line_numb << ", position " << x + 1 << ":\t" << cur_string.substr(x, str_len) << endl;
		cur_line_numb++;
	}
	file.close();
}
