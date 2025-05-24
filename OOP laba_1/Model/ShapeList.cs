using OOP_laba_1.Model.Shapes;

namespace OOP_laba_1.Model
{
    public class ShapeList
    {
        private List<Shape> shapes = new List<Shape>();
        private Stack<Shape> undoStack = new Stack<Shape>();
        private Stack<Shape> redoStack = new Stack<Shape>();

        public List<Shape> GetShapes()
        {
            return new List<Shape>(shapes);
        }
        public void AddShape(Shape shape)
        {
            shapes.Add(shape);
            undoStack.Push(shape);
            redoStack.Clear();
        }

        public void Undo()
        {
            if (undoStack.Count > 0)
            {
                Shape shape = undoStack.Pop();
                shapes.Remove(shape);
                redoStack.Push(shape);
            }
        }

        public void Redo()
        {
            if (redoStack.Count > 0)
            {
                Shape shape = redoStack.Pop();
                shapes.Add(shape);
                undoStack.Push(shape);
            }
        }
        public void DrawAll(Graphics graphics)
        {
            foreach (var shape in shapes)
            {
                shape.draw(graphics);
            }
        }

        public void RestoreStacks()
        {
            undoStack.Clear();
            redoStack.Clear();

            foreach (var shape in shapes)
            {
                undoStack.Push(shape); 
            }
        }

    }
}