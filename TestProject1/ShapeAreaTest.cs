using NUnit.Framework;
using ShapeCalculation;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CircleTest()
        {
            double CircleExpected = 78.539816339744833;

            double CircleActual = Shapes.Area(5);
            Assert.AreEqual(CircleExpected, CircleActual);
        }

        [Test]
        public void TriangleTest()
        {
            double TriangleExpected = 0.4330127018922193;
            double TriangleActual = Shapes.Area(1, 1, 1);

            Assert.AreEqual(TriangleExpected, TriangleActual);
        }

        [Test]
        public void RectangularTriangleTest()
        {
            double TriangleExpected = 24;
            double TriangleActual = Shapes.Area(6, 8, 10);

            Assert.AreEqual(TriangleActual, TriangleExpected);
            
        }
    }
}