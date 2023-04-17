using PIM_5.Aparelhos;
using PIM_5.Gerenciador;
using PIM_5.GerenciadorAparelhos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_5.Usuarios
{
    public class Usuario : GerenciadorDeListaDeAparalhos
    {
        public void ReservaAparelho()
        {
            ReservaDeAparelhos gerenciador = new();
            gerenciador.ReservaAparelho();
        }

        public void DevolveAparelho()
        {
            DevolucaoDeAparelhos gerenciador = new();
            gerenciador.DevolveAparelho();
        }

        public void MostraLista()
        {
            MostraListasAparelho gerenciador = new();
            gerenciador.MostraLista();
        }
    }
}
