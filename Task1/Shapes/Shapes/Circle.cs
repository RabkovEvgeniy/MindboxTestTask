using Shapes.Abstractions;
using Shapes.Exceptions;

namespace Shapes
{
    public class Circle : IFlatShape
    {
        public decimal Radius { get; private set; }

        public Circle(decimal radius)
        {
            if (radius <= 0) 
            {
                throw new ShapeException("Radius of the circle must be greater than 0");
            }

            Radius = radius;
        }

        public double CalculateSquare()
        {
            return Math.PI * Math.Pow((double)Radius, 2);
        }
    }
}
