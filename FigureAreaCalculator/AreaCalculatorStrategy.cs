using FigureAreaCalculator.DomainServices;
using FigureAreaCalculator.Strategies;
using System;

namespace FigureAreaCalculator
{
    public class AreaCalculatorStrategy<T> : IAreaCalculatorStrategy<T>
    {
        private readonly AreaCalculatorStrategyRegistry strategyRegistry;

        public AreaCalculatorStrategy(AreaCalculatorStrategyRegistry strategyRegistry = null)
        {
            this.strategyRegistry = strategyRegistry ?? new AreaCalculatorStrategyRegistry();
        }

        /// <summary>
        /// Получить площадь фигуры.
        /// </summary>
        public double GetArea(T figure)
        {
            if (figure == null)
                throw new ArgumentNullException(nameof(figure));

            var strategy = strategyRegistry.GetStrategy<T>();
            return Math.Round(strategy.GetArea(figure), 2);
        }

    }
}