using System.Drawing;
using OOP_laba_1;

namespace Plugins
{
    public class Trapezoid : Shape
    {
        public Color Fill { get; set; }

        public Trapezoid(Color color,  float penWidth, Color fillColor)
            : base(color, penWidth)
        {
            Fill = fillColor;
        }

        public override void draw(Graphics graphics)
        {
           
            int width = Math.Abs(endPoint.X - startPoint.X);
            int height = Math.Abs(endPoint.Y - startPoint.Y);

            int directionX = endPoint.X > startPoint.X ? 1 : -1;
            int directionY = endPoint.Y > startPoint.Y ? 1 : -1;
 
            int offset = (int)(width * 0.2f);

        
            if (width < 100) offset = 20;

           
            Point[] points = {new Point(startPoint.X, startPoint.Y),                            
                              new Point(endPoint.X, startPoint.Y),                                
                              new Point(endPoint.X - (directionX * offset), endPoint.Y),          
                              new Point(startPoint.X + (directionX * offset), endPoint.Y)};
            using (Pen pen = new Pen(penColor, penWidth))
            {
                using (Brush brush = new SolidBrush(Fill))
                {
                    graphics.FillPolygon(brush, points);
                    graphics.DrawPolygon(pen, points);
                }
            }
        }

    }
    }
