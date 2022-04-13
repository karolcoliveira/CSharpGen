using System;
using CalculoArea.src;

namespace CalculoArea.src
{
    public abstract class Forma
    {  
        public double Base { get; set;}
        public double Altura { get; set;}

        public Forma(double _base, double  _altura)
        {
            Base = _base;
            Altura = _altura;
        }

        public abstract double CalcularArea();
    }
} 