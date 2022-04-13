using Exercicio6.src;
using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Integrante de grupo de kpop");

            Integrante leeteuk = new Integrante("Leeteuk", "Super Junior", "líder", "segunda");
            Integrante kai = new Integrante("Kai", "EXO", "dançarino principal", "terceira");
            Integrante minho = new Integrante("Minho", "Shinee", "rapper", "segunda");
            Integrante ningning = new Integrante("NingNing", "Aespa", "vocalista", "quarta");


            Console.WriteLine($"O/A integrante é: {leeteuk.NomeInt} de {leeteuk.Grupo} cuja posição é {leeteuk.Posicao} e debutou na {leeteuk.Geracao} geração.");
            Console.WriteLine($"O/A integrante é: {kai.NomeInt} de {kai.Grupo} cuja posição é {kai.Posicao} e debutou na {kai.Geracao} geração.");
            Console.WriteLine($"O/A integrante é: {minho.NomeInt} de {minho.Grupo} cuja posição é {minho.Posicao} e debutou na {minho.Geracao} geração.");
            Console.WriteLine($"O/A integrante é: {ningning.NomeInt} de {ningning.Grupo} cuja posição é {ningning.Posicao} e debutou na {ningning.Geracao} geração.");

            leeteuk.gravar();
            kai.ensaiar();
            minho.descansar();
            ningning.gravar();
        }


    }


}
