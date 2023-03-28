namespace HireMePlease.Figures
{
    internal class Circle : Figure
    {
        private double _radius = 0;

        internal Circle(string alias, double radius) : base(alias, "Круг")
        {
            if (radius < 0)
            {
                throw new ArgumentException("Радиус не может быть меньше 0");
            }

            _radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(_radius, 2.0);
        }

        public override double CalculatePerimeter()
        {
            return Math.PI * 2 * _radius;
        }

        public override bool IsRectangular()
        {
            throw new NotImplementedException("Фигура не имеет такого параметра");
        }
    }
}
