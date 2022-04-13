using System;
using CalculoArea.src;

namespace CalculoArea.src
{        public class Triangulo : Forma
    {
        public Triangulo(double _base, double _altura) : base(_base, _altura)
        {
        }

        public override double CalcularArea()
        {
            double area = (Base * Altura)/2;
            return area;
        }
    }
}