using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHapesP
{
    public partial class Form1 : Form
    {
        private List<Shape> shapes;
        private ShapeType currentType = ShapeType.RECTANGLE;
        private Point topLeft;
        public Form1()
        {
            InitializeComponent();
            topLeft.X = -1;
            shapes = new List<Shape>();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Shape s in shapes)
                s.Draw(e.Graphics);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentType = ShapeType.RECTANGLE;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            currentType = ShapeType.CIRCLE;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            currentType = ShapeType.TRIANGLE;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (topLeft.X == -1)
                topLeft = e.Location;
            else
            {
                int width = e.X - topLeft.X;
                int len = e.Y - topLeft.Y;
             
                switch (currentType)
                {
                    case ShapeType.RECTANGLE:
                        shapes.Add(new Rectangle(topLeft, width, len, Color.Green));
                        break;
                    case ShapeType.CIRCLE:
                        shapes.Add(new Circle(topLeft, len, Color.Blue));
                        break;
                    default:
                        shapes.Add(new Triangle(topLeft,len, width, Color.Blue));
                         
                        break;
                }
                topLeft.X = -1;
                Refresh();
            }
        }
    }
}
