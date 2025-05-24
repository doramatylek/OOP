using System.Drawing;
using OOP_laba_1.Model.Shapes;

namespace Plugins
{
    class Class1 : Shape
    {

        public Class1(Color color, float width) : base(color, width)
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
