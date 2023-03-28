using HireMePlease;
using HireMePlease.Figures;
using Xunit;

namespace HireMePleaseLibTest
{
    public class FigureInfoTest
    {
        [Theory]
        [InlineData("", 2.0)]
        [InlineData("FigureName 01", 2.0)]
        [InlineData("FigureName 02", 2.0, 3.0)]
        [InlineData("FigureName 03", 3.0, 4.0, 5.0)]
        [InlineData("FigureName 04", 4.0, 4.0, 4.0, 4.0)]
        [InlineData("FigureName 05", 3.0, 4.0, 5.0, 6.0)]
        [InlineData("FigureName 06", 3.0, 4.0, 5.0, 6.0, 7.0)]
        public void InitiateFigure_string_double_string_or_exception(string name, params double[] sides)
        {
            // Arrange

            Exception ex;

            // Act & Assert

            switch (sides.Length)
            {
                case 0:
                    ex = Assert.Throws<ArgumentException>(() => FigureInfo.InitiateFigure(name, sides));
                    Assert.Contains("Не указаны длины сторон", ex.Message);
                    break;

                case 1:
                    Assert.Equal("Круг", FigureInfo.InitiateFigure(name, sides).GetShapeName());
                    break;

                case 2:
                    ex = Assert.Throws<ArgumentException>(() => FigureInfo.InitiateFigure(name, sides));
                    Assert.Contains("Фигура с такими параметрами отсутствует в библиотеке", ex.Message);
                    break;

                case 3:
                    Assert.Equal("Треугольник", FigureInfo.InitiateFigure(name, sides).GetShapeName());
                    break;

                case 4:
                    if (sides[0] == sides[1] && sides[0] == sides[2] && sides[0] == sides[3])
                    {
                        Assert.Equal("Квадрат", FigureInfo.InitiateFigure(name, sides).GetShapeName());
                        break;
                    }

                    ex = Assert.Throws<ArgumentException>(() => FigureInfo.InitiateFigure(name, sides));
                    Assert.Contains("Фигура с такими параметрами отсутствует в библиотеке", ex.Message);
                    break;

                default:
                    ex = Assert.Throws<ArgumentException>(() => FigureInfo.InitiateFigure(name, sides));
                    Assert.Contains("Фигура с такими параметрами отсутствует в библиотеке", ex.Message);
                    break;
            }
        }

        [Theory]
        [InlineData("", 2.0)]
        [InlineData("FigureName 01", 2.0)]
        public void InitiateFigure_string_radius_string_or_exception(string name, double radius)
        {
            Assert.Equal("Круг", FigureInfo.InitiateFigure(name, radius).GetShapeName());
        }

        [Theory]
        [InlineData(null, null)]
        public void InitiateFigure_null_null_nullReferenceException(string name, params double[] sides)
        {
            var ex = Assert.Throws<NullReferenceException>(() => FigureInfo.InitiateFigure(name, sides));
            Assert.Contains("Параметры не могут быть null", ex.Message);
        }
    }
}