
namespace OOP_laba_1.Model
{
    public class DrawingSettings
    {
        public Color Color { get; set; } = Color.Black;
        public Color FillColor { get; set; } = Color.White;
        public float PenWidth { get; set; } = 1;
        public int Corners { get; set; } = 3;
        public string CurrentShapeType { get; set; }
    }
}
