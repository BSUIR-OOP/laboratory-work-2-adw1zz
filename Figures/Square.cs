using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab2
{
    class Square:IPolygon
    {

        public string Name;

        public Square()
        {
            string name;
            name = this.ToString();
            this.Name = name[5..];
        }

        public Point[] PointArr(Point click)
        {
            Point point1 = new Point(click.X - 75, click.Y - 75);
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
