using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float peso, altura, IMC;

            Console.WriteLine("Insira seu peso: ");
            peso = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira sua altura: ");
            altura = float.Parse(Console.ReadLine());

            IMC = peso / (altura * altura);

            Console.WriteLine("Seu IMC é: " + IMC);


        }
    }
}
