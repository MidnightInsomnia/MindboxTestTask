using HireMePlease.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireMePlease.Figures
{
    internal class Square : IFigure
    {
        private double _side = 0;

        internal Square(double side)
        {
            if (side < 0)
            {
                throw new ArgumentException();
            }

            _side = side;
        }

        public string FigureName => "Квадрат";

        public double Radius { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double[] FigureSides { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        double IFigure.CalculateArea()
        {
            return _side * _side;
        }

        double IFigure.CalculatePerimeter()
        {
            return _side * 4.0;
        }

        bool IFigure.IsRectangular()
        {
            throw new NotImplementedException();
        }
    }
}
