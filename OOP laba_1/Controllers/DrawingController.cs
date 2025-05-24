using OOP_laba_1.Services;

namespace OOP_laba_1.Controllers
{
    public class DrawingController
    {
        private readonly DrawingShapes _drawingService;

        public DrawingController(DrawingShapes drawingService)
        {
            _drawingService = drawingService;
        }

        public void StartDrawing(Point location)
            => _drawingService.StartDrawing(location);

        public void UpdateDrawing(Point location)
            => _drawingService.UpdateDrawing(location);

        public void CompleteDrawing()
            => _drawingService.CompleteDrawing();

        public void Draw(Graphics graphics)
            => _drawingService.Draw(graphics);

        public void FinalizeMultiClickShape()
            => _drawingService.FinalizeMultiClickShape();
    }
}
