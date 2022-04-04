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
        public virtual void Draw(Graphics canvas, Point click)
        {
            //do smth
        }
    }
}
