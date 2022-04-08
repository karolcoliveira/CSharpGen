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
        public string ensaiar()
        {
            return "Estou ensaiando";
        }

        public string gravar()
        {
            return "Estou gravando";
        }
        public string descansar()
        {
            return "Estou descansando";
        }

    }
}
