

namespace OOP_laba_1
{
 
    public class Polyline : Shape
    {
        private List<Point> points;

        public Polyline(Color color, float width) : base(color, width)
        {
            points = new List<Point>();
        }
    
        public void addPoint(Point point)
        {
            points.Add(point);
        }

        public override void draw(Graphics graphics)
        {
           

            using (Pen pen = new Pen(penColor, penWidth))
            {
                graphics.DrawLine(pen, startPoint, endPoint);
                if (points.Count > 1) 
                { 
                    graphics.DrawLines(pen, points.ToArray()); 
                } 
                
            }
        }

    
    }
}