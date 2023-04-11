// Sem for e sem foreach
// string[] carros = new string[3];

// Console.WriteLine($"Digite o nome do carro :");
// carros[0] = Console.ReadLine();

// Console.WriteLine($"Digite o nome do carro :");
// carros[1] = Console.ReadLine();

// Console.WriteLine($"Digite o nome do carro :");
// carros[2] = Console.ReadLine();


// Console.WriteLine($"Primeiro carro da lista : {carros[0]}");
// Console.WriteLine($"Primeiro carro da lista : {carros[1]}");
// Console.WriteLine($"Primeiro carro da lista : {carros[2]}");


// **************************************************************************************************************************

// sem foreach apenas com for
// string[] carros = new string[10];

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine($"Informe o nome do carro:");
//     carros[i] = Console.ReadLine();
    
    
// }

// for (int i = 0; i < 3 ; i++)
// {
//     Console.WriteLine($"Nome do carro: {carros[]}");
    
// }

// **************************************************************************************************************************

// Com foreach     
string[] carros = new string[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Informe o nome do carro:");
    carros[i] = Console.ReadLine();
    
    
}

foreach (var item in carros)
{
    Console.WriteLine($"Nome do carro : {item}");
    
}

