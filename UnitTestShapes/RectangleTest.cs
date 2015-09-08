using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes;
using System.Reflection;
using System.Linq;

namespace UnitTestShapes
{
    [TestClass]
    public class RectangleTest
    {
        [TestMethod]
        public void RectangleAreaTest()
        {
            var testRectangle = new Rectangle(4,6);

            Assert.AreEqual(testRectangle.Area(), 24);
        }

        [TestMethod]
        public void RectanglePerimeterTest()
        {
            var testRectangle = new Rectangle(3,5);

            Assert.AreEqual(testRectangle.Perimeter(), 12);
        }

        [TestMethod]
        public void TestCorrectNumberOfArguments()
        {
            var theClass = Assembly.GetAssembly(typeof(Shapes.Shape)).GetTypes().Where(shapeType => shapeType.Name == "Rectangle").First(); // this is a Collection. Get the First. 
            var theClassConstructor = theClass.GetConstructors().First();
            Assert.AreEqual(0,theClassConstructor.GetParameters().Length);
        }
    }
}
