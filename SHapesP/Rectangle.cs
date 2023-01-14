using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHapesP
{
    public class Rectangle : Shape
    {
        private int width;
        public Rectangle (Point p, int length, int width, Color c)
            :base (p,length,c)
        {
            this.width = width;
        }
        public override void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(color), topLeft.X, topLeft.Y, GetLength(), width);
        }

        public override double GetArea()
        {
            return GetLength() * width;
        }
    }
}
