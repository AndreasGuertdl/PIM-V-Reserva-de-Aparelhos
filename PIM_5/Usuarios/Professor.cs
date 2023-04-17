using PIM_5.Aparelhos;
using PIM_5.Datas;
using PIM_5.Gerenciador;
using PIM_5.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_5.Usuarios
{
    public class Professor : SistemaLogin
    {
        public Professor(string usuario, string senha)
        {
            this.user = usuario;
            this.senha = senha;
        }
        public Professor()
        {

        }
    }
}

