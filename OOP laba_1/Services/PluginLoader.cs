using OOP_laba_1.Model.Shapes;
using System.Reflection;


namespace OOP_laba_1.Services
{
    public static class PluginLoader
    {
        public static string LoadPlugin(ToolStripDropDownButton buttonPlugins, string dllPath) // Статический метод
        {
            try
            {
                var assembly = Assembly.LoadFrom(dllPath);
                var pluginShapes = assembly.GetTypes()
                    .Where(t => t.IsSubclassOf(typeof(Shape)) && !t.IsAbstract)
                    .Take(1) // Загружаем только первый найденный тип
                    .ToList();

                if (pluginShapes.Count > 0)
                {
                    var shapeType = pluginShapes[0]; // Получаем первый тип
                    string shapeName = shapeType.Name;

                    // Регистрация фигуры с использованием метода из ShapeFactory
                    ShapeFactory.RegisterShape(shapeName, shapeType);

                    var menuItem = new ToolStripMenuItem(shapeName);
                    buttonPlugins.DropDownItems.Add(menuItem);

                    return shapeName; // Возвращаем имя класса
                }
                return null; // Если не найдено ни одной фигуры
            }
            catch (BadImageFormatException)
            {
                MessageBox.Show("Это не валидная DLL с плагинами",
                                "Ошибка загрузки",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не удалось загрузить плагин: {ex.Message}",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return null;
            }
        }
    }
}