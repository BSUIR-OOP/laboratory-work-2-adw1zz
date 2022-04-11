using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace lab2
{
    class Figure
    {
        public Pen pen = new Pen(Color.Black, 3);

        public string Name;

        public virtual void Draw(Graphics canvas, Point click)
        {
            //do smth
        }

        public virtual Point[] fillArray(Point click)
        {
            return null;
        }
    }
}
