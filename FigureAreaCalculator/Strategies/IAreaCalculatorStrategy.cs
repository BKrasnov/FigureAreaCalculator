namespace FigureAreaCalculator.Strategies
{
    /// <summary>
    /// Интерфе общей стратегии для вычисления площади.
    /// </summary>
    public interface IAreaCalculatorStrategy<T>
    {
        /// <summary>
        /// Вычислить площадь фигуры.
        /// </summary>
        double GetArea(T figure);
    }
}
