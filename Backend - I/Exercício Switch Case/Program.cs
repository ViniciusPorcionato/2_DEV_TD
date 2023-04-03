// Cardápio refrigerante

//Coca cola
//Pepsi
//Fanta
//Monster

//crie um menu de opções e peça para o usuário escolher uma das opções
//a depender da opção, exiba uma mensagem se gostaria de acrescentar gelo
//se sim, exiba uma mensagem que a bebida em questão será com adicional de gelo
//caso contrário, a bebida é sem gelo adicional


Console.WriteLine(@$"

-------------------------
|   Opções de Bebidas   |
|                       |
|   (1) Coca -cola      |
|   (2) Pepsi           |
|   (3) Fanta           |
|   (4) Monster         |
|   (5) Guaraná         |
-------------------------


");

Console.WriteLine($"Informe o número da bebida :");

int bebidas = int.Parse(Console.ReadLine());

string nomeBebida = "";

switch(bebidas)
{
    case 1 : 
    nomeBebida = "Coca - Cola"
    break;
    case 2 : 
    Console.WriteLine($"Pepsi");
    break;
    case 3 : 
    Console.WriteLine($"Fanta");
    break;
    case 4 : 
    Console.WriteLine($"Monster");
    break;
    case 5 : 
    Console.WriteLine($"Guaraná");
    break;


}

Console.WriteLine($"Gostaria de adicionar gelo ? sim/não");
string gelo = Console.ReadLine().ToUpper();




Console.WriteLine($"Informe a Quantidade :");
int quantidade = int.Parse(Console.ReadLine());


Console.WriteLine(@$"Pedido : {bebidas} 
Com gelo : {gelo} 
Quantidade : {quantidade}");
