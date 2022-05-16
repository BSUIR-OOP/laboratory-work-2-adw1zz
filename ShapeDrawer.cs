using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace lab2
{
    static class ShapeDrawer
    {

        private static bool Isimplemented(Type type, string name)
        {
            var interfaceType = type.GetInterfaces()
                .FirstOrDefault(t => t.Name == name);
            return interfaceType != null;
        }

        public static void DrawFigure(IAbs figure, Graphics canvas, Point click)
        {
            Pen pen = new Pen(Color.Black, 3);
            if (Isimplemented(figure.GetType(), "INonPolygon"))
            {
                float[] arr = figure.FloatArr(click);
                canvas.DrawEllipse(pen, arr[0], arr[1], arr[2], arr[3]);
            }
            else
            {
                canvas.DrawPolygon(pen, figure.PointArr(click));
            }
        }
    }
}
