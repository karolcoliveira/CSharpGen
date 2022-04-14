using Exercicio6.src;
using System;

namespace Exercicio6.src
{
    public class Integrante
    {
        public string NomeInt { get; set; }

        public string Grupo { get; set; }

        public string Posicao { get; set; }

        public string Geracao { get; set; }

        public Integrante(string _NomeInt, string _Grupo, string _Posicao, string _Geracao)

        {
            NomeInt = _NomeInt;
            Grupo = _Grupo;
            Posicao = _Posicao;
            Geracao = _Geracao;
        }

        public void ensaiar()
        {
            Console.WriteLine($"{NomeInt} está ensaiando");
        }

        public void gravar()
        {
            Console.WriteLine($"{NomeInt} está gravando");

        }

        public void descansar()
        {
            Console.WriteLine($"{NomeInt} está descansando");
        }

    }
}
