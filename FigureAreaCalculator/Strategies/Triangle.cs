using System;

namespace FigureAreaCalculator.Strategies
{
    public class Triangle: IHaveArea
    {
        private const int SquarePower = 2;
        private const double Epsilon = 0.0000001;

        private readonly double _aSide;
        private readonly double _bSide;
        private readonly double _cSide;

        public Triangle(double aSide, double bSide, double cSide)
        {
            if (aSide <= 0 || bSide <= 0 || cSide <= 0)
                throw new ArgumentException("Длины сторон треугольника должны быть положительными числами.");

            if (aSide + bSide <= cSide || aSide + cSide <= bSide || bSide + cSide <= aSide)
                throw new ArgumentException("Сумма любых двух сторон должна быть больше третьей стороны.");

            _aSide = aSide;
            _bSide = bSide;
            _cSide = cSide;
        }

        /// <summary>
        /// Вычисляет площадь треугольника, используя формулу Герона.
        /// </summary>
        public double GetArea()
        {
            var semiPerimeter = (_aSide + _bSide + _cSide) / 2;
            var area = semiPerimeter * (semiPerimeter - _aSide) * (semiPerimeter - _bSide) * (semiPerimeter - _cSide);
            return Math.Sqrt(area);
        }

        /// <summary>
        /// Возвращает значение, указывающее, является ли треугольник прямоугольным.
        /// </summary>
        /// <remarks>
        /// Треугольник является прямоугольным, если один из его углов является прямым углом или если выполняется теорема Пифагора
        /// (т.е. a ^ 2 + b ^ 2 = c ^ 2).
        /// /// </remarks>
        public bool IsRightAngled()
        {
            var a2 = Math.Pow(_aSide, SquarePower);
            var b2 = Math.Pow(_bSide, SquarePower);
            var c2 = Math.Pow(_cSide, SquarePower);

            // Имеют ли какие - либо две стороны длины, удовлетворяющие теореме Пифагора
            return Math.Abs(a2 + b2 - c2) < Epsilon ||
               Math.Abs(a2 + c2 - b2) < Epsilon ||
               Math.Abs(b2 + c2 - a2) < Epsilon;
        }
    }
}
