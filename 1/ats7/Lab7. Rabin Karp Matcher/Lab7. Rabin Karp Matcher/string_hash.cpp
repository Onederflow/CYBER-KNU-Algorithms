#include "stdafx.h"
#include "string_hash.h"

StringHash::StringHash(const size_t& str_length_, uint64 q_, uint64 x_) :x(x_), q(q_),str_length(str_length_)
{
	h = 1;
	for (int i = 0; i < str_length - 1; i++)
		h = (h*x) % q;
}

int64 StringHash::GetHash(const string & str)
{
	uint64 hash_for_string = 0;
	for (size_t i = 0; i < str.length(); i++)
		hash_for_string = (x*hash_for_string + str[i] - 31) % q;
	return hash_for_string;
}

int64 StringHash::GetHash(const string& str, size_t start_pos, size_t end_pos)
{
	uint64 hash_for_string = 0;
	for (size_t i =start_pos; i < end_pos; i++)
		hash_for_string = (x*hash_for_string + str[i] - 31) % q;
	return hash_for_string;
}

void StringHash::UpdateHash(const string & str, int64 &hash, size_t hash_index_to_add)
{
	size_t prev_hash_start = hash_index_to_add - str_length;
	hash = (x * hash) % q - ((str[prev_hash_start] - 31) * h * x) % q + (str[hash_index_to_add] - 31) % q;
}
