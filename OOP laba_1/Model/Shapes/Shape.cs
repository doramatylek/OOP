namespace OOP_laba_1.Model.Shapes
{
    public abstract class Shape
    {
        public Color penColor { get; set; }
        public float penWidth { get; set; }
        public  Point startPoint { get; set; }
        public  Point endPoint { get; set; }

        public virtual bool isMultiClick { get; } = false;
        public Shape(Color color, float width)
        {
            penColor = color;
            penWidth = width;
        }

        public abstract void draw(Graphics graphics);
        public virtual void updateShape(Point point) {
         
        }
    }


}
