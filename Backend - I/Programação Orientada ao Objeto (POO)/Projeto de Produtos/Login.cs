using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_Produtos
{
    public class Login
    {

        public bool Logado { get; set; }


        public Login()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Usuario user = new Usuario();
            user.Cadastrar();
            Logar(user);

            if (this.Logado == true)
            {
                this.GerarMenu();
            }
            Console.ResetColor();
        }

        public void Logar(Usuario user)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;


            Console.WriteLine($"Informe o Email :");
            string emailDigitado = Console.ReadLine()!;

            Console.WriteLine($"Informe sua Senha :");
            string senhaDigitada = Console.ReadLine()!;

            foreach (var item in user.ListaDeUsuarios)
            {
                user.Email = item.Email;
                user.Senha = item.Senha;

                if (emailDigitado == user.Email && senhaDigitada == user.Senha)
                {
                    this.Logado = true;
                    Console.WriteLine($"Login Efetuado com sucesso");

                }
                else
                {
                    Console.WriteLine($"Senha ou Email Inválidos !");

                }
            }

            Console.ResetColor();
        }
        public void Deslogar()
        {

        }

        public void GerarMenu()
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;

            Produto produto = new Produto();
            Marca marca = new Marca();
            Usuario user = new Usuario();

            string opcao = "";

            do
            {
                Console.WriteLine(@$"
                === MENU DE OPÇÕES ===
                [1] Cadastrar Produto
                [2] Listar Produto
                [3] Remover Produto
                ----------------------
                [4] Cadastrar Marca
                [5] Listar Marca
                [6] Remover Marca
                ----------------------
                [7] Adicionar Usuário
                [8] Listar Usuários
                [9] Deletar Usuário
                ----------------------
                [0] Sair
                ");

                opcao = Console.ReadLine()!;

                switch (opcao)
                {
                    case "1":
                        produto.Cadastrar();
                        break;
                    case "2":
                        produto.Listar();
                        break;
                    case "3":
                        Console.WriteLine($"Informe o Codigo do Produto a ser removido :");
                        int codigo1 = int.Parse(Console.ReadLine()!);
                        produto.Deletar(codigo1);
                        break;
                    case "4":
                        marca.Cadastrar();
                        break;
                    case "5":
                        marca.Listar();
                        break;
                    case "6":
                        Console.WriteLine($"Informe o Codigo da Marca a ser removido :");
                        int codigo2 = int.Parse(Console.ReadLine()!);
                        marca.Deletar(codigo2);
                        break;
                    case "7":
                        user.Cadastrar();
                        break;
                    case "8":
                        user.Listar();
                        break;
                    case "9":
                        Console.WriteLine($"Informe o Codigo do Usuário a ser removido :");
                        int codigo3 = int.Parse(Console.ReadLine()!);
                        user.Deletar(codigo3);
                        break;

                    case "0":
                        Console.WriteLine($"Programa Encerrado !");
                        break;
                    default:
                        Console.WriteLine($"Opção Inválida !");

                        break;
                }

            } while (opcao != "0");
            Console.ResetColor();

        }
    }
}