using HireMePlease.FigureFactory.Figures;
using HireMePlease.FigureFactory.Interfaces;

namespace HireMePlease.FigureFactory
{
    internal class FigureFactory
    {
        internal static IFigure DetermineFigure(params double[] sides)
        {
            foreach (var side in sides)
            {
                if (side <= 0)
                    throw new ArgumentException("The sides cannot be equal to or less than zero");
            }

            switch (sides.Length)
            {
                case 0:
                    throw new ArgumentException();
                case 1:
                    return new Circle(sides[0]);
                case 2:
                    throw new ArgumentException();
                case 3:
                    return new Triangle(sides[0], sides[1], sides[2]);
                //Обработка новых N-угольников
                default: 
                    throw new ArgumentException();
            }
        }

        internal static Triangle CreateTriangle(double sideA, double sideB, double sideC)
        {
            var fig = DetermineFigure(sideA, sideB, sideC);
            return (Triangle)fig;
        }
    }
}
