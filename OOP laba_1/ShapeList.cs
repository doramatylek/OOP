
using Newtonsoft.Json;

namespace OOP_laba_1
{
    public class ShapeList
    {
        private List<Shape> shapes = new List<Shape>();
        private Stack<Shape> undoStack = new Stack<Shape>();
        private Stack<Shape> redoStack = new Stack<Shape>();

        public void addShape(Shape shape)
        {
            shapes.Add(shape);
            undoStack.Push(shape);
            redoStack.Clear();
           
        }

        public void undo()
        {
            if (undoStack.Count > 0)
            {
                Shape shape = undoStack.Pop();
                shapes.Remove(shape);
                redoStack.Push(shape);
            }
        }

        public void redo()
        {
            if (redoStack.Count > 0)
            {
                Shape shape = redoStack.Pop();
                shapes.Add(shape);
                undoStack.Push(shape);
            }
        }

        public void drawAll(Graphics graphics)
        {
            foreach (var shape in shapes)
            {
                shape.draw(graphics);
            }
        }

        public void serialize(string filePath)
        {
            string json = JsonConvert.SerializeObject(shapes, new JsonSerializerSettings{ TypeNameHandling = TypeNameHandling.Auto});
            File.WriteAllText(filePath, json);
        }

        public void deserialize(string filePath)
        {
            string json = File.ReadAllText(filePath);
            shapes = JsonConvert.DeserializeObject<List<Shape>>(json, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });
            undoStack.Clear();
            redoStack.Clear();
            foreach (var shape in shapes)
            {
                undoStack.Push(shape);
            }
        }
    }
}