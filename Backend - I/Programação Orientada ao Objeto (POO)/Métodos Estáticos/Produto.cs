using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Métodos_Estáticos
{
    public class Produto
    {
        public  Produto()
        {
            
        }
        public  Produto(string nome)
        {
            Nome = nome;
        }
        public  Produto(string nome , float preco , string data )
        {
          Nome = nome;
          Preco = preco;
          Data = data;  
        }
    }
}