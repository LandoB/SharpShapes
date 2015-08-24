using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;

namespace UnitTestShapes
{
    [TestClass]
    public class SquareTest
    {
        [TestMethod]
        public void TestConstructSetAllFourSides()
        {
            Square mySquare = new Square(4);
            Assert.AreEqual(4,mySquare.Top);
        }
    }

}
