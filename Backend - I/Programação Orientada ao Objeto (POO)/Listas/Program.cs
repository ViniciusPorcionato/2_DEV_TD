using Listas;


// criar a lista de objetos [produtos]

List<Produto> produtos = new List<Produto>();

// primeira forma de add um obj na lista
produtos.Add(
    new Produto(2563, "Camisa QuickSilver", 19.90f)
);
produtos.Add(
    new Produto(2563, "Camisa Lacoste", 29.90f)
);

// segunda forma de add um obj na lista
Produto calcaDisel = new Produto(1523, "Calça Disel", 30.00f);
produtos.Add(calcaDisel);

foreach (var item in produtos)
{
   Console.WriteLine($"Nome :{item.Nome}, Código: {item.Codigo}, Preço: {item.Preco:C} {produtos.IndexOf(item)}");
    
}

// buscar dentro de uma lista pela lambda
Produto produtoBuscado = produtos.Find(x => x.Codigo == 2563);
int index = produtos.IndexOf(produtoBuscado);
produtoBuscado.Preco = 199.90f;

// remover da lista
produtos.RemoveAt(index);
// realocar na lista
produtos.Insert(index, produtoBuscado);

Console.WriteLine($"== Lista Atualizada ==");
Console.WriteLine($"**********************");

foreach (var item in produtos)
{
    Console.WriteLine($"Nome :{item.Nome}, Código: {item.Codigo}, Preço: {item.Preco:C} {produtos.IndexOf(item)}");
}
