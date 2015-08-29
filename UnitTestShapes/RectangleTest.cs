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
            var testRectangle = new Rectangle(4,6);

            Assert.AreEqual(testRectangle.Area(), 36);
        }

        [TestMethod]
        public void RectanglePerimeterTest()
        {
            var testRectangle = new Rectangle(3,5);

            Assert.AreEqual(testRectangle.Perimeter(), 16);
        }
    }
}
