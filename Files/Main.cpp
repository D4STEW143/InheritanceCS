#include<iostream>
#include<fstream>

using std::cout;
using std::cin;
using std::endl;

//#define WRITE_TO_FILE
//#define READ_FROM_FILE
#define HOMEWORK_TXT_SWAP

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

	//	1) Прочитать информацию из файла
	std::ifstream fin("201 RAW.txt");
	if (fin.is_open())
	{
		while (!fin.eof())
		{
			const int SIZE = 128;
			char buffer[SIZE]{};
			fin.getline(buffer, SIZE);
			cout << buffer << endl;
		}
	}
	else
	{
		std::cerr << "Error: file not found" << endl;
	}

	//	2) 


#endif // HOMEWORK_TXT_SWAP

}