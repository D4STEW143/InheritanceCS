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
			return base.ToString() + $"{Speciality.PadRight(25)}{Expirience.ToString().PadRight(5)}";
		}
		public override string ToFileString()
		{
			return $"{base.ToFileString()}, {Speciality}, {Expirience}";
		}
		public override void Init(string[] values)
		{
			base.Init(values);
			Speciality = values[4];
			Expirience = Convert.ToInt32(values[5]);
		}
	}
}
