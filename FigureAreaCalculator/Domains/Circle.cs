using System;

namespace FigureAreaCalculator.Domains
{
    public class Circle
    {
        public double Radius { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса с указанным радиусом.
        /// </summary>
        /// <param name="radius">Радиус окружности.</param>
        /// <exception cref="ArgumentException">Выбрасывается, когда радиус равен нулю или отрицателен.</exception>
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Радиус должен быть положительным числом.");

            Radius = radius;
        }
    }
}
