using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_laba_1
{
    public class Line : Shape
    {
        private Point _start;
        private Point _end;

        public Line(Color color, int width, Point start, Point end) : base(color, width)
        {
            _start = start;
            _end = end;
        }

        public override void Draw(Graphics graphics)
        {
            using (Pen pen = new Pen(_color, _width))
            {
                graphics.DrawLine(pen, _start, _end);
            }
        }
    }
}
