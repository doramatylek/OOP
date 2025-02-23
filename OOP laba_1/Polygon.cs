using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_laba_1
{
    public class Polygon : Shape
    {
        private int _sides;  
        private float _radius; 
        private PointF _center; 

        public Polygon(Color color, int width, PointF center, int sides, float radius)
            : base(color, width)
        {
            _sides = sides;
            _radius = radius;
            _center = center;
        }

       
        public override void Draw(Graphics graphics)
        {
            if (_sides < 3) return; 

            PointF[] points = new PointF[_sides];
            double angle = 2 * Math.PI / _sides; 

            for (int i = 0; i < _sides; i++)
            {
                float x = _center.X + (float)(Math.Cos(angle * i) * _radius);
                float y = _center.Y + (float)(Math.Sin(angle * i) * _radius);
                points[i] = new PointF(x, y);
            }

            using (Pen pen = new Pen(_color, _width))
            {
                graphics.DrawPolygon(pen, points);
            }
        }
    }
}
