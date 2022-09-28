using ShapeSquareCalculating.figures;

namespace ShapeSquareCalculating.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void CalculateSquareTests_WithASideBiggerThanOtherSidesAmount_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                double invalidASide = 4.0d;
                double validbSide = 2.0d;
                double validcSide = 1.0d;

                var square = new Triangle(invalidASide, validbSide, validcSide).Square;
            });
        }
        [Fact]
        public void CalculateSquareTests_WithBSideBiggerThanOtherSidesAmount_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                double validASide = 2.0d;
                double invalidbSide = 4.0d;
                double validcSide = 1.0d;

                var square = new Triangle(validASide, invalidbSide, validcSide).Square;
            });
        }
        [Fact]
        public void CalculateSquareTests_WithCSideBiggerThanOtherSidesAmount_ThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                double validASide = 2.0d;
                double validbSide = 1.0d;
                double invalidcSide = 4.0d;

                var square = new Triangle(validASide, validbSide, invalidcSide).Square;
            });
        }
        [Fact]
        public void CalculateSquareTests_WithValidSides_ReturnsSquare()
        {

            double validASide = 2.0d;
            double validbSide = 3.0d;
            double validcSide = 4.0d;
            var halfPerimeter = (validASide + validbSide + validcSide) / 2;
            var validSquare = Math.Sqrt(halfPerimeter *
                (halfPerimeter - validASide) *
                (halfPerimeter - validbSide) *
                (halfPerimeter - validcSide));
            Assert.Equal(validSquare, new Triangle(validASide, validbSide, validcSide).Square);
        }
        [Fact]
        public void CalculateSquareTests_WithSqaureTriangle_ReturnsSquare()
        {

            double validASide = 1;
            double validbSide = 1;
            double validcSide = Math.Sqrt(2);
            double validSquare = validASide * validbSide / 2;
            Assert.Equal(validSquare, new Triangle(validASide, validbSide, validcSide).Square);
        }
    }
}
