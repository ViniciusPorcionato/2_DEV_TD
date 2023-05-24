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
    }
}