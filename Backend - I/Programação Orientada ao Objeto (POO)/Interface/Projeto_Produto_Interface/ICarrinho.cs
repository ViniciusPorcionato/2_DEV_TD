using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_Produto_Interface
{

    // Interface ICarrinho
    public interface ICarrinho
    {
        // regras de contrato "métodos"
        // métodos que deverão aqui ser declarado apenas

        // CRUD : Create, Read, Update e Delete

        // padrão de chamada de método
        // tipo nome(parametros)

        // Create
        // Passar objeto como parametros 
                            // Objeto
        void Adicionar (Produto _produto);

        // Read
        void Listar();

        // Update
        void Atualizar(int _codigo, Produto _produto);

        // Delete
        void Remover(Produto _produto);
    }
}