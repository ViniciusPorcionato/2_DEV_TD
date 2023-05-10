using Exercício_Listas;

List<Carro> carros = new List<Carro>();

Console.ForegroundColor = ConsoleColor.DarkCyan;
for (int i = 0; i < 2; i++)
{
    Carro carro = new Carro();

    Console.WriteLine($"Informe a Marca do Carro :");
    carro.Marca = Console.ReadLine();
    

    Console.WriteLine($"Informe a Cor do Carro :");
    carro.Cor = Console.ReadLine();
    

    Console.WriteLine($"Informe o Ano do Carro :");
    carro.Ano = int.Parse(Console.ReadLine());
    

    carros.Add(carro);
}
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkGreen;
foreach (var item in carros)
{
Console.WriteLine(@$"
Marca : {item.Marca} 
Cor : {item.Cor}
Ano : {item.Ano}
");
    
}
Console.ResetColor();