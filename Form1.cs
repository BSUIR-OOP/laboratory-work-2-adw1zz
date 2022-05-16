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
    public partial class Form1 : Form
    {
        Point click;

        Graphics canvas;

        private Dictionary<int, IAbs> figures = new Dictionary<int, IAbs>();

        public Form1()
        {
            InitializeComponent();
            canvas = CreateGraphics();
            figures.Add(0,new Circle());
            figures.Add(1,new Square());
            figures.Add(2,new Rectangle());
            figures.Add(3,new Rhombus());
            figures.Add(4,new Triangle());
            figures.Add(5,new Ellipse());
            comboBoxInit();
            comboBox1.SelectedIndex = 0;
        }

        private void comboBoxInit()
        {
            this.comboBox1.Items.Clear();
            foreach(var key in this.figures.Keys)
            {
                this.comboBox1.Items.Add(this.figures[key].GetType().Name);
            }
        }



        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            click = e.Location;
            canvas.Clear(Color.White);

            int index = comboBox1.SelectedIndex;
      
            ShapeDrawer.DrawFigure(this.figures[index],canvas,click);
            
           
        }

    }
}
