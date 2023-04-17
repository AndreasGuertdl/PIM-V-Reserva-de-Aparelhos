using PIM_5.Aparelhos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_5.GerenciadorAparelhos
{
    public class MostraListasAparelho : GerenciadorDeListaDeAparalhos
    {
        public void MostraLista()
        {
            for (int i = 0; i < listaAparelhos.Count; i++)
            {
                if (listaAparelhos[i].datasReservadas.Count > 0)
                {
                    Console.WriteLine($"Tipo: {listaAparelhos[i].NomeAparelho}\nNome do aparelho: {listaAparelhos[i].TipoAparelho}");
                    foreach(var data in listaAparelhos[i].datasReservadas)
                    {
                        Console.WriteLine($"Datas Reservadas: {data.ToString()}, Sala: {listaAparelhos[i].Sala}");
                    }
                    continue;
                }
                else Console.WriteLine($"Tipo: {listaAparelhos[i].NomeAparelho}\nNome do aparelho: {listaAparelhos[i].TipoAparelho}\n");
            }
        }
    }
}
