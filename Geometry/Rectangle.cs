using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Configuration;

namespace Geometry
{
	internal class Rectangle : Square
	{
		int height;
		public int Height
		{
			get => height;
			set { height = (value > 0) ? value : 0; }
		}

		public Rectangle(int start_x, int start_y, int line_width, int width,int height) : base(start_x, start_y, line_width, width)
		{
			Height = height;
		}

		public override int GetArea() { return Width * Height; }
		public override int GetPerimeter() { return 2 * (Width + Height); }
		public override void Draw()
		{
			Bitmap bitmap = new Bitmap(150, 20, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
			Graphics graphics = Graphics.FromImage(bitmap);
			Pen pen = new Pen(System.Drawing.Color.FromArgb(0, 77, 77, 77), LineWidth);
			graphics.DrawRectangle(pen, Start_X, Start_Y, Width, Height);
		}
		public override void Info()
		{
			Console.WriteLine($"{base.ToString().Split('.').Last()}");
			Console.WriteLine($"Area is {GetArea()}");
			Console.WriteLine($"Perimeter is {GetPerimeter()}");
			Console.WriteLine($"Width is {Width}");
			Console.WriteLine($"Height is {Height}");
			Draw();
			Console.WriteLine();
		}
	}
}