namespace ShapeSquareCalculating.figures
{
    public class Circle : Shape
    {
        private double _radius;
        public double Radius
        {
            get { return _radius; }
            init
            {
                ValidateRadius(value);
                _radius = value;
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        protected override double CalculateSquare()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        private void ValidateRadius(double radius)
        {
            if (radius <= 0)
            {
                throw new ArgumentException($"Circle is incorrect. {nameof(radius)} must be bigger than zero.");
            }
        }
    }
}
