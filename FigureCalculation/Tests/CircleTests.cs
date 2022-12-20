using FigureLibrary;
using FigureLibrary.Figures;
using Xunit;

namespace Tests
{
    public class CircleTests
    {
        [Fact]
        public void NegativeRadiusTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-1));
        }

        [Fact]
        public void CalculationTest()
        {
            Figure f = new Circle(6);

            double areaCircleResult = f.GetFigureArea();

            Assert.Equal(113.09733552923255, areaCircleResult);
        }
    }
}