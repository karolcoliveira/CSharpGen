using System;
using Calculadora.src;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora");

            IOperacoes _objeto = new Calc();

            Console.WriteLine($"Soma: {_objeto.Somar(20, 2)}");
            Console.WriteLine($"Subtração: {_objeto.Subtrair(15, 6)}");
            Console.WriteLine($"Multiplicação: {_objeto.Multiplicar(145, 2)}");
            Console.WriteLine($"Divisão: {_objeto.Dividir(750, 3)}");
        }
    }
}