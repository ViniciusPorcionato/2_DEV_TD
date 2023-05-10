using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercício_Listas
{
    public class Carro
    {

        public string Marca { get; set; }
        public string Cor { get; set; }
        public int Ano { get; set; }
        
        
        public Carro()
        {
            
        }

        public Carro(string marca , string cor, int ano)
        {
            Marca = marca;
            Cor = cor;
            Ano = ano;
        }
    }
}