namespace ShapeSquareCalculating.figures
{
    public abstract class Shape
    {
        public double Square
        {
            get { return CalculateSquare(); }
        }

        protected abstract double CalculateSquare();
    }
}