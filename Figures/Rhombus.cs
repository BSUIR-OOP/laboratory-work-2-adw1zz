using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Rhombus:Figure
    {

        public Rhombus(string name)
        {
            base.Name = name;
        }

        public override Point[] fillArray(Point click)
        {
            Point point1 = new Point(click.X, click.Y-120);
            Point point2 = new Point(click.X + 100, click.Y);
            Point point3 = new Point(click.X, click.Y + 120);
            Point point4 = new Point(click.X-100, click.Y);

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
