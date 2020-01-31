using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Square;

namespace UnitTestProject7
{
    [TestClass]
    public class SquareTest
    {
        Calc c = new Calc();
        [TestMethod]
            public void TestMethodCircle()
            {
                double s = c.SquareCircle(10);
             
            Assert.AreEqual(314.159265, Math.Round(s, 6));
            }
            [TestMethod]
            public void TestMethodTr()
            {
            Calc.Triple s = new Calc.Triple();
            s = c.SquareRect(2,3,4);
            Assert.AreEqual(2.9047, Math.Round(s.squareTr, 4));
            }
        [TestMethod]
        public void TestSquareRect()
        {
            Calc.Triple s = new Calc.Triple();
             s = c.SquareRect(4,5,3);
            Assert.AreEqual("прямоугольный треугольник", s.isRectangular);
        }
    }
    }

