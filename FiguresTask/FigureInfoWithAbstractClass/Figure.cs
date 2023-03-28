namespace HireMePlease
{
    public abstract class Figure
    {
        internal string Alias { get; private set; }
        internal string ShapeName { get; private set; }

        protected Figure(string alias, string shapeName)
        {
            Alias = alias;
            ShapeName = shapeName;
        }

        /// <summary>
        /// Вычисление периметра фигуры
        /// </summary>
        /// <returns>Значение периметра фигуры</returns>
        public abstract double CalculatePerimeter();
        /// <summary>
        /// Вычисление площади фигуры
        /// </summary>
        /// <returns>Значение площади фигуры</returns>
        public abstract double CalculateArea();
        /// <summary>
        /// Проверяет является ли треугольник прямоугольным
        /// </summary>
        /// <returns>True - если треугольник прямоугольный, False - если не прямоугольный</returns>
        public abstract bool IsRectangular();
        /// <summary>
        /// Псевдоним фигуры
        /// </summary>
        /// <returns>Строка с псевдонимом фигуры</returns>
        public virtual string GetAlias() => Alias;
        /// <summary>
        /// Название фигуры
        /// </summary>
        /// <returns>Строка с названием фигуры</returns>
        public virtual string GetShapeName() => ShapeName;
    }
}
