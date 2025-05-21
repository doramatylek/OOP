
namespace OOP_laba_1
{
   
    public class Rectangle: Shape
    {
        public Color fill { get; set; }
        public Rectangle(Color color, float penWidth, Color fillColor) : base(color, penWidth)
        {
            fill = fillColor;
        }

      
        public override void draw(Graphics graphics)
        {
            Point leftCorner = new Point(Math.Min(startPoint.X, endPoint.X), Math.Min(startPoint.Y, endPoint.Y));
            Point rightCorner = new Point(Math.Max(startPoint.X, endPoint.X), Math.Max(startPoint.Y, endPoint.Y));
            using (Pen pen = new Pen(penColor, penWidth))
            {
                using (Brush brush = new SolidBrush(fill))
                {
                    graphics.FillRectangle(brush, leftCorner.X, leftCorner.Y, rightCorner.X - leftCorner.X, rightCorner.Y - leftCorner.Y);
                    graphics.DrawRectangle(pen, leftCorner.X, leftCorner.Y, rightCorner.X - leftCorner.X, rightCorner.Y - leftCorner.Y);
                }
            }
        }
    }
}
