using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Geometry
{
	internal class Square:FatherOfAll
	{
		int width;
		public int Width
		{
			get => width;
			set { width = (value > 0) ? value : 0; }
		}
		public Square(int start_x, int start_y, int lineWidth, int width):base (start_x, start_y, lineWidth)
		{
			Width = width;
		}

		public override int GetArea() { return Width * Width; }
		public override int GetPerimeter() { return 2 * (Width + Width); }
		public override void Draw()
		{
			Bitmap bitmap = new Bitmap(150, 20, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
			Graphics graphics = Graphics.FromImage(bitmap);
			Pen pen = new Pen(System.Drawing.Color.FromArgb(0, 77, 77, 77), 5);
			graphics.DrawRectangle(pen, Start_X, Start_Y, Width, Width);
		}
		public override void Info()
		{
			Console.WriteLine($"{base.ToString().Split('.').Last()}");
			Console.WriteLine($"Area is {GetArea()}");
			Console.WriteLine($"Perimeter is {GetPerimeter()}");
			Console.WriteLine($"Width is {Width}");
			Draw();
			Console.WriteLine();
		}
	}
}
