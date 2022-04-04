using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace lab2
{
    class Square:Figure
    {
        private int width = 150;
        private int height = 150;
        public override void Draw(Graphics canvas, Point click)
        {
            canvas.DrawRectangle(pen, click.X-width/2, click.Y-height/2, width,height);
        }
    }
}
