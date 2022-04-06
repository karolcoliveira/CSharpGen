using System;

namespace Lista6_TabuadaMalu
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int numero;
            Console.WriteLine("Tabuada da Malu");
            Console.WriteLine("Insira o número que você deseja multiplicar: ");

            numero = Convert.ToInt32(Console.ReadLine());

            for (int A = 0; A <= 10; A++)
            {
             int resultado = (numero * A);

             Console.WriteLine($"{numero} x {A} = {resultado}");
            }
        }
        
    }
}
