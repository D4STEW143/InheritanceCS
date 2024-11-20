//#define FILE_201
#define _201_DHCPD

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace FileCS
{
	internal class Program
	{
		static void Main(string[] args)
		{
#if FILE_201
			string input_file = "201 RAW.txt";
			string output_file = "201 READY.txt";

			StreamReader sr = new StreamReader(input_file);
			StreamWriter sw = new StreamWriter(output_file);

			try
			{
				while (!sr.EndOfStream)
				{
					string buffer = (sr.ReadLine());
					if (buffer.Length > 1)
					{
						string[] values = buffer.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
						Console.WriteLine($"{values[1]}\t{values[0]}");
						sw.WriteLine($"{values[1]}\t{values[0]}");
					}
					else 
					{ 
						Console.WriteLine();
						sw.WriteLine();
					}
					
                }
				sr.Close();
				sw.Close();

				System.Diagnostics.Process.Start("notepad", output_file);
			}
			catch (Exception ex) 
			{
                Console.WriteLine(ex.Message);
            }
#endif


#if _201_DHCPD
			string input_file = "201 RAW.txt";
			string output_file = "201.dhcpd.txt";

			StreamReader sr = new StreamReader(input_file);
			StreamWriter sw = new StreamWriter(output_file);

			try
			{
				uint count = 1;
				while (!sr.EndOfStream)
				{
					string buffer = (sr.ReadLine());

					if (buffer.Length > 1)
					{
						string[] values = buffer.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
						string output = $"host-{count}\n" +
							$"{{\n" +
							$"\thardware ethernet\t{values[1]};\n" +
							$"\tfixed address\t\t{values[0]};\n" +
							$"}}\n";
						Console.WriteLine(output);
						sw.WriteLine(output);
						count++;
					}
				}
				sr.Close();
				sw.Close();

				System.Diagnostics.Process.Start("notepad", output_file);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.Message);
			}
#endif
		}
	}
}
