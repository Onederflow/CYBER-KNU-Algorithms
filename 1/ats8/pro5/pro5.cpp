#include "stdafx.h"
#include <conio.h>
#include <iostream>
#include <ctime>
#include <cassert>
#include <algorithm>
#include <smmintrin.h>
#include <vector>
#include <string>
#include <iomanip>
#include <cstdlib>
#include <cstdio>
#include <stdio.h>
#include <fstream>

using namespace std;
using uint64 = unsigned long long;
using int64 = long long;

struct StringHash
{
	int64 q = (1 << 31) - 1;
	int64 x = 256;
	int64 h;
	size_t str_length;
public:
	StringHash(const size_t& str_length_, uint64 q_ = (1 << 31) - 1, uint64 x_ = 256);
	int64 GetHash(const string& str);
	int64 GetHash(const string& str, size_t start_pos, size_t end_pos);
	void UpdateHash(const string& str, int64& hash, size_t hash_index_to_add);
};
StringHash::StringHash(const size_t& str_length_, uint64 q_, uint64 x_) :x(x_), q(q_), str_length(str_length_)
{
	h = 1;
	for (int i = 0; i < str_length - 1; i++)
		h = (h*x) % q;
}
int64 StringHash::GetHash(const string & str)
{
	int64 hash_for_string = 0;
	for (size_t i = 0; i < str.length(); i++)
		hash_for_string = (x*hash_for_string + str[i]) % q;
	return hash_for_string;
}
int64 StringHash::GetHash(const string& str, size_t start_pos, size_t end_pos)
{
	int64 hash_for_string = 0;
	for (size_t i = start_pos; i < end_pos; i++)
		hash_for_string = (x*hash_for_string + str[i]) % q;
	return hash_for_string;
}
void StringHash::UpdateHash(const string & str, int64 &hash, size_t hash_index_to_add)
{
	size_t prev_hash_start = hash_index_to_add - str_length;
	hash = (x *(hash - str[prev_hash_start] * h) + str[hash_index_to_add]) % q;
}
vector<size_t> Naive(const string& text, const string& string_to_find)
{
	vector<size_t> matches;

	for (size_t text_pos = 0;text_pos<text.size();++text_pos)
	{
		size_t numb_match_symb = 0;
		while (text_pos + numb_match_symb < text.size() &&
			numb_match_symb < string_to_find.size() &&
			text[text_pos + numb_match_symb] == string_to_find[numb_match_symb])
			numb_match_symb++;
		if (numb_match_symb == string_to_find.length())
			matches.push_back(text_pos);
	}
	return matches;
}
vector<size_t> RabinKarp(const string& text, const string& string_to_find)
{
	if (text.length() < string_to_find.length())
		return vector<size_t>();
	int64 q = (1 << 31) - 1;
	int64 x = 255;
	size_t n = text.length();
	size_t m = string_to_find.length();

	StringHash hash(m, q, x);
	int64 prev_hash_for_text = 0, hash_for_string = 0;
	vector<size_t> matches;
	hash_for_string = hash.GetHash(string_to_find);
	prev_hash_for_text = hash.GetHash(text, 0, string_to_find.length());
	for (size_t s = 0; s <= n - m; s++)
	{
		if (hash_for_string == prev_hash_for_text)
			matches.push_back(s);
		if (s != n - m)
		{

			hash.UpdateHash(text, prev_hash_for_text, s + m);
			if (prev_hash_for_text < 0)
			{
				prev_hash_for_text += q;
			}
		}
	}
	return matches;

}
vector<size_t> CreateShiftTable(const string& str)
{
	size_t len = str.length();
	vector<size_t> table(256 - 31, len);
	for (size_t i = 0; i < len - 1; ++i)
		table[str[i] - 31] = len - 1 - i;
	return table;
}
vector<size_t> Horspool(const string& text, const string& string_to_find)
{
	vector<size_t> shift_table = CreateShiftTable(string_to_find);
	vector<size_t> matches;
	size_t str_len = string_to_find.length(), cur_index = str_len - 1;
	size_t text_len = text.length();
	while (cur_index < text_len)
	{
		size_t numb_matching_symbs = 0;
		while (numb_matching_symbs < str_len &&
			string_to_find[str_len - 1 - numb_matching_symbs] == text[cur_index - numb_matching_symbs])
		{
			//	cout << cur_index << ' ' << numb_matching_symbs << endl;
			++numb_matching_symbs;
		}
		if (numb_matching_symbs == str_len)
		{
			matches.push_back(cur_index - str_len + 1);
			++cur_index;
		}
		else
		{
			if (text[cur_index] >= 31)
				cur_index += shift_table[text[cur_index] - 31];
			else
				++cur_index;
		}
	}
	return matches;
}
vector<size_t> CreateSuffShiftTable(const string& str)
{
	size_t str_len = str.length();
	std::vector<size_t> suffshift(str_len + 1, str_len);
	std::vector<size_t> z(str_len, 0);
	for (size_t j = 1, maxZidx = 0, maxZ = 0; j < str_len; ++j) {
		if (j <= maxZ) z[j] = std::min(maxZ - j + 1, z[j - maxZidx]);
		while (j + z[j] < str_len && str[str_len - 1 - z[j]] == str[str_len - 1 - (j + z[j])]) z[j]++;
		if (j + z[j] - 1 > maxZ) {
			maxZidx = j;
			maxZ = j + z[j] - 1;
		}
	}
	for (size_t j = str_len - 1; j > 0; j--) suffshift[str_len - z[j]] = j;
	for (size_t j = 1, r = 0; j <= str_len - 1; j++)
		if (j + z[j] == str_len)
			for (; r <= j; r++)
				if (suffshift[r] == str_len) suffshift[r] = j;
	return suffshift;
}
vector<size_t> BoyerMoore(const string& text, const string& string_to_find)
{
	vector<size_t> shift_table = CreateShiftTable(string_to_find);
	vector<size_t> suff_shift_table = CreateSuffShiftTable(string_to_find);
	vector<size_t> matches;
	size_t str_len = string_to_find.length(), cur_index = str_len - 1;
	size_t text_len = text.length();
	while (cur_index < text_len)
	{
		size_t numb_matching_symbs = 0;
		while (numb_matching_symbs < str_len &&
			string_to_find[str_len - 1 - numb_matching_symbs] == text[cur_index - numb_matching_symbs])
			++numb_matching_symbs;
		if (numb_matching_symbs == str_len)
		{
			matches.push_back(cur_index - str_len + 1);
			++cur_index;
		}
		else
		{
			size_t d1;
			if (text[cur_index] < 31)
				d1 = 1;
			else
				d1 = std::max((int64)shift_table[text[cur_index] - 31] - (int64)numb_matching_symbs, int64(1));
			size_t d2 = std::max(d1, suff_shift_table[numb_matching_symbs]);
			if (numb_matching_symbs == 0)
				cur_index += d1;
			else
				cur_index += d2;
		}
	}
	return matches;

}
vector<size_t> ComputePrefixFucntion(const string& str)
{
	vector<size_t> prefix(str.length());
	prefix[0] = 0;
	size_t k = 0;
	for (size_t q = 1; q<str.length();q++)
	{
		while (k > 0 && str[k] != str[q])
			k = prefix[k - 1];
		if (str[k] == str[q])
			++k;
		prefix[q] = k;
	}
	return prefix;
}
vector<size_t> KMP(const string& text, const string& string_to_find)
{
	size_t text_len = text.length(), str_len = string_to_find.length();
	vector<size_t> prefix = ComputePrefixFucntion(string_to_find), matches;
	size_t q = 0;
	for (size_t i = 0; i < text_len; ++i)
	{
		while (q > 0 && text[i] != string_to_find[q])
			q = prefix[q - 1];
		if (string_to_find[q] == text[i])
			++q;
		if (q == str_len)
		{
			matches.push_back(i + 1 - str_len);
			q = prefix[q - 1];
		}
	}
	return matches;
}

