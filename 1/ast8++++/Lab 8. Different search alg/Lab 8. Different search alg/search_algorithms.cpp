#include "stdafx.h"
#include "search_algorithms.h"
#include <cassert>
#include <algorithm>
#include <smmintrin.h>

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
		hash_for_string = (x*hash_for_string + str[i] ) % q;
	return hash_for_string;
}

void StringHash::UpdateHash(const string & str, int64 &hash, size_t hash_index_to_add)
{
	size_t prev_hash_start = hash_index_to_add - str_length;
	//hash = (x * hash) % q - ((str[prev_hash_start] - 31) * h * x) % q + (str[hash_index_to_add] - 31) % q;
	hash = (x *(hash - str[prev_hash_start] * h) + str[hash_index_to_add]) % q;
}

vector<pair<size_t, size_t>> FindInTextFile(const string& file_path, const string& str_to_find,
	vector<size_t> (* search)(const string&, const string&))
{
	ifstream file(file_path);
	string cur_line;
	size_t cur_row = 0;
	vector<pair<size_t, size_t>> all_matches;

	if (!file.is_open())
	{
		std::cerr << "Error while opening " << file_path << " for reading!\n";
		return all_matches;
	}
	while (getline(file, cur_line))
	{
		vector<size_t> line_matches = search(cur_line, str_to_find);
		for (auto match : line_matches)
			all_matches.push_back(make_pair(cur_row, match));
		++cur_row;
	}
	file.close();
	return all_matches;
}

void show(const pair<size_t, size_t>& match)
{
	cout << "Line: " << match.first << " position: " << match.second<<endl;
}

vector<size_t> commonSearch(const string& text, const string& string_to_find)
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

	//size_t cur_position = 0;

	//do
	//{

	//	cur_position = text.find(string_to_find, cur_position);
	//	if (cur_position != string::npos)
	//	{
	//		matches.push_back(cur_position);
	//		cur_position++;
	//		//cur_position += string_to_find.length();
	//	}
	//} while (cur_position != string::npos);
	return matches;
}

vector<size_t> RabinKarpMatcher(const string& text, const string& string_to_find)
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
		/*	if (text[s + m] < 0)
				cout << "first occurrence\n";*/
			//if (text[s+m]<31)

			hash.UpdateHash(text, prev_hash_for_text, s + m);
			if (prev_hash_for_text < 0)
			{
				/*cout << "Waaaat" << endl;
				cin.get();*/
				prev_hash_for_text += q;
			}
		}
	}
	return matches;

}

vector<size_t> CreateShiftTable(const string& str)
{
	size_t len = str.length();
	vector<size_t> table(256 - 31,len);
	for (size_t i = 0; i < len - 1; ++i)
		table[str[i]-31] = len - 1 - i;
	return table;
}

vector<size_t> HorspoolAlgorithm(const string& text, const string& string_to_find)
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

vector<size_t> BoyerMooreAlgorithm(const string& text, const string& string_to_find)
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
			k = prefix[k-1];
		if (str[k] == str[q])
			++k;
		prefix[q] = k;
	}
	return prefix;
}
vector<size_t> KMPMatcher(const string& text, const string& string_to_find)
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
			q = prefix[q-1];
		}
	}
	return matches;
}

string GenerateBinaryString(size_t size)
{
	string binary_string;
	std::random_device rd;
	std::mt19937 mt(rd());
	std::uniform_int_distribution<int> distrib(0, 1);
	for (size_t i = 0; i < size; ++i)
		binary_string.push_back(distrib(mt) + '0');
	return binary_string;
}

