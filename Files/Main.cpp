#include<iostream>
#include<fstream>
#include<string>
#include<vector>

using std::cout;
using std::cin;
using std::endl;

//#define WRITE_TO_FILE
//#define READ_FROM_FILE
//#define HOMEWORK_TXT_SWAP
#define HOMEWORK_DHCDP_FILE


void main()
{
	setlocale(LC_ALL, "");

#ifdef WRITE_TO_FILE
	cout << "Hello world!" << endl;

	std::ofstream fout;		//	1) Создаем поток
	fout.open("File.txt", std::ios_base::app);  //	2) Открываем поток
	fout << "Hello world!" << endl; //	3) Пишем в поток
	fout.close();			//	4) Закрываем поток

	system("notepad File.txt");
#endif // WRITE_TO_FILE

#ifdef READ_FROM_FILE

	std::ifstream fin("File.txt"); //	1) Открытие потока можно совместить с созданием потока. 
	if (fin.is_open())
	{
		//Read from file
		while (!fin.eof())
		{
			const int SIZE = 1536;
			char sz_buffer[SIZE]{};
			//fin >> sz_buffer;	//	Для 'fin', так же как и для 'cin' пробел является основным разделителем.
								//	И для того, чтобы прочитать строку с пробелами, вместо 'cin' используется 'cin.getline()'. 
			fin.getline(sz_buffer, SIZE);
			cout << sz_buffer << endl;
		}
		fin.close();
	}
	else
	{
		std::cerr << "Error: file not found" << endl;
	}
#endif // READ_FROM_FILE

#ifdef HOMEWORK_TXT_SWAP

	std::string input_file = "201 RAW.txt";
	std::string output_file = "201 READY.txt";
	std::ifstream fin(input_file);

	if (!fin.is_open()) { std::cerr << "Error: file not found" << endl; }
	else
	{
		std::ofstream fout;
		fout.open(output_file);

		std::string textLine;
		while (getline(fin, textLine))
		{
			std::string ip = (textLine.size() > 1) ? textLine.substr(0, 14) : " ";
			std::string mac = (textLine.size() > 1) ? textLine.substr(22, 17) : " ";

			cout << mac << "\t" << ip << endl;
			fout << mac << "\t" << ip << endl;
		}
		fin.close();
		fout.close();
	}


#endif // HOMEWORK_TXT_SWAP

#ifdef HOMEWORK_DHCDP_FILE

	std::string input_file = "201 RAW.txt";
	std::string output_file = "201.dhcpd.txt";
	std::ifstream fin(input_file);

	if (!fin.is_open()) { std::cerr << "Error: file " + input_file + " not found!" << endl; }
	else
	{
		std::ofstream fout;
		fout.open(output_file);

		std::string textLine;
		unsigned int count = 1;
		while (getline(fin, textLine))
		{
			std::string ip = (textLine.size() > 1) ? textLine.substr(0, 14) : " ";
			std::string mac = (textLine.size() > 1) ? textLine.substr(22, 17) : " ";

			if (ip != " " && mac != " ")
			{
				std::string output =
					"Host-" + std::to_string(count) + "\n" +
					"{" + "\n" + "\t" +
					"Hardware ethernet" + "\t" + mac + ";" + "\n" +
					"\t" +
					"Fixed address" + "\t\t" + ip + ";" + "\n" +
					"}" + "\n" + "\n";
				cout << output;
				fout << output;

				count++;
			}
		}
		fin.close();
		fout.close();

		system(("notepad " + output_file).c_str());
	}

#endif // HOMEWORK_DHCDP_FILE

}

