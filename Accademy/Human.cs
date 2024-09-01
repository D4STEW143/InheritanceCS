using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy
{
	internal class Human
	{
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public uint Age { get; set; }
		public Human(string lastName, string firstName, uint age) 
		{
			LastName = lastName;
			FirstName = firstName;
			Age = age;
			Console.WriteLine($"HConstr: \t{GetHashCode()}");
		}
		public Human(Human other)
		{
			this.LastName = other.LastName;
			this.FirstName = other.FirstName;
			this.Age = other.Age;
            Console.WriteLine($"HCopyConstr: \t{GetHashCode()}");
		}
		~Human() { Console.WriteLine($"HDestr: \t{GetHashCode()}"); }
		public void Print()
		{
		    Console.WriteLine($"{LastName} {FirstName} {Age}");
		}
		public override string ToString()
		{
			return base.ToString()+$":{LastName} {FirstName} {Age} ";
		}
	}
}
