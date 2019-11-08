using NUnit.Framework;
using System;
using UnitTesting;
namespace UnitTest
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {
            Assert.True(true);
        }
        [Test()]
        public void AdditionTests()
        {
            //If
            var x = new Calculations();
            var y = new Calculations();
            //When
            x.X = 3;
            x.Y = 4;
            y.X = -3;
            y.Y = 0;
            // Then
            Assert.AreEqual(7, x.Addition(x.X, x.Y));
            Assert.AreEqual(-3, x.Addition(y.X, y.Y));
        }
        [Test()]
        public void MultiplicationTests()
        {
            //If
            var x = new Calculations();
            var y = new Calculations();

            //When
            x.X = 3;
            x.Y = 4;
            y.X = -3;
            y.Y = 4;
            // Then
            Assert.AreEqual(12, x.Multiplication(x.X, x.Y));
            Assert.AreEqual(-12, x.Multiplication(y.X, y.Y));
        }
    }
}
