

namespace OOP_laba_1
{

    public class Polygon : Shape
    {
        public Color fill { get; set; }
        public int sides;

        public Polygon(Color color, Color fillColor, float width, int n) : base(color, width)
        {
            sides = n;
            fill = fillColor;
        }
     
        public override void draw(Graphics graphics)
        {
            PointF[] points = new PointF[sides];
            double angle = 2 * Math.PI / sides;

            float radius = (float)Math.Sqrt(Math.Pow(endPoint.X - startPoint.X, 2) + Math.Pow(endPoint.Y - startPoint.Y, 2));
            PointF center = new PointF(startPoint.X, startPoint.Y);

            double rotationAngle = Math.Atan2(endPoint.Y - startPoint.Y, endPoint.X - startPoint.X) - Math.PI / 2;

            for (int i = 0; i < sides; i++)
            {
                float x = center.X + (float)(Math.Cos(rotationAngle + angle * i) * radius);
                float y = center.Y + (float)(Math.Sin(rotationAngle + angle * i) * radius);
                points[i] = new PointF(x, y);
            }

            using (Pen pen = new Pen(penColor, penWidth))
            {
                using (Brush brush = new SolidBrush(fill))
                {
                    graphics.FillPolygon(brush, points);
                    graphics.DrawPolygon(pen, points);
                }
            }
        }
    }
}