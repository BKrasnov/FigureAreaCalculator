using FigureAreaCalculator.Strategies;
using FigureCalculateDemoApp.Domains;

namespace FigureCalculateDemoApp.Strategies
{
    public class SquareAreaCalculatorStrategy : IAreaCalculatorStrategy<Square>
    {
        private const int SquarePower = 2;

        /// <summary>
        /// Вычислить площадь квадрата.
        /// </summary>
        public double GetArea(Square square)
        {
            return Math.Pow(square.Side, SquarePower);
        }
    }
}
