using System;
using CalculoArea.src;

namespace CalculoArea.src
{
     public class Retangulo : Forma
    {
        public Retangulo(double _base, double _altura) : base(_base, _altura)
        {}
        public override double CalcularArea()
        {
            double area = Base * Altura;
            return area;
        }
    }
} 