using HireMePlease.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireMePlease.Figures
{
    internal class Triangle : IFigure
    {
        public string FigureName => "Треугольник";

        public double Radius { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double[] FigureSides { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            FigureSides = new double[] {sideA, sideB, sideC};
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
            var halfPerimeter = CalculatePerimeter()/2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - FigureSides[0]) * (halfPerimeter - FigureSides[1] * (halfPerimeter - FigureSides[2])));
        }

        public bool IsRectangular()
        {
            if (FigureSides[0] * FigureSides[0] + FigureSides[1] * FigureSides[1] == FigureSides[2] * FigureSides[2])
                return true;

            return false;
        }
    }
}
