using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SHapesP
{
    public class Circle:Shape
    {
        public Circle(Point topLeft, int radius, Color color) :base (topLeft,radius, color){ }
        public override double GetArea()
        {
            return GetLength() * GetLength() * Math.PI;
        }
        public override void Draw(Graphics g)
        {
            g.FillEllipse(new SolidBrush(color), topLeft.X, topLeft.Y, GetLength(), GetLength());
        }
    }
}
