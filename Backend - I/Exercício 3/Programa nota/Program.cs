// 1. Faça um programa que peça uma nota, entre zero e dez. Mostre uma mensagem caso o valor seja inválido e continue pedindo até que o usuário informe um valor válido.

Console.WriteLine($"Informe a sua nota :");
float nota = float.Parse(Console.ReadLine());


do
{
    
    if(nota > 10 || nota < 0)
    {
        Console.WriteLine($"Nota inválida, tente novamente");
        nota = float.Parse(Console.ReadLine());
        
    }
    else
    {
        Console.WriteLine($"Nota válida !");
        
    }

} while (nota > 10 || nota < 0);
