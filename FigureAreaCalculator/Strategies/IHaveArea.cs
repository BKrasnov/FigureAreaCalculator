using System;

namespace FigureAreaCalculator.Strategies
{
    /// <summary>
    /// Представляет собой наличие площади у чего-либо.
    /// </summary>
    public interface IHaveArea
    {
        /// <summary>
        /// Получить площадь.
        /// </summary>
        double GetArea();
    }
}
