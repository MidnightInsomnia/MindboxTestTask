using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HireMePlease.Interfaces
{
    //Добавление новых свойств
    public interface IFigure
    {
        public string FigureName { get; }
        public double Radius { get; set; }
        public double[] FigureSides { get; set; }
        public abstract double CalculatePerimeter();
        public abstract double CalculateArea();
        public abstract bool IsRectangular();
    }
}
