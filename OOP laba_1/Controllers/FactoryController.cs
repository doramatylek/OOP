using OOP_laba_1.Model.Shapes;
using OOP_laba_1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_laba_1.Controllers
{
    class FactoryController
    {
        public Shape CreateShape(string shapeType, Color color, float penWidth, Color fillColor, int corners)
        {
            try
            {
                return ShapeFactory.CreateShape(
                    shapeType,
                    color,
                    penWidth,
                    fillColor,
                    corners
                );
            }
            catch (ArgumentException ex)
            {
                throw new InvalidOperationException($"Ошибка создания фигуры: {ex.Message}", ex);
            }
            catch (MissingMethodException ex)
            {
                throw new InvalidOperationException("Невозможно создать фигуру с указанными параметрами", ex);
            }
        }

        public void RegisterPluginShape(string shapeName, Type shapeType)
        {
            try
            {
                ShapeFactory.RegisterShape(shapeName, shapeType);
            }
            catch (ArgumentException ex)
            {
                throw new InvalidOperationException($"Ошибка регистрации плагина: {ex.Message}", ex);
            }
        }

    }
}
