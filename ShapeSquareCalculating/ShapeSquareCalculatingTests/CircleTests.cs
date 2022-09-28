using ShapeSquareCalculating.figures;

namespace ShapeSquareCalculating.Tests
{
    public class CircleTests
    {
        [Fact]
        public void CalculateSquareTest_WithZeroRadius_ThrowArgumentException()
        {

            Assert.Throws<ArgumentException>(() =>
            {
                double zeroRadius = 0.0d;
                var square = new Circle(zeroRadius).Square;
            });
        }
        [Fact]
        public void CalculateSquareTest_WithNegativeRadius_ThrowArgumentException()
        {

            Assert.Throws<ArgumentException>(() =>
            {
                double negativeoRadius = -1.0d;
                var square = new Circle(negativeoRadius).Square;
            });
        }
        [Fact]
        public void CalculateSquareTest_WithValidRadius_ReturnsSquare()
        {
            var validRadius = 10.0d;
            var validSquare = Math.PI * Math.Pow(validRadius, 2);
            Assert.Equal(validSquare, new Circle(validRadius).Square);

        }
    }
}