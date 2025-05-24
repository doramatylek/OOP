using OOP_laba_1.Model.Shapes;

using System.Reflection;


namespace OOP_laba_1.Services
{
    public static class PluginLoader
    {
        public static void LoadAndRegisterPlugin(string dllPath, ToolStripDropDownButton pluginButton, Action<string> onShapeSelected)
        {
            try
            {
                var assembly = Assembly.LoadFrom(dllPath);
                var shapeType = assembly.GetTypes()
                    .FirstOrDefault(t => t.IsSubclassOf(typeof(Shape)) && !t.IsAbstract);

                if (shapeType != null)
                {
                    string shapeName = shapeType.Name;
                    ShapeFactory.RegisterShape(shapeName, shapeType);
                    AddPluginButton(pluginButton, shapeName, onShapeSelected);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка загрузки плагина: {ex.Message}");
            }
        }

        private static void AddPluginButton(ToolStripDropDownButton pluginButton, string shapeName, Action<string> onClick)
        {
            var menuItem = new ToolStripMenuItem(shapeName);
            menuItem.Click += (s, e) => onClick(shapeName);
            pluginButton.DropDownItems.Add(menuItem);
        }
    }
}