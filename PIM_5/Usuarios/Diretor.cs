using PIM_5.Aparelhos;
using PIM_5.Gerenciador;
using PIM_5.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_5.Usuarios
{
    public class Diretor : SistemaLogin
    {
        string User = string.Empty;
        string Senha = string.Empty;

        public Diretor(string user, string senha)
        {
            this.user = user;
            this.senha = senha;
            listaDiretores.Add(this);
        }

        public Diretor()
        {

        }

        public bool LoginDiretor()
        {
            string usuarioArmazenado = string.Empty;
            string senhaArmazenada = string.Empty;
            
            Console.WriteLine("Insira seu usuário: ");
            string usuario = Console.ReadLine();

            Console.WriteLine("Insira sua senha: ");
            string senha = Console.ReadLine();

            if (string.Equals(senha, this.senha) && string.Equals(usuario, this.user))
            {
                return true;
            }
            else return false;
        }

        public void AdicionaAparelho()
        {
            Console.WriteLine("Digite as informações do aparelho que deseja adicionar: ");
            Console.Write("Tipo do aparelho: ");
            string tipoAparelho = Console.ReadLine().ToUpper();

            Console.Write("Nome do aparelho: ");
            string nomeAparelho = Console.ReadLine().ToUpper();

            Aparelho aparelho = new Aparelho(tipoAparelho.ToUpper(), nomeAparelho.ToUpper());

            listaAparelhos.Add(aparelho);
        }

        public void AdicionaAparelho(string tipoAparelho, string nomeAparelho)
        {
            Aparelho aparelho = new Aparelho(tipoAparelho.ToUpper(), nomeAparelho.ToUpper());

            listaAparelhos.Add(aparelho);
        }

        public void CadastraUsuario()
        {
            Console.Clear();

            Console.WriteLine("Para cadastrar um professor a nossa base de dados, informe os dados de login do professor a ser cadastrado.");

            Console.Write("Insira o usuário: ");

            string usuario = Console.ReadLine();

            Console.Write("Insira a senha: ");

            string senha = Console.ReadLine();

            Professor professor = new Professor();

            professor.user = usuario;

            professor.senha = senha;

            listaProfessores.Add(professor);
        }

        public void CadastraUsuario(string usuario, string senha)
        {
            Professor professor = new Professor();

            professor.user = usuario;

            professor.senha = senha;

            listaProfessores.Add(professor);
        }

        public void ListarUsuarios()
        {
            Console.Clear();

            for (int i = 0; i < listaProfessores.Count; i++)
            {
                if (listaProfessores.Count > 0)
                {
                    Console.WriteLine($"Usario: {listaProfessores[i].user}\nSenha: {listaProfessores[i].senha}");
                }
            }
        }

        public void AlterarSenha()
        {
            Console.Write("Lista de usuários: ");

            ListarUsuarios();

            Console.Write("Insira o usuario:");
            
            string usuario = Console.ReadLine();

            for (int i = 0; i < listaProfessores.Count; i++)
            {
                if (string.Equals(listaProfessores[i].user, usuario))
                {
                    Console.WriteLine("Insira a nova senha: ");
                    
                    string senhaAntiga = listaProfessores[i].senha;
                    
                    string senha = Console.ReadLine();
                    listaProfessores[i].senha = senha;

                    Console.WriteLine($"Senha do usuario {listaProfessores[i].user} alterada\nDe: {senhaAntiga}\nPara: {listaProfessores[i].senha}");
                }
            }

        }
        public void CadastraDiretor(string usuario, string senha)
        {
            Diretor diretor = new Diretor();

            diretor.user = usuario;

            diretor.senha = senha;

            listaDiretores.Add(diretor);
        }

    }
}
