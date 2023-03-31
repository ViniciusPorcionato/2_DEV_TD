Console.WriteLine($"Informe a letra : ");
string letra = Console.ReadLine().ToUpper();

if( letra == "a" || letra == "e" || letra == "i" || letra == "o" || letra == "u")
{
    Console.WriteLine($"A letra é uma vogal ! ");
    
}
else
{
    Console.WriteLine($"A letra é uma consoante ! ");
    
}

