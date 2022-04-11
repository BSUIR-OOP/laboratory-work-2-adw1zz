using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            figures.Add(new Circle("Circle"));
            figures.Add(new Ellips("Ellips"));
            figures.Add(new Rect("Rectangle"));
            figures.Add(new Rhombus("Rhombus"));
            figures.Add(new Square("Square"));
            figures.Add(new Triangle("Triangle"));
            comboBox1.SelectedIndex = 0;
            canvas = CreateGraphics();
        }

        public Graphics canvas;
        Point click;

        List<Figure> figures = new List<Figure>();

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {

            click = e.Location;
            string current;
            canvas.Clear(Color.Azure);
            int index = comboBox1.SelectedIndex;

            for (int i =0; i<figures.Count; i++)
            {
                current = comboBox1.Items[index].ToString();
                if (current == figures[i].Name)
                {

                    if (current == "Ellips" || current == "Circle")
                    {
                        figures[i].Draw(canvas, click);
                    }
                    else
                    canvas.DrawPolygon(figures[i].pen, figures[i].fillArray(click));
                    
                }
            }
        }

    } 
}
