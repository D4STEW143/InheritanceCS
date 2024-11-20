using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    abstract internal class FatherOfAll
    {
        int start_x, start_y, lineWidth;

        public int Start_X
        {
            get => start_x;
            set
            {
                if (value > 150) start_x = 150;
                else if (20 <= value && value <= 150) start_x = value;
                else Start_X = 20;
            }
        }
        public int Start_Y
        {
            get => start_y;
            set
            {
                if (value > 30) start_y = 30;
                else if (5 <= value && value <= 30) start_y = value;
                else Start_Y = 5;
            }
        }
        public int LineWidth
        {
            get => lineWidth;
            set
            {
                if (value < 10) lineWidth = 10;
                else if (5 <= value && value <=10) lineWidth = value;
                else lineWidth = 5;
            }
        }

        public FatherOfAll(int start_x, int start_y, int lineWidth)
        {
            Start_X = start_x;
            Start_Y = start_y;
            LineWidth = lineWidth;
        }

        public abstract int GetArea();
        public abstract int GetPerimeter();
        public abstract void Draw();
        public virtual void Info()
        {
            Console.WriteLine($"Area is {GetArea()}");
            Console.WriteLine($"Perimeter is {GetPerimeter()}");
            Draw();
        }




    }
}
