using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Moq;

namespace _07.Hack
{
    public class MathTests
    {
        [TestCase(5, 5)]
        [TestCase(-5, 5)]
        [TestCase(0, 0)]
        [TestCase(5.5, 5.5)]
        [TestCase(-5.5, 5.5)]
        public void AbsMethodReturnAbsoluteValueOfNumber(double testNum, double expectedNum)
        {
            Assert.That(Math.Abs(-5), Is.EqualTo(5));
        }

        [TestCase(2.99, 2)]
        [TestCase(2.5, 2)]
        [TestCase(2.01, 2)]
        [TestCase(-2.99, -3)]
        [TestCase(-2.5, -3)]
        [TestCase(-2.01, -3)]
        [TestCase(0, 0)]
        [TestCase(-0.01, -1)]
        [TestCase(0.99, 0)]
        public void FloorMethodReturnFlooredValueOfNumber(double testNum, double expectedNum)
        {
            Assert.That(Math.Floor(testNum), Is.EqualTo(expectedNum));
        }
    }
}
