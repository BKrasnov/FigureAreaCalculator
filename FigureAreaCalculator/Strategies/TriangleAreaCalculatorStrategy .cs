using FigureAreaCalculator.Domains;
using System;

namespace FigureAreaCalculator.Strategies
{
    public class TriangleAreaCalculatorStrategy : IAreaCalculatorStrategy<Triangle>
    {
        /// <summary>
        /// Вычислить площадь треугольника, используя формулу Герона.
        /// </summary>
        public double GetArea(Triangle triangle)
        {
            var sideA = triangle.SideA;
            var sideB = triangle.SideB;
            var sideC = triangle.SideC;

            var semiPerimeter = (sideA + sideB + sideC) / 2;
            var area = semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC);
            return Math.Sqrt(area);
        }
    }
}
