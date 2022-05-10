using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab2
{
    class Rectangle:IPolygon
    {
        public Point[] fillArr(Point click)
        {
            Point point1 = new Point(click.X - 150, click.Y - 60);
            Point point2 = new Point(click.X + 150, click.Y - 60);
            Point point3 = new Point(click.X + 150, click.Y + 60);
            Point point4 = new Point(click.X - 150, click.Y + 60);

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
