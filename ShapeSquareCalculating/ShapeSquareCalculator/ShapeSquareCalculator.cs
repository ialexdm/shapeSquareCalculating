using ShapeSquareCalculating.figures;

namespace ShapeSquareCalculating.Application
{
    public class ShapeSquareCalculator
    {
        public double CalculateSquare(double radius)
        {
            return ShapeFactory.GetShape(radius).Square;
        }
        public double CalculateSquare(double aSide, double bSide, double cSide)
        {
            return ShapeFactory.GetShape(aSide,bSide,cSide).Square;
        }
    }
}