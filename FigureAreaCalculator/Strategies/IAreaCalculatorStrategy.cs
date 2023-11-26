namespace FigureAreaCalculator.Strategies
{
    /// <summary>
    /// Общая стратегия для вычисления площади.
    /// </summary>
    public interface IAreaCalculatorStrategy<T>
    {
        /// <summary>
        /// Вычислить площадь фигуры.
        /// </summary>
        double GetArea(T figure);
    }
}