void Main_all()
{
	bool working = true;
	string s;
	string zr = "";// = "Cybernetics is a transdisciplinary approach for exploring regulatory systems—their structures, constraints, and possibilities. Norbert Wiener defined cybernetics in 1948 as the scientific study of control and communication in the animal and the machine.";
	
	fstream text;
	text.open("text.txt");

	while (!text.eof())
	{
		string temp;
		text >> temp;
		zr = zr + " " + temp;

	};
	
	
	
	cout << zr << endl << endl;
	cout << "Write s: ";
	cin >> s;

	cout << "Select type:" << endl;
	cout << "1 - Naive" << endl;
	cout << "2 - Horspool" << endl;
	cout << "3 - Boera-Mura" << endl;
	cout << "4 - KPM" << endl;
	cout << "5 - Rabina-Karpa" << endl;
	cout << "-1 to general test" << endl;
	cout << endl << "Write comand: ";
	int num;
	cin >> num;

	if (num > 0)
	{

		for (int i = 0; i < zr.size(); i++)
			cout << i << " " << zr[i] << endl;

		vector<size_t> res;

		cout << endl << "RESULT: " << endl;
		if (num == 1)
		{
			res = Naive(zr, s);
		};
		if (num == 2)
		{
			res = Horspool(zr, s);
		};
		if (num == 3)
		{
			res = BoyerMoore(zr, s);
		};
		if (num == 4)
		{
			res = KMP(zr, s);
		};
		if (num == 5)
		{
			res = RabinKarp(zr, s);
		};


		for (int i = 0; i < res.size(); i++)
		{
			cout << res[i] << endl;
		};
	}
	else
		if (num == -1)
		{
			vector<size_t> res;
			float test[5];

			test[0] = clock();
			res = Naive(zr, s);
			test[0] = clock() - test[0];

			test[1] = clock();
			res = Horspool(zr, s);
			test[1] = clock() - test[1];

			test[2] = clock();
			res = BoyerMoore(zr, s);
			test[2] = clock() - test[2];

			test[3] = clock();
			res = KMP(zr, s);
			test[3] = clock() - test[3];

			test[4] = clock();
			res = RabinKarp(zr, s);
			test[4] = clock() - test[4];

			cout << "Naive         :" << fixed << setprecision(3) << test[0]/1000 << endl;
			cout << "Horspool      :" << fixed << setprecision(3) << test[1]/1000 << endl;
			cout << "Boera-Mura    :" << fixed << setprecision(3) << test[2]/1000 << endl;
			cout << "KPM           :" << fixed << setprecision(3) << test[3]/1000 << endl;
			cout << "Rabina-Karpa  :" << fixed << setprecision(3) << test[4]/1000 << endl;
		}
}

int main()
{
	srand(time(0));
	while (true)
	{
		Main_all();
		system("Pause");
	}
    return 0;
}
