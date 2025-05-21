
using System.Text.Json.Serialization;

namespace OOP_laba_1
{

    [JsonConverter(typeof(JsonStringEnumConverter))]
    public abstract class Shape
    {

        public Color penColor { get; set; }
        public float penWidth { get; set; }
        public virtual Point startPoint { get; set; }
        public virtual Point endPoint { get; set; }

      
        public Shape(Color color, float width)
        {
            penColor = color;
            penWidth = width;
        }

        public abstract void draw(Graphics graphics);
    }


}
