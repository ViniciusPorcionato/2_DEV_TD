Console.WriteLine($"Informe o dia do seu aniversário :");
int dia = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe o mês do seu aniversário :");
int mes = int.Parse(Console.ReadLine());

Console.WriteLine($"Informe o ano do seu aniversário :");
int ano = int.Parse(Console.ReadLine());

if(dia <= 31 && mes <= 12 && ano <= 2013 )
{
    Console.WriteLine($"{dia}/{mes}/{ano}");
    
}
else
{
    Console.WriteLine($"Data inesxistente");
    return;
}

