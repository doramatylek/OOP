
namespace OOP_laba_1
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
            _shapeTypes["Rectangle"] = typeof(Rectangle);
            _shapeTypes["Polygon"] = typeof(Polygon);
            _shapeTypes["Polyline"] = typeof(Polyline);
        }

        public static void RegisterShape(string name, Type shapeType)
        {
            if (!typeof(Shape).IsAssignableFrom(shapeType))
                throw new ArgumentException("Тип должен наследоваться от Shape");

            _shapeTypes[name] = shapeType;
        }

        public static Shape CreateShape(string shapeTypeName, Color penColor, Color fillColor, float penWidth, params object[] additionalArgs)
        {
            if (!_shapeTypes.TryGetValue(shapeTypeName, out Type shapeType))
                throw new ArgumentException($"Тип фигуры '{shapeTypeName}' не зарегистрирован");

           
            if (shapeType == typeof(Line))
            {
                return CreateLine(penColor, penWidth);
            }

            if (shapeType == typeof(Polyline))
            {
                return CreatePolyline(penColor, penWidth);
            }

           
            return CreateStandardShape(shapeType, penColor, fillColor, penWidth, additionalArgs);
        }

        private static Shape CreateLine(Color penColor, float penWidth)
        {
            
            var constructors = typeof(Line).GetConstructors();

            var constructor = constructors.FirstOrDefault(c =>
                c.GetParameters().Length == 2 &&
                c.GetParameters()[0].ParameterType == typeof(Color) &&
                c.GetParameters()[1].ParameterType == typeof(float));
          
                return (Line)constructor.Invoke(new object[] { penColor, penWidth });
           
        }

        private static Shape CreatePolyline(Color penColor, float penWidth)
        {
           
            var constructors = typeof(Polyline).GetConstructors();

            var constructor = constructors.FirstOrDefault(c =>
                c.GetParameters().Length == 2 &&
                c.GetParameters()[0].ParameterType == typeof(Color) &&
                c.GetParameters()[1].ParameterType == typeof(float));

                return (Polyline)constructor.Invoke(new object[] { penColor, penWidth });
        }

        private static Shape CreateStandardShape(Type shapeType, Color penColor, Color fillColor, float penWidth, object[] additionalArgs)
        {
            var allArgs = new List<object> { penColor, fillColor, penWidth };
            if (additionalArgs != null)
            {
                allArgs.AddRange(additionalArgs);
            }

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