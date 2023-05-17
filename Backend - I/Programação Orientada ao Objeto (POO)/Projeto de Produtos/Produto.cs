using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_Produtos
{
    public class Produto
    {

        public int Codigo { get; set; }
        public string? NomeProduto { get; set; }
        public float Preco { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public Marca? Marca = new Marca();
        public Usuario? CadastratoPor { get; set; }
        List<Produto> ListaDeProtudos = new List<Produto>();
        

        public void Cadastrar(){
        Produto produtos = new Produto();
        Console.WriteLine($"Informe o Código da Marca :");
        produtos.Codigo = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"Informe o Nome do Produto :");
        produtos.NomeProduto = Console.ReadLine();
        Console.WriteLine($"Informe o Preço do Produto :");
        produtos.Preco = float.Parse(Console.ReadLine()!);
        Console.WriteLine($"Data do Cadastro : {produtos.DataCadastro}");
                
        ListaDeProtudos.Add(produtos);
        Console.WriteLine($"Produto cadastrado com sucesso !");
        
        
        }
        
        public void Listar(){
            foreach (var item in ListaDeProtudos)
            {
                Console.WriteLine(@$"
                == Produto Cadastrado ==
                Código do Produto : {item.Codigo}
                Nome : {item.NomeProduto}
                Preço : {item.Preco:C}
                Data do Cadastro : {item.DataCadastro}
                ");
                
            }
        }

        public void Deletar(int _codigo){

        }

                
    }
}