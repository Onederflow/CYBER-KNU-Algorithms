#pragma once
#include "stdafx.h"
using uint64 = unsigned long long;
using int64 = long long;
struct StringHash
{
	uint64 q = (1 << 31) - 1;
	uint64 x = 256;
	uint64 h;
	size_t str_length;
public:
	StringHash(const size_t& str_length_,uint64 q_ = (1 << 31) - 1,uint64 x_ = 256);
	int64 GetHash(const string& str);
	int64 GetHash(const string& str, size_t start_pos, size_t end_pos);
	void UpdateHash(const string& str, int64& hash, size_t hash_index_to_add);
};