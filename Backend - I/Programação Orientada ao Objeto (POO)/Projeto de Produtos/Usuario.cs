using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_Produtos
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;


        public void Cadastrar()
        {
            Console.WriteLine($"Informe o Código do Usuário :");
            Codigo = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Informe o Nome de Usuário :");
            Nome = Console.ReadLine();
            Console.WriteLine($"Informe o Email de Usuário :");
            Email = Console.ReadLine();
            Console.WriteLine($"Informe a Senha :");
            Senha = Console.ReadLine();
            Console.WriteLine($"Data do Cadastro : {DataCadastro}");
            Console.WriteLine(@$"
            Conta Usuário :
            Código User : {this.Codigo}
            Nome : {this.Nome}
            Email : {this.Email}
            Senha : {this.Senha}
            ");

        }

        public void Deletar()
        {
            Console.WriteLine($"Deseja Deletar Sua Conta ? s(sim) / n(não)");
            char Opcao = char.Parse(Console.ReadLine()!);

            if (Opcao == 's')
            {
                Codigo = 0;
                Nome = "";
                Email = "";
                Senha = "";
                Console.WriteLine($"Conta Removida com Sucesso !");
                Console.WriteLine(@$"
            Conta Usuário :
            Código User : {this.Codigo}
            Nome : {this.Nome}
            Email : {this.Email}
            Senha : {this.Senha}
            ");


            }
            else
            {
                Console.WriteLine($"Conta não foi alterada !");
                Console.WriteLine(@$"
            Conta Usuário :
            Código User : {this.Codigo}
            Nome : {this.Nome}
            Email : {this.Email}
            Senha : {this.Senha}
            ");

            }
        }






    }
}