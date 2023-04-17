// See https://aka.ms/new-console-template for more information
using PIM_5.Aparelhos;
using PIM_5.Gerenciador;
using PIM_5.Login;
using PIM_5.Menu;
using PIM_5.Repositorio;
using PIM_5.Usuarios;
using System.ComponentModel.Design;

Main();

void Main()
{
    Menu menu = new Menu();

    BaseDados bdInicial = new BaseDados();

    Diretor diretor = new Diretor("d1", "d1");

    Professor professor = new Professor();
    
    bool voltarAoLogin = true;

    while (voltarAoLogin)
    {
        menu.DefinirTipoMenu();

        bool continuarMenu = true;

        if (menu.tipoMenu == "DIRETOR")
        {
            Console.Clear();

            voltarAoLogin = menu.MenuDiretor(diretor);
        }
        else if (menu.tipoMenu == "PROFESSOR")
        {
            Console.Clear();

            voltarAoLogin = menu.MenuProfessor(professor);
        }
    }
}


