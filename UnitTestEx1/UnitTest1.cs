using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestEx1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSquare()
        {
            MathDesk.Calculation objc1 = new MathDesk.Calculation();
            int num1 = 5;
            int result1 = num1*num1;

            Assert.AreEqual(result1, objc1.Square(num1));
        }

        [TestMethod]
        public void TestSquareRoot()
        {
            MathDesk.Calculation objc2 = new MathDesk.Calculation();
            int num1 = 25;
            double result2 = Math.Sqrt(num1);

            Assert.AreEqual(result2, objc2.SquareRoot(num1));
        }

        [TestMethod]
        public void TestCube()
        {
            MathDesk.Calculation objc3 = new MathDesk.Calculation();
            int num1 = 5;
            int result1 = num1 * num1 * num1;

            Assert.AreEqual(result1, objc3.Cube(num1));
        }
    }
}
