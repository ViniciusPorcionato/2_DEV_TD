// 	Nesta aula vamos fazer um pequeno sistema de calculadora, em um projeto de console no VsCode.

// Vamos desenvolver um programa orientado a objeto que faça as 4 operações matemáticas.

// Crie uma classe Calculadora;
// Criar um método para cada uma das operações matemáticas(retornar float);
// Fazer o menu de opções;
// Solicitar a entrada de 2 números para o cálculo e exiba o resultado do cálculo no console.


using Exercício_Calculadora_POO;

// Instanciar a classe
Calculadora calculo = new Calculadora();

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine($"Informe o Primeiro número :");
calculo.num1 = float.Parse(Console.ReadLine()!);
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine($"Informe o Segundo Número :");
calculo.num2 = float.Parse(Console.ReadLine()!);
Console.ResetColor();


Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(@$"
Informe a Operação :

[1] Somar
[2] Subtrair
[3] Multiplicar
[4] Divisão

");
Console.ResetColor();

Opcao:
string opcao = Console.ReadLine()!;

    switch (opcao)
{
    case "1":
    Console.WriteLine($"Resultado : {calculo.Somar()}");
        break;
    case "2":
    Console.WriteLine($"Resultado : {calculo.Subtrair()}");
        break;
    case "3":
    Console.WriteLine($"Resultado : {calculo.Multiplicar()}");
        break;
    case "4":
    Console.WriteLine($"Resultado : {calculo.Dividir()}");
        break;

    default:
    Console.WriteLine($"Opção Inválida! Informe Nomamente !");
    goto Opcao;
    
}



