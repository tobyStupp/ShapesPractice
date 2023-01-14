using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHapesP
{
    class Triangle :Shape
    {
        private int width;
        public Triangle(Point tl, int len, int width, Color color)
            :base (tl, len, color)
        {
            this.width = width;
        }

        public override void Draw(Graphics g)
        {
            Point[] points = { topLeft, new Point(topLeft.X, topLeft.Y + length), new Point(topLeft.X + width, topLeft.Y + length) };
            g.FillPolygon(new SolidBrush(color), points);
        }

        public override double GetArea()
        {
            throw new NotImplementedException();
        }
    }
}
