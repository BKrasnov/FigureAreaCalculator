﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FigureAreaCalculator.Domains;

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
            // Arrange
            var areaCalculator = new AreaCalculatorStrategy<Circle>();
            var circle = new Circle(radius);

            // Act
            var area = areaCalculator.GetArea(circle);

            // Assert
            Assert.AreEqual(expected, area);
        }

        [TestMethod]
        [DataRow(-10)]
        [DataRow(-1)]
        public void InvalidRadius_ThrowsArgumentException_OnInit(double radius)
        {
            // Assert
            Assert.ThrowsException<ArgumentException>(() =>
            {
                // Act
                new Circle(radius);
            });
        }
    }
}
