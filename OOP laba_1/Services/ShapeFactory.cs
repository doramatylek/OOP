﻿using OOP_laba_1.Model.Shapes;

namespace OOP_laba_1.Services
{
    public static class ShapeFactory
    {
        private static readonly Dictionary<string, Type> _shapeTypes = new Dictionary<string, Type>(StringComparer.OrdinalIgnoreCase);

        static ShapeFactory()
        {
            RegisterDefaultShapes();
        }

        private static void RegisterDefaultShapes()
        {
            _shapeTypes["Line"] = typeof(Line);
            _shapeTypes["Ellipse"] = typeof(Ellipse);
            _shapeTypes["Rectangle"] = typeof(Model.Shapes.Rectangle);
            _shapeTypes["Polygon"] = typeof(Polygon);
            _shapeTypes["Polyline"] = typeof(Polyline);
        }

        public static void RegisterShape(string name, Type shapeType)
        {
            if (!typeof(Shape).IsAssignableFrom(shapeType))
                throw new ArgumentException("Тип должен наследоваться от Shape");

            _shapeTypes[name] = shapeType;
        }

        public static Shape CreateShape(string shapeTypeName, params object[] additionalArgs)
        {
            if (!_shapeTypes.TryGetValue(shapeTypeName, out Type shapeType))
                throw new ArgumentException($"Тип фигуры '{shapeTypeName}' не зарегистрирован");

           
            return CreateStandardShape(shapeType,  additionalArgs);
        }

        private static Shape CreateStandardShape(Type shapeType,  object[] additionalArgs)
        {
            var allArgs = new List<object> { };
          
                allArgs.AddRange(additionalArgs);
          

            foreach (var constructor in shapeType.GetConstructors()
                .OrderByDescending(c => c.GetParameters().Length))
            {
                var parameters = constructor.GetParameters();
                if (parameters.Length > allArgs.Count)
                {
                    continue;
                }

                bool allParamsMatch = true;
                var args = new object[parameters.Length];

                for (int i = 0; i < parameters.Length; i++)
                {
                    if (allArgs[i] != null && !parameters[i].ParameterType.IsInstanceOfType(allArgs[i]))
                    {
                        allParamsMatch = false;
                        break;
                    }
                    args[i] = allArgs[i];
                }

                if (allParamsMatch)
                {
                    try
                    {
                        return (Shape)constructor.Invoke(args);
                    }
                    catch
                    {
                        continue;
                    }
                }
            }

            throw new MissingMethodException($"Не найден подходящий конструктор для {shapeType.Name}");
        }
    }
}