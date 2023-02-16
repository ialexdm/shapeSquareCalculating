namespace ShapeSquareCalculating.figures
{
    public class Triangle : Shape
    {
        public double ASide
        {
            get; init;
        }
        public double BSide
        {
            get; init;
        }
        public double CSide
        {
            get; init;
        }

        public Triangle(double aSide, double bSide, double cSide)
        {
            ValidateSides(aSide, bSide, cSide);
            ASide = aSide;
            BSide = bSide;
            CSide = cSide;
        }

        private static void ValidateSides(double aSide, double bSide, double cSide)
        {
            if (aSide <= 0 || aSide >= bSide + cSide)
            {
                throw new ArgumentException($"{aSide} is incorrect. Side must be less than amount of another sides and bigger than zero");
            }
            if (bSide <= 0 || bSide >= aSide + cSide)
            {
                throw new ArgumentException($"{bSide} is incorrect. Side must be less than amount of another sides");
            }
            if (cSide <= 0 || cSide >= aSide + bSide)
            {
                throw new ArgumentException($"{cSide} is incorrect. Side must be less than amount of another sides");
            }
        }

        protected override double CalculateSquare()
        {
            if (isTriangleSquare(out double firstCathet, out double secondCathet))
            {
                return firstCathet * secondCathet / 2.0d;
            }
            var halfPerimeter = (ASide + BSide + CSide) / 2.0d;
            var square = Math.Sqrt(halfPerimeter *
                (halfPerimeter - ASide) * 
                (halfPerimeter - BSide) *
                (halfPerimeter - CSide));
            return square;
        }

        private bool isTriangleSquare(out double firstCathet, out double secondCathet)
        {
            double hypotenuse;
            if (ASide > BSide && ASide > CSide)
            {
                hypotenuse = ASide;
                firstCathet = BSide;
                secondCathet = CSide;
            }
            else
            {
                if (BSide > CSide && BSide > ASide)
                {
                    hypotenuse = BSide;
                    firstCathet = ASide;
                    secondCathet = CSide;
                }

                else
                {
                    hypotenuse = CSide;
                    firstCathet = ASide;
                    secondCathet = BSide;
                }
            }
            bool isSquare = Math.Abs(Math.Pow(firstCathet, 2) + Math.Pow(secondCathet, 2) - Math.Pow(hypotenuse, 2)) < 0.000001;
            return isSquare;


        }
    }
}
