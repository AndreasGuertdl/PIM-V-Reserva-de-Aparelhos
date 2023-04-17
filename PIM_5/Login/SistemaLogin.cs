using PIM_5.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_5.Login
{
    public abstract class SistemaLogin : Usuario
    {

        public string user = string.Empty;
        
        public string senha = string.Empty;

        public static List<Professor> listaProfessores = new();

        public static List<Diretor> listaDiretores = new();

        public bool LoginProfessor()
        {
            string usuarioArmazenado = string.Empty;
            string senhaArmazenada = string.Empty;

            Console.WriteLine("Insira seu usuário: ");
            string usuario = Console.ReadLine();

            Console.WriteLine("Insira sua senha: ");
            string senha = Console.ReadLine();

            for (var i = 0; i < listaProfessores.Count; i++)
            {
                usuarioArmazenado = listaProfessores[i].user;
                senhaArmazenada = listaProfessores[i].senha;
                if (string.Equals(usuario, usuarioArmazenado) && string.Equals(senha, senhaArmazenada))
                {
                    return true;
                }
            }
            return false;
        }

        public override string ToString()
        {
            return $"Usuário: {this.user}";
        }
    }
}
