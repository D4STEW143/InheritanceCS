using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy
{
	internal class Graduate: Student
	{
		public string Subject { get; set; }
		public Graduate(
				string lastName, string firstName, uint age,
				string speciality, string group, double rating, double attendance,
				string subject
			):base(lastName, firstName, age, speciality, group, rating, attendance)
		{
			Subject = subject;
            Console.WriteLine($"GConstr: \t{GetHashCode()}");
		}
		public Graduate(Student student, string subject):base(student)
		{
			Subject=subject;
            Console.WriteLine($"GConstr: \t{GetHashCode()}"); 
		}
		~Graduate() { Console.WriteLine($"GDestr: \t{GetHashCode()}"); }
		public void Print()
		{
			base.Print();
            Console.WriteLine($"{Subject}");
		}
		public override string ToString()
		{
			return base.ToString()+ $", {Subject}";
		}
	}
}
