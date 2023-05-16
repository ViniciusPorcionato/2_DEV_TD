using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercício_Interface
{
    public interface IContatoComercial
    {
        public bool ValidarCnpj(string _cnpj);
    }
}