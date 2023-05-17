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
            Usuario user = new Usuario();
            Logar(user);

            if (this.Logado == true)
            {
                this.GerarMenu();
            }
        }

        public void Logar(Usuario usuario)
        {

            
            Console.WriteLine($"Informe o Email :");
            string emailDigitado = Console.ReadLine()!;

            Console.WriteLine($"Informe sua Senha :");
            string senhaDigitada = Console.ReadLine()!;

            if (emailDigitado == usuario.Email && senhaDigitada == usuario.Senha )
            {
                this.GerarMenu();
            }
            else
            {
                Console.WriteLine($"Senha ou Email Incorretos !");
                
            }




        }
        public void Deslogar()
        {

        }

        public void GerarMenu()
        {

            Produto produto = new Produto();
            Marca marca = new Marca();

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
                        break;
                    case "4":
                    marca.Cadastrar();
                        break;
                    case "5":
        
                        break;
                    case "6":
                     Console.WriteLine($"Informe o Codigo da Marca a ser removido :");
                     int codigo2 = int.Parse(Console.ReadLine()!);
                        break;
                    case "0":
                        Console.WriteLine($"Programa Encerrado !");

                        break;
                    default:
                        Console.WriteLine($"Opção Inválida !");

                        break;
                }

            } while (opcao != "0");

        }
    }
}