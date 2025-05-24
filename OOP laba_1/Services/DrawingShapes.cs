using OOP_laba_1.Model;
using OOP_laba_1.Model.Shapes;


namespace OOP_laba_1.Services
{
    public class DrawingShapes
    {
        private readonly ShapeList _shapeList;
        private readonly DrawingSettings _settings;

        private Shape _currentShape;
        private bool _isDrawing;
        private Point _startPoint, _endPoint;
      
        public DrawingShapes(ShapeList shapeList, DrawingSettings settings)
        {
            _shapeList = shapeList;
            _settings = settings;
        }

        public void StartDrawing(Point location)
        {
            if (_settings.CurrentShapeType == null) return;

            _isDrawing = true;
            _startPoint = _endPoint = location;

            if (_currentShape == null || !_currentShape.isMultiClick)
            {
                _currentShape = ShapeFactory.CreateShape(
                    _settings.CurrentShapeType,
                    _settings.Color,
                    _settings.PenWidth,
                    _settings.FillColor,
                    _settings.Corners);
            }

            if (_currentShape.isMultiClick)
            {
                _currentShape.updateShape(location);
            }
        }

        public void CompleteDrawing()
        {
            if (!_isDrawing || _currentShape == null) return;

           
            if (!_currentShape.isMultiClick && IsValidShape())
            {
                SetShapePoints();
                _shapeList.AddShape(_currentShape);
                ResetCurrentShape();
            }
          
        }
        public void UpdateDrawing(Point location)
        {
            if (!_isDrawing || _currentShape == null) return;

            _endPoint = location;
            if (_currentShape.isMultiClick)
                _currentShape.endPoint = _endPoint;
        }

       

        public void Draw(Graphics graphics)
        {
            _shapeList.DrawAll(graphics);

            if (_currentShape != null)
            {
                SetShapePoints();
                _currentShape.draw(graphics);
            }
        }

        public void FinalizeMultiClickShape()
        {
            if (_currentShape?.isMultiClick == true)
            {
                _currentShape.updateShape(_endPoint);
                _shapeList.AddShape(_currentShape);
                ResetCurrentShape();
            }
        }

        private bool IsValidShape()
            => Math.Abs(_startPoint.X - _endPoint.X) > 2 ||
               Math.Abs(_startPoint.Y - _endPoint.Y) > 2;

        private void SetShapePoints()
        {
            _currentShape.startPoint = _startPoint;
            _currentShape.endPoint = _endPoint;
        }

        private void ResetCurrentShape()
        {
            _currentShape = null;
            _isDrawing = false;
        }
    }
}