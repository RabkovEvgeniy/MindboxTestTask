using Shapes.Abstractions;
using Shapes.Exceptions;

namespace Shapes
{
    public class Triangle: IFlatShape
    {
        public decimal SideA { get; private set; }
        public decimal SideB { get; private set; }
        public decimal SideC { get; private set; }

        public Triangle(decimal sideA, decimal sideB, decimal sideC) 
        {
            ValidateSides(sideA, sideB, sideC);
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double CalculateSquare()
        {
            decimal perimeterHalf = (SideA + SideB + SideC) / 2;
            return Math.Sqrt((double)(perimeterHalf 
                * (perimeterHalf - SideA) 
                * (perimeterHalf - SideB) 
                * (perimeterHalf - SideC)));
        }

        public bool CheckIsRight() 
        {
            decimal[] sides = { SideA, SideB, SideC };
            Array.Sort(sides);
            return sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2];
        }

        private static void ValidateSides(decimal sideA, decimal sideB, decimal sideC) 
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ShapeException("Sides of triangle must be greater than 0");
            }
            
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA)
            {
                throw new ShapeException("Sum of two sides of triangle must be greater than third side");
            }
        }
    }
}
