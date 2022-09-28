using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSquareCalculating.figures
{
    public static class ShapeFactory
    {
        public static Shape GetShape(double radius)
        {
            return new Circle(radius);
        }
        public static Shape GetShape(double sideA, double sideB, double sideC)
        {
            return new Triangle(sideA, sideB, sideC);
        }

    }
}
