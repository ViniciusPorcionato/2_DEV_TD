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

        
        public string Cadastrar(){
            Console.WriteLine($"Informe o Código do Usuário :");
            Codigo = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Informe o Nome de Usuário :");
            Nome = Console.ReadLine();
            Console.WriteLine($"Informe o Email de Usuário :");
            Email = Console.ReadLine();
            Console.WriteLine($"Informe a Senha :");
            Senha = Console.ReadLine();
            Console.WriteLine($"Data do Cadastro : {DataCadastro}");
            return "Cadastro com Sucesso !";  
        }

        public string Deletar(){
            Console.WriteLine($"Deseja Deletar Sua Conta ? s(sim) / n(não)");
            char Opcao = char.Parse(Console.ReadLine()!);
            
            if (Opcao == 's')
            {
                Nome = "";
                Email = "";
                Senha = "";
                return "Conta Removida com Sucesso !";
            }
            else
            {
                return "Conta não foi removida !";
            }
        }


        
        
        
        
    }
}