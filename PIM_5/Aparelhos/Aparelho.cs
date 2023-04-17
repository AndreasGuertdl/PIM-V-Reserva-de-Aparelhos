using PIM_5.Datas;
using PIM_5.Usuarios;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_5.Aparelhos
{
    public class Aparelho : GerenciadorDeDatas
    {
        public string TipoAparelho = string.Empty;
        public string NomeAparelho = string.Empty;
        public string Sala = string.Empty;

        public Aparelho(string tipo, string nome)
        { 
            this.TipoAparelho = tipo;
            this.NomeAparelho = nome;
        }
    }
}
