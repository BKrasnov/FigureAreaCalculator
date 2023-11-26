using System;

namespace FigureAreaCalculator.Domains
{
    public class Triangle
    {
        private const int SquarePower = 2;
        private const double Epsilon = 0.0000001;

        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр класса с указанными сторонами.
        /// </summary>
        /// <param name="aSide">Сторона a.</param>
        /// <param name="bSide">Сторона b.</param>
        /// <param name="cSide">Сторона c.</param>
        /// <exception cref="ArgumentException">Выбрасывается, когда одна из сторон треугольника имеет отрицательное значение.</exception>
        /// <exception cref="ArgumentException">Выбрасывается, когда сумма любых двух сторон меньше третей стороны.</exception>
        /// 
        public Triangle(double aSide, double bSide, double cSide)
        {
            if (aSide <= 0 || bSide <= 0 || cSide <= 0)
                throw new ArgumentException("Длины сторон треугольника должны быть положительными числами.");

            if (aSide + bSide <= cSide || aSide + cSide <= bSide || bSide + cSide <= aSide)
                throw new ArgumentException("Сумма любых двух сторон должна быть больше третьей стороны.");

            SideA = aSide;
            SideB = bSide;
            SideC = cSide;
        }

        /// <summary>
        /// Возвращает значение, указывающее, является ли треугольник прямоугольным.
        /// </summary>
        /// <remarks>
        /// Треугольник является прямоугольным, если один из его углов является прямым углом или если выполняется теорема Пифагора
        /// (т.е. a ^ 2 + b ^ 2 = c ^ 2).
        /// /// </remarks>
        public bool IsRightAngled
        {
            get
            {
                var aSideSquare = Math.Pow(SideA, SquarePower);
                var bSideSquare = Math.Pow(SideB, SquarePower);
                var cSideSquare = Math.Pow(SideC, SquarePower);

                // Имеют ли какие-либо две стороны длины, удовлетворяющие теореме Пифагора
                return Math.Abs(aSideSquare + bSideSquare - cSideSquare) < Epsilon ||
                   Math.Abs(aSideSquare + cSideSquare - bSideSquare) < Epsilon ||
                   Math.Abs(bSideSquare + cSideSquare - aSideSquare) < Epsilon;
            }
        }
    }

}
