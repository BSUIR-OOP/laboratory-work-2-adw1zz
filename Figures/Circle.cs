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
        public float[] FloatArr(Point click)
        {
            float[] arr = {click.X - 250/2, click.Y - 250/2,250, 250 };
            return arr;
        }

    }
}
