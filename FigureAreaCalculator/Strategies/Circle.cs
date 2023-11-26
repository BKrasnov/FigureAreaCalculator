using System;

namespace FigureAreaCalculator.Strategies
{
    public class Circle : IHaveArea
    {
        private const int SquarePower = 2;
        private readonly double _radius;

        /// <summary>
        /// Инициализирует новый экземпляр класса с указанным радиусом.
        /// </summary>
        /// <param name="radius">Радиус окружности.</param>
        /// <exception cref="ArgumentException">Выбрасывается, когда радиус равен нулю или отрицателен.</exception>
        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Радиус должен быть положительным числом.");

            _radius = radius;
        }

        /// <summary>
        /// Возвращает площадь круга.
        /// </summary>
        public double GetArea() => Math.PI * Math.Pow(_radius, SquarePower);
    }
}
