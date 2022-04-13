using Zoologico.src;
using System.Collections.Generic;
using System;

namespace Aula10
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Zoológico");

            List<Animal> animais = new List<Animal>(
                new Animal[] {
                    new Gato("Gato Garfield", "Laranja", "Felino"),
                    new Cachorro("Cachorro Marley", "Amarelo", "Canídio"),
                    new Cachorro("Cachorro Clifford", "Vermelho", "Canídio"),
                    new Gato("Gata Marie", "Branco", "Felino"),
                    new Macaco("Macaco Abul", "Marrom", "Primata")
                });

            foreach (Animal animal in animais)
            {
                if (animal.Classificacao == "Canídio")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}, sua cor é {animal.Cor}");
                    animal.Comunicar("Au au!");
          
                }
                else if (animal.Classificacao == "Felino")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}, sua cor é {animal.Cor}");
                    animal.Comunicar("Miau!");
                
                }
                else if (animal.Classificacao == "Primata")
                {
                    Console.WriteLine($"{animal.Nome} é um {animal.Classificacao}, sua cor é {animal.Cor}");
                    animal.Comunicar("UUUUUUh Ahaaaah!");
                }
            }

        }
    }
}

