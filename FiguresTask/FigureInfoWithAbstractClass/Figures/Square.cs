namespace HireMePlease.Figures
{
    internal class Square : Figure
    {
        private double _side = 0;

        internal Square(string alias, double side) : base(alias, "Квадрат")
        {
            if (side < 0)
            {
                throw new ArgumentException("Длина стороны фигуры не может быть меньше 0");
            }

            _side = side;
        }

        public override double CalculateArea()
        {
            return _side * _side;
        }

        public override double CalculatePerimeter()
        {
            return _side * 4.0;
        }


        public override bool IsRectangular()
        {
            throw new NotImplementedException("Фигура не имеет такого параметра");
        }
    }
}
