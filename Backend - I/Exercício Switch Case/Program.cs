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
    nomeBebida = "Coca - Cola";
    break;
    case 2 : 
    nomeBebida = "Pepsi";
    break;
    case 3 : 
    nomeBebida = "Fanta";
    break;
    case 4 : 
    nomeBebida = "Monster";
    break;
    case 5 : 
    nomeBebida = "Guaraná";
    break;


}

Console.WriteLine($"Gostaria de adicionar gelo ? s/n");
char gelo = char.Parse(Console.ReadLine());



Console.WriteLine($"Informe a Quantidade de copos :");
int quantidade = int.Parse(Console.ReadLine());


Console.WriteLine(@$"

-----------------------------
|                                   
|Sua bebida é : {nomeBebida}   
|Com gelo : {gelo}             
|Quantidade de Copos  : {quantidade}     
|                                  
-----------------------------
");


