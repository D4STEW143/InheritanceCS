using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Circle : FatherOfAll
    {
        int radius;
        public int Radius
        {
            get => radius;
            set { radius = (value > 0) ? value : 0; } 
        }
        public Circle(int start_x, int start_y, int lineWidth, int radius):base (start_x, start_y, lineWidth)
        {
            Radius = radius;
        }

        public override int GetArea()
        {
            return (int)Math.Pow((Math.PI * Radius), 2);
        }
        public override int GetPerimeter()
        {
            return (int)(2*(Math.PI * Radius));
        }
        public override void Draw()
        {
            Bitmap bitmap = new Bitmap(150, 20, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(bitmap);
            Pen pen = new Pen(System.Drawing.Color.FromArgb(0, 77, 77, 77),5);
            graphics.DrawEllipse(pen, Start_X, Start_Y, Radius, Radius);
        }
        public override void Info()
        {
            Console.WriteLine($"{base.ToString().Split('.').Last()}");
            Console.WriteLine($"Area is {GetArea()}");
            Console.WriteLine($"Perimeter is {GetPerimeter()}");
            Console.WriteLine($"Radius is {Radius}");
            Draw();
            Console.WriteLine();
        }


    }
}
