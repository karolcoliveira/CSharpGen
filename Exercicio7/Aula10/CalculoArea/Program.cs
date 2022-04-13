using System;
using CalculoArea.src;

namespace CalculoArea
{
    class Program
    {
        static void Main(string[] args)

        {   
            Console.WriteLine("Insira o tamanho dos lados do quadrado");
            double ladoQuadrado = double.Parse(Console.ReadLine());
            Quadrado quadrado = new Quadrado(ladoQuadrado, ladoQuadrado);
            Console.WriteLine($"A area do quadrado é {quadrado.CalcularArea()}");
            Console.WriteLine("Insira o tamanho da base do retangulo");
            double baseRetangulo = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o tamanho da altura do retangulo");
            double alturaRetangulo = double.Parse(Console.ReadLine());
            Retangulo retangulo = new Retangulo(baseRetangulo, alturaRetangulo);
            Console.WriteLine($"A area do retangulo é {retangulo.CalcularArea()}");
            Console.WriteLine("Insira o tamanho da base do triangulo");
            double baseTriangulo = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira o tamanho da altura do triangulo");
            double alturaTriangulo = double.Parse(Console.ReadLine());
            Triangulo triangulo = new Triangulo(baseTriangulo, alturaTriangulo);
            Console.WriteLine($"A area do triangulo é {triangulo.CalcularArea()}");
        }
    }
}