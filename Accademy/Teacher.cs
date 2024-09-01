using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Accademy
{
	internal class Teacher: Human
	{
		public string Speciality { get; set; }
		int expirience;
		public int Expirience
		{
			get => expirience;
			set => expirience = value < 70 ? value : 70;
		}
		public Teacher
			(string lastName, string firstName, uint age,
			string speciality, int expirience
			): base(lastName, firstName, age)
		{
			Speciality = speciality;
			Expirience = expirience;
            Console.WriteLine($"TConstr: \t{GetHashCode()}");
		}
		~Teacher() { Console.WriteLine($"TDestr: \t{GetHashCode()}"); }
		public void Print()
		{
			base.Print();
			Console.WriteLine($"{Speciality} {Expirience}");
		}
		public override string ToString()
		{
			return base.ToString() + $"{Speciality}, {Expirience}";
		}
	}
}
