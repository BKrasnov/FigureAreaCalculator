using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureAreaCalculator.Strategies;

namespace FigureAreaCalculator.Tests
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        [DataRow(10, 314.16)]
        [DataRow(0, 0)]
        [DataRow(1, 3.14)]
        public void GetArea_ShouldCalculateCircleAreaCorrectly(double radius, double expected)
        {
            var circle = new Figure(new Circle(radius));
            var area = circle.GetArea();
            Assert.AreEqual(expected, area);
        }
    }
}
