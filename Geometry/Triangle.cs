using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Geometry
{
	internal class Triangle : Rectangle
	{
		public Triangle(int start_x, int start_y, int line_width, int width,int height) : base(start_x, start_y, line_width, width, height) { }

		public override int GetArea() { return (Width * Height) / 2; }
		public override int GetPerimeter()
		{
			double fnHipotenz = Math.Sqrt(Math.Pow((Width / 2), 2) + Math.Pow(Height, 2));
			return (Width + 2 * (int)fnHipotenz);
		}
		public override void Draw()
		{
			Bitmap bitmap = new Bitmap(150, 20, System.Drawing.Imaging.PixelFormat.Format32bppPArgb);
			Graphics graphics = Graphics.FromImage(bitmap);
			Pen pen = new Pen(System.Drawing.Color.FromArgb(0, 77, 77, 77), LineWidth);
			graphics.DrawPolygon(pen,
				new[] {
					new Point(Start_X, Start_Y),
					new Point(Start_X + Width, Start_Y),
					new Point(Start_X + (Width / 2), Start_Y + Height),
					new Point(Start_X, Start_Y)
				});
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