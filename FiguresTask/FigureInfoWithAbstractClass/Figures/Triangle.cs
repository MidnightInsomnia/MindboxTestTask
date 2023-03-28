namespace HireMePlease.Figures
{
    internal class Triangle : Figure
    {
        private double _sideA = 0;
        private double _sideB = 0;
        private double _sideC = 0;

        internal Triangle(string alias, double sideA, double sideB, double sideC) : base(alias, "Треугольник")
        {
            if (sideA < 0 || sideB < 0 || sideC < 0)
            {
                throw new ArgumentException("Длина стороны фигуры не может быть меньше 0");
            }

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }

        public override double CalculatePerimeter()
        {
            return _sideA + _sideB + _sideC;
        }

        public override double CalculateArea()
        {
            var halfPerimeter = CalculatePerimeter() / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - _sideA) * (halfPerimeter - _sideB * (halfPerimeter - _sideC)));
        }

        public override bool IsRectangular()
        {
            if (_sideA * _sideA + _sideB * _sideB == _sideC * _sideC)
                return true;

            return false;
        }
    }
}
