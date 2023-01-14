using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SHapesP
{
    public  abstract class Shape
    {
        protected Point topLeft;
        protected Color color;
        protected int length;
        public Shape (Point topLeft, int length, Color color )
        {
            this.topLeft = topLeft;
            this.color = color;
            this.length = length;
        }
        public Shape(int x, int y, int length,Color c) : this(new Point(x, y), length,c) { }
        public Point GetPoint() => topLeft;
        public void SetPoint(Point p) => this.topLeft = p;
        public Color GetColor() => color;
        public void SetColor(Color c) => this.color = c;
        public int GetLength() => length;
        public void SetLength(int length) => this.length = length;
        public abstract double GetArea();
        public abstract void Draw(Graphics g);
    }
}
