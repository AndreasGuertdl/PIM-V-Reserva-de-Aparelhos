using LanguageExt.ClassInstances.Const;
using PIM_5.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIM_5.Menu
{
    public class Menu
    {
        public string tipoMenu = string.Empty;

        public void DefinirTipoMenu()
        {
            string tipoUsuario = string.Empty;

            Console.Write("Digite o tipo de usuário: D-- Diretor P-- Professor ");
            while (string.IsNullOrEmpty(tipoUsuario))
            {
                tipoUsuario = Convert.ToString(Console.ReadLine()[0]);
            }

            if (tipoUsuario == "D" || tipoUsuario == "d")
            {
                Console.WriteLine("Iniciando como perfil de diretor.");
                tipoMenu = "DIRETOR";
            }
            else if (tipoUsuario == "P" || tipoUsuario == "p")
            {
                Console.WriteLine("Iniciando como perfil de professor.");
                tipoMenu = "PROFESSOR";
            }

            else Console.WriteLine("Tipo inválido.");
        }
        #region tipos de menu
        public bool MenuDiretor(Diretor diretor)
        {
            int menuOption = 0;

            if (diretor.LoginDiretor())
            {
                Console.WriteLine("Login realizado com sucesso! Aperte a tecla 'Enter' para ir ao menu.");
                Console.ReadLine();
                do
                {
                    Console.Clear();

                    Console.WriteLine("1-- Reservar aparelho.\n2-- Listar Aparelhos.\n3-- Liberar Aparelho\n4-- Cadastrar Usuário\n5-- Listar Usuários\n6-- Alterar Senha de Usuário\n7-- Sair");

                    menuOption = Int32.Parse(Console.ReadLine());

                    switch (menuOption)
                    {
                        case 1:
                            ReservaAparelho(diretor);
                            break;
                        case 2:
                            mostraLista(diretor);
                            break;
                        case 3:
                            DevolveAparelho(diretor);
                            break;
                        case 4:
                            diretor.CadastraUsuario();

                            Console.WriteLine("\nPressione 'Enter' para retornar ao menu.");

                            Console.ReadLine();

                            Console.Clear();
                            break;
                        case 5:
                            diretor.ListarUsuarios();

                            Console.WriteLine("\nPressione 'Enter' para retornar ao menu.");

                            Console.ReadLine();

                            Console.Clear();
                            break;
                        case 6:
                            diretor.AlterarSenha();

                            Console.WriteLine("\nPressione 'Enter' para retornar ao menu.");

                            Console.ReadLine();

                            Console.Clear();
                            break;
                        case 7:
                            Console.Clear();
                            Console.WriteLine("Deseja retornar a tela de login ou fechar do aplicativo? 1-- Login 2-- Fechar");
                            int loginOuSaida = Int32.Parse(Console.ReadLine());
                            if (loginOuSaida == 2)
                            {
                                return false;
                            }
                            else
                            {
                                Console.WriteLine("Pressione a tecla 'Enter' para retornar à tela de login.");
                                Console.ReadLine();
                                Console.Clear();
                                return true;
                            }
                            break;
                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }
                } while (menuOption != 7);
            }
            else
            {
                Console.WriteLine("Credencias do diretor incorretas. Por favor, contatar o suporte.");
                return false;
            }
            return false;
        }

        public bool MenuProfessor(Professor professor)
        {
            int menuOption = 0;

            if (professor.LoginProfessor())
            {
                Console.WriteLine("Login realizado com sucesso! Aperte a tecla 'Enter' para ir ao menu.");
                
                Console.ReadLine();
                
                do
                {
                    Console.Clear();

                    Console.WriteLine("1-- Reservar aparelho.\n2-- Listar Aparelhos.\n3-- Liberar Aparelho\n4-- Sair");

                    menuOption = Int32.Parse(Console.ReadLine());

                    switch (menuOption)
                    {
                        case 1:
                            ReservaAparelho(professor);
                            break;
                        case 2:
                            mostraLista(professor);
                            break;
                        case 3:
                            DevolveAparelho(professor);
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("Deseja retornar a tela de login ou fechar do aplicativo? 1-- Login 2-- Fechar");
                            int loginOuSaida = Int32.Parse(Console.ReadLine());
                            if (loginOuSaida == 2)
                            {
                                return false;
                            }
                            else
                            {
                                Console.WriteLine("Pressione a tecla 'Enter' para retornar à tela de login.");
                                Console.ReadLine();
                                Console.Clear();
                                return true;
                            }
                            break;
                        default:
                            Console.WriteLine("Opção inválida.");
                            break;
                    }
                } while (menuOption != 4);
            }
            else
            {
                Console.WriteLine("Credencias do diretor incorretas. Por favor, contatar o suporte.");
                return false;
            }
            return false;
        }
        #endregion

        #region métodos do Menu

        public void DevolveAparelho(Usuario usuario)
        {
            Console.WriteLine("Lista de aparelhos:\n");

            usuario.MostraLista();

            usuario.DevolveAparelho();

            Console.WriteLine("\nPressione 'Enter' para retornar ao menu.");

            Console.ReadLine();

        }

        public void mostraLista(Usuario usuario)
        {
            Console.Clear();

            Console.WriteLine("Lista de aparelhos:\n");

            usuario.MostraLista();

            Console.WriteLine("\nPressione 'Enter' para retornar ao menu.");

            Console.ReadLine();
        }

        public void ReservaAparelho(Usuario usuario)
        {
            Console.Clear();

            Console.WriteLine("Lista de aparelhos:\n");

            usuario.MostraLista();

            usuario.ReservaAparelho();

            Console.WriteLine("\nPressione 'Enter' para retornar ao menu.");

            Console.ReadLine();
        }
    }
    #endregion
}
