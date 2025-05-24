using Newtonsoft.Json;
using OOP_laba_1.Model;
using OOP_laba_1.Model.Shapes;
using System.Collections.Generic;
using System.IO;

namespace OOP_laba_1.Services
{
    public static class FileManager
    {
        public static void SaveShapes(ShapeList shapeList, string filePath)
        {
            try
            {
           
                var shapesToSave = shapeList.GetShapes();
                var settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All,
                    Formatting = Formatting.Indented
                };

                string json = JsonConvert.SerializeObject(shapesToSave, settings);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка сохранения: {ex.Message}");
            }
        }

        public static void LoadShapes(ShapeList shapeList, string filePath)
        {
            try
            {
                string json = File.ReadAllText(filePath);
                var settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.All
                };

              
                var shapes = JsonConvert.DeserializeObject<List<Shape>>(json, settings);

                foreach (var shape in shapes)
                {
                    shapeList.AddShape(shape);
                }
                shapeList.RestoreStacks();



            }
            catch (Exception ex)
            {
                throw new Exception($"Ошибка загрузки: {ex.Message}");
            }
        }
    }
}