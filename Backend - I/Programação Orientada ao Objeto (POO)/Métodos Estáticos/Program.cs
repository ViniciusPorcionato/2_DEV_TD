using System.Globalization;
using Métodos_Estáticos;
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine($"== SISTEMA CONVERSOR DE MOEDA ==");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
opcao:
Console.WriteLine($"Informe a Opção Desejada:");
Console.WriteLine(@$"
[1] - Real Para Dólar
[2] - Dólar Para Real
[0] - Sair
");


int opcao = int.Parse(Console.ReadLine()!);

switch (opcao)
{
    case 1:
    float resultado1 = Cambio.RealToDolar(5);
    Console.WriteLine($"O valor da conversão é : {resultado1.ToString("C", new CultureInfo("en-US"))}");
    goto opcao;

    case 2:
    float resultado2 = Cambio.DolarToReal(5);
    Console.WriteLine($"O valor da conversão é : {resultado2.ToString("C", new CultureInfo("pt-BR"))}");
    goto opcao;

    case 0:
        break;
    default:
    Console.WriteLine($"Opção Inválida !");
    
    goto opcao;
}
Console.ResetColor();


