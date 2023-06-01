using Shapes.Abstractions;

namespace Shapes.Tests
{
    public class CommonTests
    {
        [Fact]
        public void CalculateSquare_TypeNotKnownInCompileTime_SquareCalculatedСorrectlyWith10Precision()
        {
            //Arrange
            IFlatShape flatShape;
            double expectedSquare;
            int precision = 10;

            if (new Random().Next(1) == 0) 
            {
                flatShape = new Circle(1);
                expectedSquare = Math.PI;
            }
            else 
            {
                flatShape = new Triangle(3,4,5);
                expectedSquare = 6;
            }

            //Act
            double square = flatShape.CalculateSquare();

            //Assert
            Assert.Equal(expectedSquare, square, precision);
        }
    }
}
