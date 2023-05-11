using Projeto_Produto_Interface;

// instância do objeto carrinho 
Carrinho carrinho =  new Carrinho();

// Instânciar objeto(s) da classe produtos
Produto p1 = new Produto(123 , "GTA V", 52.90f);
Produto p2 = new Produto(456 , "Call Of Duty" , 63.80f);
Produto p3 = new Produto(789 , "Forza" , 90.60f);

carrinho.Adicionar(p1);
carrinho.Adicionar(p2);
carrinho.Adicionar(p3);

//  Listar produtos
carrinho.Listar();

// Calcular preço total dos produtos
carrinho.CalcularTotal();

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine($"Após a remoção de um item !");
Console.ResetColor();

// remover o produto 2
carrinho.Remover(p2);
//  Listar produtos
carrinho.Listar();
// Calcular preço total dos produtos
carrinho.CalcularTotal();

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine($"Agora vamos atualizar o objeto ");
Console.ResetColor();

// Criar um objeto com os dados atualizados
Produto _novoProduto = new Produto();
_novoProduto.Nome = "FIFA 2023";
_novoProduto.Preco = 300f;

carrinho.Atualizar(123,_novoProduto);

carrinho.Listar();

carrinho.CalcularTotal();



