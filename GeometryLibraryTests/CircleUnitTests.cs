using GeometryLibrary;

namespace GeometryLibraryTests
{
    public class CircleUnitTests
    {
        [Theory]
        [InlineData(-1)]
        [InlineData(-10)]
        public void Constructor_NegativeRadius_ThrowsArgumentException(double radius)
        {
            Assert.Throws<ArgumentException>(() => new CircleShape(radius));
        }

        [Theory]
        [InlineData(2, 12.566)]
        [InlineData(3, 28.274)]
        public void GetArea_ReturnsCorrectResult(double radius, double expectedArea)
        {
            var circle = new CircleShape(radius);
            double actualArea = circle.GetArea();

            Assert.Equal(expectedArea, actualArea, 3);
        }

        [Theory]
        [InlineData(2, 12.566)]
        [InlineData(3, 18.85)]
        public void GetPerimeter_ReturnsCorrectResult(double radius, double expectedPerimeter)
        {
            var circle = new CircleShape(radius);
            double actualPerimeter = circle.GetPerimeter();

            Assert.Equal(expectedPerimeter, actualPerimeter, 3);
        }
    }
}