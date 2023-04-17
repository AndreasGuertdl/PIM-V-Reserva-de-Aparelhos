using PIM_5.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_5.Repositorio
{
    public class BaseDados
    {
        public BaseDados()
        {
            Diretor gerenciadorBd = new Diretor();

            gerenciadorBd.AdicionaAparelho("DVD", "LG DVD");

            gerenciadorBd.AdicionaAparelho("DATASHOW", "DATASHOW");

            gerenciadorBd.AdicionaAparelho("TV", "TV SAMSUNG");           
        }
    }
}
