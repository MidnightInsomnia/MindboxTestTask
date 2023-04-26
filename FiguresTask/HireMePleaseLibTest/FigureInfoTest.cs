using HireMePlease;

namespace HireMePleaseLibTest
{
    public class FigureInfoTest
    {
        [Theory]

        [InlineData(2.0, 3.0)]
        [InlineData(0.0, 0.0, 0.0)]
        [InlineData(0.0, -1.0, -2.0)]
        [InlineData(4.0, 4.0, 4.0, 4.0)]
        [InlineData(3.0, 4.0, 5.0, 6.0, 7.0)]
        public void CalculateArea_must_throw_argument_exception(params double[] sides)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                FigureInfo.CalculateArea(sides);
            });
        }

        [Theory]
        [InlineData(2.0)]
        [InlineData(7.0, 8.0, 9.0)]
        public void CalculateArea_double(params double[] sides)
        {
            Assert.IsType<double>(FigureInfo.CalculateArea(sides));
        }

        [Theory]
        [InlineData(0.0, 0.0, 0.0)]
        [InlineData(1.0, 1.0, 5.0)]
        [InlineData(5.0, 1.0, 1.0)]
        [InlineData(1.0, 5.0, 1.0)]
        [InlineData(-3.0, -1.0, -2.0)]
        public void IsTriangleRectangular_must_throw_argument_exception(double sideA, double sideB, double sideC)
        {
            Assert.Throws<ArgumentException>(() =>
            {
                FigureInfo.IsTriangleRectangular(sideA, sideB, sideC);
            });
        }

        [Theory]
        [InlineData(2.0, 3.0, 4.0)]
        public void IsTriangleRectangular_bool(double sideA, double sideB, double sideC)
        {
            Assert.IsType<bool>(FigureInfo.IsTriangleRectangular(sideA, sideB, sideC));
        }

        [Theory]
        [InlineData(3.0, 4.0, 5.0)]
        [InlineData(6.0, 8.0, 10.0)]
        public void IsTriangleRectangular_bool_true(double sideA, double sideB, double sideC)
        {
            Assert.True(FigureInfo.IsTriangleRectangular(sideA, sideB, sideC));
        }

        [Theory]
        [InlineData(3.0, 3.0, 5.0)]
        [InlineData(6.0, 8.0, 14.0)]
        public void IsTriangleRectangular_bool_false(double sideA, double sideB, double sideC)
        {
            Assert.False(FigureInfo.IsTriangleRectangular(sideA, sideB, sideC));
        }
    }
}