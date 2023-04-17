using PIM_5.Aparelhos;
using PIM_5.Datas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using PIM_5.GerenciadorAparelhos;

namespace PIM_5.Gerenciador
{
    public class ReservaDeAparelhos : GerenciadorDeListaDeAparalhos
    {
        public void ReservaAparelho()
        {
            if (!ChecaLista()) 
            {
                return;
            }

            Console.Write("Digite qual aparelho deseja reservar: ");

            string nomeAparelho = Console.ReadLine().ToUpper();

            try
            {
                var aparelho = ChecaListaAparelhosPorNome(nomeAparelho);

                Console.Write($"Confirme se este é o aparelho que deseja reservar: {aparelho.NomeAparelho}\n1-- SIM, 2-- NÃO ");
                
                string confirmaReserva = Console.ReadLine();

                if (confirmaReserva == "1")
                {
                    ReservaAparelhoPorData(ChecaListaAparelhosPorNome(nomeAparelho));
                }
                else
                {
                    return;
                }
            }
            catch(NullReferenceException ex)
            {
                return;
            }
        }

        #region métodos para reserva de aparelho
        DateTime RecolheInformacoesParaReserva(Aparelho aparelhoSelecionado)
        {
            Console.WriteLine();
            Console.Write("Informe a data e hora que deseja reservar o aparelho (Formato DD/MM/AAAA HH:mm): ");
            DateTime dataHoraReserva = DateTime.Parse(Console.ReadLine());

            if (dataHoraReserva < DateTime.Now)
            {
                throw new Exception("Formato de data e hora incorretos ou data menor que a atual, favor tentar novamente!");
            }
            if (!(aparelhoSelecionado.ChecaDisponibilidade(dataHoraReserva.Day, dataHoraReserva.Hour)))
            {
                throw new Exception("Aparelho já reservado para esta data.");
            }
            return dataHoraReserva;
        }

        void ReservaAparelhoPorData(Aparelho aparelhoSelecionado)
        {
            if (aparelhoSelecionado.datasReservadas.Count != 0)
            {
                Console.WriteLine("Este aparelho está reservado para estas datas: ");
                Console.WriteLine(string.Join("\n", aparelhoSelecionado.datasReservadas));
            }

            aparelhoSelecionado.datasReservadas.Add(RecolheInformacoesParaReserva(aparelhoSelecionado));
            
            Console.Write("\nInforme o identificador da sala em que o aparelho estará reservado: ");

            aparelhoSelecionado.Sala = Console.ReadLine();

            Console.WriteLine($"Aparelho {aparelhoSelecionado.NomeAparelho} reservado para o dia {aparelhoSelecionado.datasReservadas.Last()}.");
        }
        #endregion
    }
}
