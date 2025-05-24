using OOP_laba_1.Model;
using OOP_laba_1.Services;
using System;

namespace OOP_laba_1.Controllers
{
    public class FileController
    {
        public void SaveShapes(ShapeList shapeList, string filePath)
        {
            try
            {
                ShapeSerializer.SaveShapes(shapeList, filePath);  // Прямой вызов статического метода
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ошибка при сохранении фигур", ex);
            }
        }

        public ShapeList LoadShapes(string filePath)
        {
            try
            {
                return ShapeSerializer.LoadShapes(filePath);  // Прямой вызов статического метода
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Ошибка при загрузке фигур", ex);
            }
        }
    }
}