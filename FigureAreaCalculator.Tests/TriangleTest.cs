using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureAreaCalculator.Strategies;

namespace FigureAreaCalculator.Tests
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        [DataRow(0, 0, 0)]
        [DataRow(1, 2, 4)]
        [DataRow(1, 2, -4)]
        public void InvalidSides_ThrowsArgumentException_OnInit(double aSide, double bSide, double cSide)
        {
            Assert.ThrowsException<ArgumentException>(() => new Figure(new Triangle(aSide, bSide, cSide)));
        }

        [TestMethod]
        [DataRow(3, 4, 5, 6)]
        [DataRow(2, 3, 4, 2.90)]
        [DataRow(5, 12, 13, 30)]
        public void Area_WithValidSides_ReturnsCorrectResult(double aSide, double bSide, double cSide, double expected)
        {
            var triangle = new Figure(new Triangle(aSide, bSide, cSide));
            var area = triangle.GetArea();
            Assert.AreEqual(expected, area);
        }

        [TestMethod]
        [DataRow(3, 4, 5, true)]
        [DataRow(5, 12, 13, true)]
        [DataRow(5, 5, 5, false)]
        [DataRow(3, 3, 5, false)]
        public void IsRightAngled_ReturnsExpectedResult(double aSide, double bSide, double cSide, bool expectedIsRightAngled)
        {
            var triangle = new Triangle(aSide, bSide, cSide);
            Assert.AreEqual(expectedIsRightAngled, triangle.IsRightAngled);
        }
    }
}
