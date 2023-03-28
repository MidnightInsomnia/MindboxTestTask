using HireMePlease.Interfaces;

namespace HireMePlease.Figures
{
    internal class Circle : IFigure
    {
        public string FigureName => "Круг";

        public double Radius { get ; set; }
        public double[] FigureSides { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculatePerimeter()
        {
            return Math.PI * 2 * Radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2.0);
        }

        public bool IsRectangular()
        {
            throw new NotImplementedException();
        }
    }
}
