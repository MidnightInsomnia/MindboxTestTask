using HireMePlease.FigureFactory.Interfaces;

namespace HireMePlease.FigureFactory.Figures
{
    internal class Circle : IRound
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2.0);
        }
    }
}