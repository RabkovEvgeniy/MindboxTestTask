using Shapes.Exceptions;

namespace Shapes.Tests
{
    public class TriangleTests
    {
        [Fact]
        public void Constructor_OneSideLessThenZero_ShapeExceptionThrown()
        {
            //Arrange
            decimal sideA1 = -1;
            decimal sideB1 = 4;
            decimal sideC1 = 5;

            decimal sideA2 = -1;
            decimal sideB2 = 4;
            decimal sideC2 = 5;

            decimal sideA3 = 3;
            decimal sideB3 = 4;
            decimal sideC3 = -1;

            string expectedErrorMessage = "Sides of triangle must be greater than 0";

            //Act
            Action constructTriangle1 = () => new Triangle(sideA1, sideB1, sideC1);
            Action constructTriangle2 = () => new Triangle(sideA2, sideB2, sideC2);
            Action constructTriangle3 = () => new Triangle(sideA3, sideB3, sideC3);

            //Assert
            ShapeException ex1 = Assert.Throws<ShapeException>(constructTriangle1);
            ShapeException ex2 = Assert.Throws<ShapeException>(constructTriangle2);
            ShapeException ex3 = Assert.Throws<ShapeException>(constructTriangle3);

            Assert.Equal(expectedErrorMessage, ex1.Message);
            Assert.Equal(expectedErrorMessage, ex1.Message);
            Assert.Equal(expectedErrorMessage, ex1.Message);
        }

        [Fact]
        public void Constructor_OneSideEqualToZero_ShapeExceptionThrown()
        {
            //Arrange
            decimal sideA1 = 0;
            decimal sideB1 = 4;
            decimal sideC1 = 5;

            decimal sideA2 = 0;
            decimal sideB2 = 4;
            decimal sideC2 = 5;

            decimal sideA3 = 3;
            decimal sideB3 = 4;
            decimal sideC3 = 0;

            string expectedErrorMessage = "Sides of triangle must be greater than 0";

            //Act
            Action constructTriangle1 = () => new Triangle(sideA1, sideB1, sideC1);
            Action constructTriangle2 = () => new Triangle(sideA2, sideB2, sideC2);
            Action constructTriangle3 = () => new Triangle(sideA3, sideB3, sideC3);

            //Assert
            ShapeException ex1 = Assert.Throws<ShapeException>(constructTriangle1);
            ShapeException ex2 = Assert.Throws<ShapeException>(constructTriangle2);
            ShapeException ex3 = Assert.Throws<ShapeException>(constructTriangle3);

            Assert.Equal(expectedErrorMessage, ex1.Message);
            Assert.Equal(expectedErrorMessage, ex1.Message);
            Assert.Equal(expectedErrorMessage, ex1.Message);
        }

        [Fact]
        public void Constructor_SumOfTwoSidesLessThanThirdSide_ShapeExceptionThrown()
        {
            //Arrange
            decimal sideA1 = 1;
            decimal sideB1 = 1;
            decimal sideC1 = 3;

            decimal sideA2 = 1;
            decimal sideB2 = 3;
            decimal sideC2 = 1;

            decimal sideA3 = 1;
            decimal sideB3 = 1;
            decimal sideC3 = 3;

            string expectedErrorMessage = "Sum of two sides of triangle must be greater than third side";

            //Act
            Action constructTriangle1 = () => new Triangle(sideA1, sideB1, sideC1);
            Action constructTriangle2 = () => new Triangle(sideA2, sideB2, sideC2);
            Action constructTriangle3 = () => new Triangle(sideA3, sideB3, sideC3);

            //Assert
            ShapeException ex1 = Assert.Throws<ShapeException>(constructTriangle1);
            ShapeException ex2 = Assert.Throws<ShapeException>(constructTriangle2);
            ShapeException ex3 = Assert.Throws<ShapeException>(constructTriangle3);

            Assert.Equal(expectedErrorMessage, ex1.Message);
            Assert.Equal(expectedErrorMessage, ex1.Message);
            Assert.Equal(expectedErrorMessage, ex1.Message);
        }

        [Fact]
        public void CalculateSquare_RightTriangle_SquareCalculated—orrectlyWith10Precision()
        {
            //Arrange
            Triangle rightTriangle = new(3, 4, 5);
            double expectedSquare = 6;
            int precision = 10;

            //Act
            double square = rightTriangle.CalculateSquare();

            //Assert
            Assert.Equal(expectedSquare, square, precision); 
        }

        [Fact]
        public void CalculateSquare_IsoscelesTriangle_SquareCalculated—orrectlyWith10Precision()
        {
            //Arrange
            Triangle isoscelesTriangle = new(3, 3, 5);
            double expectedSquare = 4.14578098794424981139366592;
            int precision = 10;

            //Act
            double square = isoscelesTriangle.CalculateSquare();

            //Assert
            Assert.Equal(expectedSquare, square, precision);
        }

        [Fact]
        public void CalculateSquare_Triangle_SquareCalculated—orrectlyWith10Precision()
        {
            //Arrange
            Triangle triangle = new(2, 4, 5);
            double expectedSquare = 3.799671038392666;
            int precision = 10;

            //Act
            double square = triangle.CalculateSquare();

            //Assert
            Assert.Equal(expectedSquare, square, precision);
        }

        [Fact]
        public void CheckIsRight_RightTriangle_True()
        {
            //Arrange
            Triangle rightTriangle = new(3, 4, 5);

            //Act
            bool isRightTriangle = rightTriangle.CheckIsRight();

            //Assert
            Assert.True(isRightTriangle);
        }

        [Fact]
        public void CheckIsRight_NotRightTriangle_False()
        {
            //Arrange
            Triangle triangle = new(4, 3, 6);

            //Act
            bool isRightTriangle = triangle.CheckIsRight();

            //Assert
            Assert.False(isRightTriangle);
        }
    }
}