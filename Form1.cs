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
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            canvas = CreateGraphics();
            figures.Add(new Triangle());
            figures.Add(new Square());
            figures.Add(new Rectangle());
            figures.Add(new Rhombus());
            figures.Add(new Circle());
            figures.Add(new Ellips());


        }

        Point click;

        Graphics canvas;

        Rectangle rect;
        
        Pen pen = new Pen(Color.Black, 3);

        List<Abs> figures = new List<Abs>();
    

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            click = e.Location;
            canvas.Clear(Color.White);

            int index = comboBox1.SelectedIndex;
           
            for (int i=0; i<figures.Count; i++)
            {
                if (figures[i].ToString()[5..] == comboBox1.Items[index].ToString())
                {
                    try
                    {
                        canvas.DrawPolygon(pen, figures[i].fillArr(click));
                    }
                    catch (Exception)
                    {
                        figures[i].fillArr(click,canvas,pen);
                      
                    }
                }
                
            }
            
           
        }
    }
}
