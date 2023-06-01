
using Shapes.Exceptions;

namespace Shapes.Tests
{
    
    public class CircleTests
    {
        [Fact]
        public void Constructor_RadiusLessThenZero_ShapeExceptionThrown()
        {
            //Arrange
            decimal radius = -1;
            string expectedErrorMessage = "Radius of the circle must be greater than 0";

            //Act
            Action constructCircle = () => new Circle(radius);
            
            //Assert
            ShapeException ex = Assert.Throws<ShapeException>(constructCircle);
            Assert.Equal(expectedErrorMessage, ex.Message);
        }

        [Fact]
        public void Constructor_RadiusEqualToZero_ShapeExceptionThrown()
        {
            //Arrange
            decimal radius = 0;
            string expectedErrorMessage = "Radius of the circle must be greater than 0";

            //Act
            Action constructCircle = () => new Circle(radius);

            //Assert
            ShapeException ex = Assert.Throws<ShapeException>(constructCircle);
            Assert.Equal(expectedErrorMessage, ex.Message);
        }

        [Fact]
        public void CalculateSquare_SquareCalculatedСorrectlyWith10Precision()
        {
            //Arrange
            Circle circle = new(1);
            double expectedSquare = Math.PI;
            int precision = 10;

            //Act
            double square = circle.CalculateSquare();

            //Assert
            Assert.Equal(expectedSquare, square, precision);
        }
    }
}
