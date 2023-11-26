using FigureAreaCalculator.Domains;
using System;

namespace FigureAreaCalculator.Strategies
{
    public class CircleAreaCalculatorStrategy : IAreaCalculatorStrategy<Circle>
    {
        private const int SquarePower = 2;

        /// <summary>
        /// Вычислить площадь круга.
        /// </summary>
        public double GetArea(Circle circle) => Math.PI * Math.Pow(circle.Radius, SquarePower);
    }
}
