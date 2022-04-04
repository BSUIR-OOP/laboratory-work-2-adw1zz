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
            figures.Add(new Circle());
            figures.Add(new Ellips());
            figures.Add(new Rect());
            figures.Add(new Rhombus());
            figures.Add(new Square());
            figures.Add(new Triangle());
        }

        public Graphics canvas;
        Point click;

        List<Figure> figures = new List<Figure>();

        private void MainForm_MouseClick(object sender, MouseEventArgs e)
        {
            click = e.Location;
            canvas = CreateGraphics();
            canvas.Clear(Color.Azure);
            int index = comboBox1.SelectedIndex;
            if (index != -1)
            {
                figures[index].Draw(canvas, click);
            }
        }

    }
}
