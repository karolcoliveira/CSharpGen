using System;

namespace Lista5_IMC
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

            if (IMC < 18.5)
            {
             Console.WriteLine("Abaixo do peso");
            }

            else if (IMC < 25)
            {
                Console.WriteLine("Peso normal");
            }

            else if (IMC < 30)
            {
                Console.WriteLine("Sobrepeso");
            }

            else
            {
                Console.WriteLine("Obesidade");
            }
        }
    }
}