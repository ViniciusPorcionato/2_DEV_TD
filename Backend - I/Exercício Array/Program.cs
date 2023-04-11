string[] carros = new string[3];

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Informe o nome do {i + 1}º carro:");
    carros[i] = Console.ReadLine();
      
}

for (int i = 0; i < 3 ; i++)
{
    Console.WriteLine($"Nome do {i + 1}º carro: {carros[i]}");
    
}