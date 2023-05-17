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
        Produto produtos = new Produto();

        public void Cadastrar(){
        Console.WriteLine($"Informe o Código da Marca :");
        produtos.Codigo = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"Informe o Nome do Produto :");
        produtos.NomeProduto = Console.ReadLine();
        produtos.Preco = float.Parse(Console.ReadLine()!);
        Console.WriteLine($"Data do Cadastro : {produtos.DataCadastro}");
                
        ListaDeProtudos.Add(produtos);
        
        }
        
        public void Listar(){

        }

        public void Deletar(int _codigo){

        }

                
    }
}