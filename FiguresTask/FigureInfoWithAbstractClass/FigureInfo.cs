using HireMePlease.Figures;
using System.Drawing;

namespace HireMePlease
{
    public class FigureInfo
    {
        /// <summary>
        /// Создаёт фигуру о которой нужно получить информацию
        /// </summary>
        /// <param name="alias">Псевдоним для фигуры</param>
        /// <param name="side">Длина сторон фигуры</param>
        /// <returns>Экземпляр фигуры; Если фигура с введёнными параметрами отсутствует в библиотеке выбрасывается исключение</returns>
        public static Figure InitiateFigure(string alias, params double[] side)
        {
            try
            {
                switch (side.Length)
                {
                    case 0:
                        throw new ArgumentException("Не указаны длины сторон");
                    case 1:
                        return InitiateFigure(alias, side[0]);
                    case 2:
                        throw new ArgumentException("Фигура с такими параметрами отсутствует в библиотеке");
                    case 3:
                        Triangle triangle = new Triangle(alias, side[0], side[1], side[2]);
                        return triangle;
                    case 4:
                        if (side[0] == side[1] && side[0] == side[2] && side[0] == side[3])
                        {
                            Square square = new Square(alias, side[0]);
                            return square;
                        }
                        throw new ArgumentException("Фигура с такими параметрами отсутствует в библиотеке");
                        //Добавление новых n-угольников
                }

                throw new ArgumentException("Фигура с такими параметрами отсутствует в библиотеке");
            }
            catch (NullReferenceException)
            {
                throw new NullReferenceException("Параметры не могут быть null");
            }
        }

        /// <summary>
        /// Создаёт фигуру о которой нужно получить информацию, если вам нужен квадрат - указывайте длины всех сторон
        /// </summary>
        /// <param name="alias">Псевдоним для фигуры</param>
        /// <param name="radius">значение радиуса double</param>
        /// <returns>Экземпляр фигуры; Если фигура с введёнными параметрами отсутствует в библиотеке выбрасывается исключение</returns>
        public static Figure InitiateFigure(string alias, double radius)
        {
            try
            {
                Circle circle = new Circle(alias, radius);

                return circle;
            }
            catch(NullReferenceException)
            {
                throw new NullReferenceException("Параметры не могут быть null");
            }
        }

        //Добавление новых перегрузок для фигур с иными параметрами
    }
}