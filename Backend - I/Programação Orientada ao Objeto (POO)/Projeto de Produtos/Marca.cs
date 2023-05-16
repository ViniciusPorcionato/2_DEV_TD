using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_de_Produtos
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string? NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; }

        public string Cadastrar(Marca _cadastrar){
            Codigo = 1;
            NomeMarca = "Nike";
            DataCadastro = DateTime.Now;
        return "Marca Cadastrada";
        }



    }
}