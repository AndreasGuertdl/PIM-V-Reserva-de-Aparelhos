using PIM_5.Aparelhos;
using PIM_5.Gerenciador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_5.GerenciadorAparelhos
{
    public abstract class GerenciadorDeListaDeAparalhos
    {
        public static List<Aparelho> listaAparelhos = new();

        protected bool ChecaLista()
        {
            if (listaAparelhos.Count == 0)
            {
                Console.WriteLine("Nós não temos aparelhos cadastrados para esta escola. Falar com a diretoria.");
                return false;
            }
            else return true;
        }

        protected Aparelho? ChecaListaAparelhosPorNome(string nomeAparelho)
        {
            for (int i = 0; i < listaAparelhos.Count; i++)
            {
                if (listaAparelhos[i].NomeAparelho == nomeAparelho.ToUpper() || listaAparelhos[i].TipoAparelho == nomeAparelho.ToUpper())
                {
                    Aparelho aparelhoSelecionado = listaAparelhos[i];
                    return aparelhoSelecionado;
                }
            }
            Console.WriteLine("Aparelho não encontrado.");
            return null;
        }
    }
}
