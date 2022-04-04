using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Triangle:Figure
    {

        private Point[] fillArray(Point click)
        {
            Point point1 = new Point(click.X + 100, click.Y);
            Point point2 = new Point(click.X, click.Y + 200);
            Point point3 = new Point(click.X + 200, click.Y + 200);
            Point[] points =
            {
                point1,
                point2,
                point3
            };

            return points;
        }
        public override void Draw(Graphics canvas, Point click)
        {
            Point[] array = fillArray(click);

            canvas.DrawPolygon(pen, array);

        }
    }
}
