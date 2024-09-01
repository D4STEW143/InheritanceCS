using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Accademy
{
	internal class Student:Human
	{
		public string Speciality { get; set; }
		public string Group { get; set; }
		double rating;
		double attendance;
		public double Rating 
		{
			get => rating;
			set => rating = value < 100 ? value : 100; 
		}
		public double Attendance
		{
			get => attendance;
			set => attendance = value < 100 ? value : 100;
		}

		public Student
			(
				string lastName, string firstName, uint age,
				string speciality, string group, double rating, double attendance
			):base(lastName, firstName, age)
		{
			Init(speciality, group, rating, attendance);
            Console.WriteLine($"SConstr: \t{GetHashCode()}");
		}
		public Student(Human human, string speciality, string group, double rating, double attendance):base(human)
		{
			Init(speciality, group, rating, attendance);
			Console.WriteLine($"SConstr: \t{GetHashCode()}");
		}
		public Student(Student other):base(other)
		{
			Init(other.Speciality, other.Group, other.Rating, other.Attendance);
			Console.WriteLine($"SCopyConstr: \t{GetHashCode()}");
		}
		~Student() { Console.WriteLine($"SDestr: \t{GetHashCode()}"); }
		void Init(string speciality, string group, double rating, double attendance)
		{
			Speciality = speciality;
			Group = group;
			Rating = rating;
			Attendance = attendance;
		}
		public void Print()
		{
			base .Print();
            Console.WriteLine($"{Speciality} {Group} {Rating} {Attendance}");
		}
		public override string ToString()
		{
			return base.ToString()+$"{Speciality}, {Group}, {Rating}, {Attendance}";
		}
	}
}
