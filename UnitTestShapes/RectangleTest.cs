using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace UnitTestShapes
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void RectangleAreaTest()
        {
            var testRectangle = new Rectangles();
            testRectangle.Side1 = 4;
            testRectangle.Side2 = 6;

            Assert.AreEqual(testRectangle.Area(), 24);
        }

        [TestMethod]
        public void RectanglePerimeterTest()
        {
            var testRectangle = new Rectangles();
            testRectangle.Side1 = 4;
            testRectangle.Side2 = 6;

            Assert.AreEqual(testRectangle.Perimeter(), 20);
        }
    }
}
