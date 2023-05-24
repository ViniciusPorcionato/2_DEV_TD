using Console_MVC.Model;
using Console_MVC.View;

namespace Console_MVC.Controller
{
    public class ProdutoController
    {
        // instância das classes produto e produtoView
        Produto produto = new Produto();
        ProdutoView produtoView = new ProdutoView();

        // método controlador para acessar a listagem de produtos
        public void ListarProdutos(){
            List<Produto> produtos = produto.Ler();
            produtoView.Listar(produtos);
        }
        
    }
}