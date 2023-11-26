using FigureAreaCalculator.Strategies;
using System;

namespace FigureAreaCalculator
{
    public class Figure
    {
        public IHaveArea HaveArea { get; set; }
        public Figure(IHaveArea haveArea) => SetHaveArea(haveArea);

        /// <summary>
        /// Получить площадь фигуры.
        /// </summary>
        public double GetArea() => Math.Round(HaveArea.GetArea(), 2);

        /// <summary>
        /// Устанавливает стратегию расчета площади для фигуры.
        /// </summary>
        /// <param name="haveArea">Стратегия расчета площади.</param>
        private void SetHaveArea(IHaveArea haveArea)
        {
            HaveArea = haveArea ?? throw new ArgumentNullException("Стратегия расчета площади не может быть null.");
        }
    }
}