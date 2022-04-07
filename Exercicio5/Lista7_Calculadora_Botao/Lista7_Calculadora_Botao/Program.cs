using System;

namespace Lista7_Calculadora_Botao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool desligar = false;

            while (!desligar)
            {
                Console.WriteLine("Calculadora da Malu");
                Console.WriteLine("Insira o primeiro número");
                int num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Insira o operador: ");
                string operador = Console.ReadLine();

                Console.WriteLine("Insira o segundo número: ");
                int num2 = int.Parse(Console.ReadLine());

                switch (operador)
                {
                    case "+":
                        Console.WriteLine($"Resultado: {Somar(num1, num2)}");
                        break;

                    case "-":
                        Console.WriteLine($"Resultado: {Subtrair(num1, num2)}");
                        break;

                    case "/":
                        Console.WriteLine($"Resultado: {Dividir(num1, num2)}");
                        break;

                    case "*":
                        Console.WriteLine($"Resultado: {Multiplicar(num1, num2)}");
                        break;

                    default:
                        Console.WriteLine("Operador invalido");
                        break;
                }

                Console.WriteLine("Voce quer desligar? (sim/não) ");
                string condicao = Console.ReadLine();

                if (condicao == "sim")
                {
                    desligar = true;
                }
                else
                {
                    desligar = false;
                }
            }
        }

        public static int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Dividir(int num1, int num2);
        {
            return num1 / num2;
        }

    }
}
