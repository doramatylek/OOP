

namespace OOP_laba_1
{
   
    public class Line : Shape
    {
       
        public Line(Color color, float width) : base(color, width)
        {
           
        }
    
        public override void draw(Graphics graphics)
        {
            using (Pen pen = new Pen(penColor, penWidth))
            { 
                    graphics.DrawLine(pen, startPoint, endPoint);
            }
        }
    }
}
