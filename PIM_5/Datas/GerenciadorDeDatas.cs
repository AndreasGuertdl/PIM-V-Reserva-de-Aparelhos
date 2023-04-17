using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_5.Datas
{
    public class GerenciadorDeDatas
    {

        public IList<DateTime> datasReservadas = new List<DateTime>();

        public bool ChecaDisponibilidade(int dia, int horario)
        //retorna true se o aparelho estiver disponível, retorna false se o aparelho estiver ocupado
        {
            if (datasReservadas.Count == 0)
            {
                return true;
            }

            for (int i = 0; i < datasReservadas.Count; i++)
            {
                if (datasReservadas[i].Day == dia && datasReservadas[i].Hour == horario)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
