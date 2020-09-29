#include "stdafx.h"
#include "search_algorithms.h"
string GetFromFile(const string& file_name)
{
	string line,res;
	ifstream file(file_name);
	while (getline(file, line))
		res += line;
	return res;
}
std::ostream& operator<<(std::ostream& os, const pair<size_t,size_t>& pos)
{
	os << "(" << pos.first << ", " << pos.second << ")";
	return os;
}
int main()
{
	vector<size_t> (*search_func[])(const string&t, const string& s) = { commonSearch , HorspoolAlgorithm,  KMPMatcher ,RabinKarpMatcher, BoyerMooreAlgorithm};
	string search_names[] = { "Common search","Horspool algorithm","KMP algorithm","Rabin Karp algorithm", "Boyer Moore algorithm"};
	
	cout << "Searching in a file:\n";
	std::chrono::time_point<std::chrono::high_resolution_clock> start, end;
	std::array< vector< pair<size_t,size_t> >, 5> file_search_res;
	for (int i = 0; i < 5; ++i)
	{
		cout << search_names[i]<<": ";
		start = std::chrono::high_resolution_clock::now();
		file_search_res[i] = FindInTextFile("input.txt", " then came an incident which was rather unexpected to myself", search_func[i]);
		end = std::chrono::high_resolution_clock::now();
		std::chrono::duration<double> time_lapsed = end - start;
		cout << time_lapsed.count() << "s. " << endl;
	}
	
	int failed_algos = 0;
	for (int i = 1;i<5;i++)
		if (file_search_res[i] != file_search_res[0])
		{
			++failed_algos;
			cout << search_names[i] << " failed!\n";
			cout << "Result:\n";
			for (size_t j = 0; j < file_search_res[i].size(); ++j)
				cout << file_search_res[i][j] << ' ';
			cout << endl;
		}
	if (failed_algos > 0)
		cout << failed_algos << " algo(s) failed!\n";
	else
		cout << "The search was successful!\n";
	cout << "\n##############################################\n\n";
	cout << "Seaching in a string:\n";

	std::array< vector<size_t>, 5> string_search_res;
	string text_from_file = GetFromFile("input.txt");
	for (int i = 0; i < 5; ++i)
	{
		cout << search_names[i] << ": ";
		start = std::chrono::high_resolution_clock::now();
		string_search_res[i] = search_func[i](text_from_file, " then came an incident which was rather unexpected to myself");
		end = std::chrono::high_resolution_clock::now();
		std::chrono::duration<double> time_lapsed = end - start;
		cout << time_lapsed.count() << "s. " << endl;
	}

	failed_algos = 0;
	for (int i = 1; i<5; i++)
		if (file_search_res[i] != file_search_res[0])
		{
			++failed_algos;
			cout << search_names[i] << " failed!\n";
			cout << "Result:\n";
			for (size_t j = 0; j < file_search_res[i].size(); ++j)
				cout << file_search_res[i][j] << ' ';
			cout << endl;
			//cout << "(" << func_res[i][j].first << " " << func_res[i][j].second << ") ";
			cout << endl;
		}
	cout << "\n##############################################\n\n";

	cout << "Searching in a binary pattern:\n";
	string text = GenerateBinaryString(50000000), str = GenerateBinaryString(5000);
	//cout << text << endl << str << endl;
	std::array<vector<size_t>, 5> binary_func_res;
	for (int i = 0; i < 5; ++i)
	{
		cout << search_names[i] << ": ";
		start = std::chrono::high_resolution_clock::now();
		binary_func_res[i] = search_func[i](text, str);
		end = std::chrono::high_resolution_clock::now();
		std::chrono::duration<double> time_lapsed = end - start;
		cout << time_lapsed.count() << "s. " << endl;
	}

	failed_algos = 0;
	for (int i = 1; i<5; i++)
		if (file_search_res[i] != file_search_res[0])
		{
			++failed_algos;
			cout << search_names[i] << " failed!\n";
			cout << "Result:\n";
			for (size_t j = 0; i < binary_func_res[i].size(); ++j)
				cout<<binary_func_res[i][j]<<' ';
			cout << endl;
		}
    return 0;
}

