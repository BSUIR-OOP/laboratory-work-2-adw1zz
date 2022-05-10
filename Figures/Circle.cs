using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab2
{
    class Circle: INonPolygon
    {
        public void fillArr(Point click, Graphics canvas,Pen pen)
        {
            canvas.DrawEllipse(pen, click.X-120, click.Y-120, 240, 240);
        }

    }
}
