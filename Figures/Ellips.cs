using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab2
{
    class Ellips:Abs
    {
        public void fillArr(Point click, Graphics canvas, Pen pen)
        {
            canvas.DrawEllipse(pen, click.X-150, click.Y-100, 300, 200);
        }
    }
}
