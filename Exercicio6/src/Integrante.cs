using Exercicio6.src;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("Estou ensaiando");
        }

        public void gravar()
        {
            return "Estou gravando";
        }
        public void descansar()
        {
            return "Estou descansando";
        }

    }
}
