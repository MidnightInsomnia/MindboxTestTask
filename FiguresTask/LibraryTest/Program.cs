using HireMePlease;


var figureOne = FigureInfo.InitiateFigure(alias:"Фигура 01", 2.0);
var figureTwo = FigureInfo.InitiateFigure(alias: "Фигура 02", 3, 4, 5);
var figureThree = FigureInfo.InitiateFigure(alias: "Фигура 03", 2, 2, 2, 2);

Console.WriteLine($"{figureOne.GetShapeName()} с именем {figureOne.GetAlias()} имеет площадь {figureOne.CalculateArea()} ");
Console.WriteLine($"{figureTwo.GetShapeName()} с именем {figureTwo.GetAlias()} имеет площадь {figureTwo.CalculateArea()} ");
Console.WriteLine($"{figureTwo.GetShapeName()} с именем {figureTwo.GetAlias()} прямоугольный? {figureTwo.IsRectangular()} ");
Console.WriteLine($"{figureThree.GetShapeName()} с именем {figureThree.GetAlias()} имеет площадь {figureThree.CalculateArea()} ");