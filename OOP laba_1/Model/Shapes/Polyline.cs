namespace OOP_laba_1.Model.Shapes
{
 
    public class Polyline : Shape
    {
        private List<Point> points;
        public override bool isMultiClick { get; } = true;
        public Polyline(Color color, float width) : base(color, width)
        {
            points = new List<Point>();
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
        public override void updateShape(Point point)
        {
            points.Add(point);
            endPoint = point;
        }



    }
}