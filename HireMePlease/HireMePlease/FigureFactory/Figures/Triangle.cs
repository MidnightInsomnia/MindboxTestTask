using HireMePlease.FigureFactory.Interfaces;

namespace HireMePlease.FigureFactory.Figures
{
    internal class Triangle : INGon
    {
        public double[] FigureSides { get; set; }
        public Triangle(double sideA, double sideB, double sideC)
        {
            if (!IsTriangleExists(sideA, sideB, sideC)) 
                throw new ArgumentException("А triangle with such sides does not exist.");

            FigureSides = new double[] { sideA, sideB, sideC };
        }

        public double CalculatePerimeter()
        {
            double perimeter = 0;
            foreach (var side in FigureSides)
            {
                perimeter += side;
            }

            return perimeter;
        }

        public double CalculateArea()
        {
            var halfPerimeter = CalculatePerimeter() / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - FigureSides[0]) * (halfPerimeter - FigureSides[1] * (halfPerimeter - FigureSides[2])));
        }

        public bool IsRectangular()
        {
            if (FigureSides[0] * FigureSides[0] + FigureSides[1] * FigureSides[1] == FigureSides[2] * FigureSides[2])
                return true;

            return false;
        }

        public bool IsTriangleExists(double sideA, double sideB, double sideC)
        {
            if (sideA + sideB < sideC)
                return false;

            if (sideA + sideC < sideB)
                return false;

            if (sideB + sideC < sideA)
                return false;

            return true;
        }
    }
}