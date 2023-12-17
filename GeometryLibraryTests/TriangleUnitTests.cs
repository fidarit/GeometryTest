using GeometryLibrary;

namespace GeometryLibraryTests
{
    public class TriangleUnitTests
    {
        [Theory]
        [InlineData(1, 2, 5)]
        [InlineData(1, 2, 3)]
        public void Constructor_InvalidSides_ThrowsArgumentException(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => new TriangleShape(a, b, c));
        }

        [Theory]
        [InlineData(3, 4, 5, 6)]
        public void GetArea_ReturnsCorrectResult(double a, double b, double c, double expectedArea)
        {
            var triangle = new TriangleShape(a, b, c);
            double result = triangle.GetArea();

            Assert.Equal(expectedArea, result, 3);
        }

        [Theory]
        [InlineData(3, 4, 5, 12)]
        public void GetPerimeter_ReturnsCorrectResult(double a, double b, double c, double expectedPerimeter)
        {
            var triangle = new TriangleShape(a, b, c);
            double result = triangle.GetPerimeter();

            Assert.Equal(expectedPerimeter, result, 3);
        }

        [Theory]
        [InlineData(3, 4, 5, true)]
        [InlineData(2, 3, 4, false)]
        public void IsRightTriangle_ReturnsCorrectResult(double a, double b, double c, bool expectedResult)
        {
            var triangle = new TriangleShape(a, b, c);
            bool result = triangle.IsRightTriangle();

            Assert.Equal(expectedResult, result);
        }
    }
}