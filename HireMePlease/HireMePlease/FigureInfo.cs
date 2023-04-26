using static HireMePlease.FigureFactory.FigureFactory;

namespace HireMePlease
{
    public class FigureInfo
    {
        /// <summary>
        /// Вычисляет площадь фигуры. Фигура автоматически определяется по входным параметрам
        /// </summary>
        /// <param name="side">Длины сторон фигуры</param>
        /// <returns>double Площадь фигуры, или ArgumentException,
        /// если фигура с такими параметрами отсутствует</returns>
        public static double CalculateArea(params double[] side)
        {
            var fig = DetermineFigure(side);

            return fig.CalculateArea();
        }

        /// <summary>
        /// Проверяет треугольник на прямоугольность
        /// </summary>
        /// <param name="sideA">Длина стороны A</param>
        /// <param name="sideB">Длина стороны B</param>
        /// <param name="sideC">Длина стороны C</param>
        /// <returns>True - Если треугольник прямоугольный, False - Если нет,
        /// ArgumentException - если треугольник с такими параметрами не существует</returns>
        public static bool IsTriangleRectangular(double sideA, double sideB, double sideC)
        {
            var triangle = CreateTriangle(sideA, sideB, sideC);

            return triangle.IsRectangular();
        }
    }
}