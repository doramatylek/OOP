using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_laba_1
{
     public class Polyline : Shape
    {
        private Point[] _points;

        public Polyline(Color color, int width, Point[] points) : base(color, width)
        {
            _points = points;
        }

        public override void Draw(Graphics graphics)
        {
            using (Pen pen = new Pen(_color, _width))
            {
                graphics.DrawLines(pen, _points);
            }
        }
    }
}
