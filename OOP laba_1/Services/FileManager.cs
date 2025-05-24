using Newtonsoft.Json;
using OOP_laba_1.Model;


namespace OOP_laba_1.Services
{
    public static class ShapeSerializer
    {
        public static void SaveShapes(ShapeList shapeList, string filePath)
        {
            var json = JsonConvert.SerializeObject(shapeList);
            File.WriteAllText(filePath, json);
        }

        public static ShapeList LoadShapes(string filePath)
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                var loadedShapeList = JsonConvert.DeserializeObject<ShapeList>(json);

                // Восстанавливаем состояние стеков (если необходимо)
                loadedShapeList.RestoreStacks();

                return loadedShapeList;
            }
            return new ShapeList(); // Возвращаем новый список, если файл не найден
        
    }
    }
}
