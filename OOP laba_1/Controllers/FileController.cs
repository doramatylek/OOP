using OOP_laba_1.Model;
using OOP_laba_1.Services;


namespace OOP_laba_1.Controllers
{
    public class FileController
    {
        public void SaveShapes(ShapeList shapeList, string filePath)
        {
            try
            {
                FileManager.SaveShapes(shapeList, filePath);  
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ошибка при сохранении фигур", ex);
            }
        }

        public void LoadShapes(ShapeList shapeList, string filePath)
        {
            try
            {
                FileManager.LoadShapes(shapeList, filePath);  
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ошибка при загрузке фигур", ex);
            }
        }
    }
}