using HireMePlease.Figures;
using HireMePlease.Interfaces;

namespace HireMePlease
{
    public class FigureInfoWithInterfaces
    {
        public static IFigure InitiateFigure(params double[] side) 
        {
            switch(side.Length)
            {
                case 2:
                    throw new ArgumentException();
                case 3:
                    Triangle triangle = new Triangle(side[0], side[1], side[2]);
                    return triangle;
                case 4:
                    if (side[0] == side[1] && side[0] == side[2] && side[0] == side[3])
                    {
                        Square square = new Square(side[0]);
                        return square;
                    }
                    throw new ArgumentException();
                    //Обработка новых N-угольников
            }

            throw new ArgumentException();
        }

        public static IFigure InitiateFigure(double radius)
        {
            Circle circle = new Circle(radius);

            return circle;
        }
    }
}