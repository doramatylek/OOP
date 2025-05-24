namespace OOP_laba_1.Model.Shapes
{
    public class Ellipse : Shape
    {
        public Color fill { get; set; }

        public Ellipse(Color color, float penWidth, Color fillColor) : base(color, penWidth)
        {
            fill = fillColor;
        }

        public override void draw(Graphics graphics)
        {
            
            int x = Math.Min(startPoint.X, endPoint.X);
            int y = Math.Min(startPoint.Y, endPoint.Y);
            int width = Math.Abs(endPoint.X - startPoint.X);
            int height = Math.Abs(endPoint.Y - startPoint.Y);

            using (Pen pen = new Pen(penColor, penWidth))
            {
                using (Brush brush = new SolidBrush(fill))
                {
                    graphics.FillEllipse(brush, x, y, width, height);
                    graphics.DrawEllipse(pen, x, y, width, height);
                }
            }
        }
    }
}