using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_laba_1
{
    public class Rectangle: Shape
    {
        private PointF _topLeft;
        private float _width;
        private float _height;

        public Rectangle(Color color, int width, PointF topLeft, float widthS, float heightS)
            : base(color, width)
        {
            _topLeft = topLeft;
            this._width = widthS;
            this._height = heightS;
        }

        public override void Draw(Graphics graphics)
        {
            using (Pen pen = new Pen(_color, _width))
            {
                graphics.DrawRectangle(pen, _topLeft.X, _topLeft.Y, _width, _height);
            }
        }
    }
}
