using Console_MVC.Model;

namespace Console_MVC.View
{
    public class ProdutoView
    {
        // método para exibir os dados da lista de console
        public void Listar(List<Produto> produto){
            foreach (var item in produto)
            {

                Console.WriteLine($"\nCódigo : {item.Codigo}");
                Console.WriteLine($"Nome : {item.Nome}");
                Console.WriteLine($"Preço : {item.Preco:C}");
            }
        }

        public Produto Cadastrar()
        {
            Produto novoProduto = new Produto();

            Console.WriteLine($"Informe o código do produto :");
            novoProduto.Codigo = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Informe o nome do produto :");
            novoProduto.Nome = Console.ReadLine();
            Console.WriteLine($"Informe o preço do produto :");
            novoProduto.Preco = float.Parse(Console.ReadLine()!);

            return novoProduto;
        }
    }
}