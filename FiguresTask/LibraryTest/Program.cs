using HireMePlease;

//Вычисление площади
var circleArea = FigureInfo.CalculateArea(2.0);
var triangleArea = FigureInfo.CalculateArea(3, 4, 5);

//Проверка треугольника на прямоугольность
var isRect = FigureInfo.IsTriangleRectangular(3, 4, 5);

Console.WriteLine($"ПЛОЩАДЬ КРУГА = {circleArea}"); 
Console.WriteLine($"ПЛОЩАДЬ ТРЕУГОЛЬНИКА = {triangleArea}"); 
Console.WriteLine($"ТРЕУГОЛЬНИК ПРЯМОУГОЛЬНЫЙ? {isRect}");