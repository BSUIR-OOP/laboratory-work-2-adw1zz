using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace lab2
{
    class Square:Figure
    {

        public Square(string name)
        {
            base.Name = name;
        }

        public override Point[] fillArray(Point click)
        {
            Point point1 = new Point(click.X- 75, click.Y - 75);
            Point point2 = new Point(click.X + 75, click.Y - 75);
            Point point3 = new Point(click.X + 75, click.Y + 75);
            Point point4 = new Point(click.X - 75, click.Y + 75);

            Point[] points =
            {
                point1,
                point2,
                point3,
                point4
            };


            return points;
        }
    }
}
