using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercício_Interface
{
    public interface IAgenda
    {
        public void Adicionar(Contato _contato);
        public void Listar();
    }
}