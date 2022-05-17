using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab2
{
    class Ellipse: INonPolygon
    {
        public float[] FloatArr(Point click)
        {
            float[] arr = { click.X - 300/ 2, click.Y - 200/ 2, 300, 200 };
            return arr;
        }
    }
}
