// Condicional simples

bool sol = true;

if (sol)
{
    Console.WriteLine($"Vou para a praia : ");
    
}



// Condicional Composta

Console.WriteLine($"O dia está ensolarado ? ");
string sol = Console.ReadLine()!.ToUpper(); //usar letra tanto minuscula quanto maiuscula

Console.WriteLine($"Você está de folga ? ");
string folga = Console.ReadLine()!.ToUpper();//usar letra tanto minuscula quanto maiuscula

// se_____
if ((sol == "SIM") &&  (folga == "SIM"))
{
    Console.WriteLine($"Vou para a praia ! ");
    
}
// caso contrário _______
else
{
    Console.WriteLine($"Eu vou é trabalhar ");
    
}





// Condicional Encadeada (alinhada ou encaixada)
Console.WriteLine($"idade: ");

int idade = int.Parse(Console.ReadLine()!);


// se _________
if (idade >= 18 &&  idade < 80)
{
    Console.WriteLine($"Pode entrar na festa, beba com moderação !");
    
}

else if (idade >= 16 && idade < 18)
{
    Console.WriteLine($"Pode entrar na festa com a Mamãe !");

}
// se não ____________
else 
{
    Console.WriteLine($"Vai brincar de carrinho e boneca !");
    
}