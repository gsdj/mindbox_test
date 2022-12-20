using FigureLibrary;
using FigureLibrary.Figures;
using Xunit;

namespace Tests
{
    public class TriangleTests
    {
        [Fact]
        public void NegativeSidesTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, -1, -1));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-1, 0, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, -1, 0));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 0, -1));
        }

        [Fact]
        public void CalculationTest()
        {
            Figure f = new Triangle(7, 24, 25);

            double areaTriangleResult = f.GetFigureArea();

            Assert.Equal(84, areaTriangleResult);
        }

        [Fact]
        public void IsRectangularTrueTest()
        {
            IRectangular tr = new Triangle(7, 24, 25);

            bool isRectangular = tr.IsRectangular();

            Assert.True(isRectangular);
        }

        [Fact]
        public void IsRectangularFalseTest()
        {
            IRectangular tr = new Triangle(7, 24, 26);

            bool isRectangular = tr.IsRectangular();

            Assert.False(isRectangular);
        }
   }
}