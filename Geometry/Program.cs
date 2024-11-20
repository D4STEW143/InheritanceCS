using Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
			FatherOfAll[] Fathers =
			{
				new Square(200, 5, 2, 5),
				new Rectangle(100, 12, 2, 20, 5),
				new Triangle(80, 19, 2, 20, 5),
				new Circle(250, 24, 2, 5)
			};

			Randome rand = new Randome();

			FatherOfAll[] fathersRnd = rand.RandGroup(Fathers);

			for (int i = 0; i < fathersRnd.Length; i++)
			{
				fathersRnd[i].Info();
			}
		}
    }
}

			//new Square(20, 5, 2, 5),
			//	new Rectangle(20, 12, 2, 20, 5),
			//	new Triangle(20, 19, 2, 20, 5),
			//	new Circle(20, 24, 2, 5)
