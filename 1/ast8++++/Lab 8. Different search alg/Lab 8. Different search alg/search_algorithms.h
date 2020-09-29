#pragma once
#include "stdafx.h"
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



vector<size_t> commonSearch(const string& text, const string& string_to_find);

vector<size_t> RabinKarpMatcher(const string& text, const string& string_to_find);

vector<size_t> HorspoolAlgorithm(const string& text, const string& string_to_find);

vector<size_t> BoyerMooreAlgorithm(const string& text, const string& string_to_find);

vector<size_t> KMPMatcher(const string& text, const string& string_to_find);

string GenerateBinaryString(size_t size);

vector<pair<size_t, size_t>> FindInTextFile(const string& file_path, const string& str_to_find,
	vector<size_t>(*search)(const string&, const string&) = commonSearch);

void show(const pair<size_t, size_t>& match);