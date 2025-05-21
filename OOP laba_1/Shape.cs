
namespace OOP_laba_1
{
    public abstract class Shape
    {

        public Color penColor { get; set; }
        public float penWidth { get; set; }
        public  Point startPoint { get; set; }
        public  Point endPoint { get; set; }

      
        public Shape(Color color, float width)
        {
            penColor = color;
            penWidth = width;
        }

        public abstract void draw(Graphics graphics);
    }


}
