using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureCalculateDemoApp.Domains
{
    public class Square
    {
        public double Side { get; set; }

        public Square(double side)
        {
            if (side < 0)
                throw new ArgumentException("Сторона должна быть положительным числом.");

            Side = side;
        }
    }
}
