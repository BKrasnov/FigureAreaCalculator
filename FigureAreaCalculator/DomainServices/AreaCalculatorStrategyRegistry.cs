using FigureAreaCalculator.Domains;
using FigureAreaCalculator.Strategies;
using System;
using System.Collections.Generic;

namespace FigureAreaCalculator.DomainServices
{
    /// <summary>
    /// Регистр стратегий.
    /// </summary>
    public class AreaCalculatorStrategyRegistry
    {
        private readonly Dictionary<Type, object> strategies = new Dictionary<Type, object>();

        public AreaCalculatorStrategyRegistry()
        {
            Register(new CircleAreaCalculatorStrategy());
            Register(new TriangleAreaCalculatorStrategy());
        }

        public void Register<TFigure>(IAreaCalculatorStrategy<TFigure> strategy)
        {
            strategies[typeof(TFigure)] = strategy;
        }

        public IAreaCalculatorStrategy<TFigure> GetStrategy<TFigure>()
        {
            if (strategies.TryGetValue(typeof(TFigure), out var strategy))
            {
                return strategy as IAreaCalculatorStrategy<TFigure> ?? throw new InvalidOperationException($"Зарегистрированная стратегия для типа {typeof(TFigure)} имеет неправильный тип.");
            }

            throw new ArgumentException($"Стратегия не зарегистрирована для типа {typeof(TFigure)}");
        }
    }
}
