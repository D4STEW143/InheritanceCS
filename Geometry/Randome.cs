using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
	internal class Randome
	{
		public FatherOfAll[] RandGroup(FatherOfAll[] group)
		{
			Random random = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
			for (int i = group.Length - 2; i >= 0; i--)
			{
				int j = random.Next(i + 1);
				FatherOfAll temp = group[j];
				group[j] = group[i];
				group[i] = temp;
			}
			return group;
		}
	}
}
