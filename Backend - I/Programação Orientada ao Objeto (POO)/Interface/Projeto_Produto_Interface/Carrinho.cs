

namespace Projeto_Produto_Interface
{
    public class Carrinho : ICarrinho
    {
        // propriedades
        public float Valor { get; set; }

        // criar uma lista para manipular os nossos objetos
        List<Produto> carrinho = new List<Produto>();

        public void Adicionar(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void Atualizar(int _codigo, Produto _novoProduto)
        {           
                            // Objeto
            carrinho.Find(x => x.Codigo == _codigo).Nome = _novoProduto.Nome;
            carrinho.Find(x => x.Codigo == _codigo).Preco = _novoProduto.Preco;
        }

        public void Listar()
        {
            if (carrinho.Count > 0)
            {
                foreach (Produto item in carrinho)
                {
                    Console.WriteLine(@$"
                    Código : {item.Codigo}
                    Nome : {item.Nome}
                    Preço : {item.Preco:C}
                    ");

                }
            }
        }

        public void Remover(Produto _produto)
        {
            carrinho.Remove(_produto);
        }

        public void CalcularTotal()
        {
            Valor = 0;

            if (carrinho.Count > 0)
            {
                foreach (Produto item in carrinho)
                {
                    Valor += item.Preco;
                }
                Console.WriteLine($"O preço total do seu carrinho é : {this.Valor:C}");
            }
            else
            {
                Console.WriteLine($"Carrinho Vazio !");

            }
        }


    }
}