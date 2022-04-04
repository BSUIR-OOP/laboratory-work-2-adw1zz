using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Ellips:Figure
    {
        private int width = 300;
        private int height = 200;
        public override void Draw(Graphics canvas, Point click)
        {
            canvas.DrawEllipse(pen, click.X-width/2, click.Y-height/2, width, height);
            
        }
    }
}
