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
        public DateTime DataCadastro { get; set; }
        public Marca? marca { get; set; }
        public Usuario? CadastratoPor { get; set; }
        List<Produto> ListaDeProtudos = new List<Produto>();

                
    }
}