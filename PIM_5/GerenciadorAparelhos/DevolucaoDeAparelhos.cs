using PIM_5.Aparelhos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_5.GerenciadorAparelhos
{
    public class DevolucaoDeAparelhos : GerenciadorDeListaDeAparalhos
    {
        public void DevolveAparelho()
        {
            string confirmaDevolucao = String.Empty;

            string aparelhoASerDevolvido = String.Empty;

            Console.Write("Digite qual aparelho deseja liberar: ");

            while (string.IsNullOrEmpty(aparelhoASerDevolvido))
            {
                aparelhoASerDevolvido = Console.ReadLine();
            }
            
            Aparelho aparelho = ChecaListaAparelhosPorNome(aparelhoASerDevolvido);
            
            if (aparelho != null)
            {
                if (aparelho.datasReservadas.Count == 0)
                {
                    Console.WriteLine("\nEste aparelho não possui datas reservadas.");
                    return;
                }
                else
                {
                    Console.Write($"Confirme se este é o aparelho que deseja devolver: {aparelho.NomeAparelho}, etc. 1-- SIM, 2-- NÃO ");

                    while (string.IsNullOrEmpty(confirmaDevolucao))
                    {
                        confirmaDevolucao = Console.ReadLine();
                    }

                    if (confirmaDevolucao == "1" || confirmaDevolucao == "SIM")
                    {
                        Console.Write("\nInforme a data e hora do aparelho que deseja marcar como devolvido: (Formato DD/MM/AAAA HH:mm): ");
                        DateTime data = DateTime.Parse(Console.ReadLine());
                        for(var i = 0; i < aparelho.datasReservadas.Count; i++)
                        {
                            if (aparelho.datasReservadas[i] == data)
                            {
                                aparelho.datasReservadas.Remove(data);
                                Console.WriteLine("\nDevolução feita com sucesso.");
                            }
                        }
                        Console.WriteLine("\nEste aparelho não está registrado para esta data.");
                    }
                }
            }
            else return;
        }
    }
}
