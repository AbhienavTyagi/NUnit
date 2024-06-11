

using NUnit.Framework;
using NUnit;
namespace TestClass
{
    [TestFixture]
    public class TriangleTest1
    {
        // Abhinav Tyagi
        [Test]
        public void ValidTriangle_Input60and60and60_OutputValidTriangle()
        {
            // Arrange
            int firstAngle = 60;
            int secondAngle = 90;
            int thirdAngle = 30;
            string expected = "The triangle is valid.";
            // Act
            string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}