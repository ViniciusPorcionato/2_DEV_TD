// Faça um programa que carregue um array de tamanho 6 com números inteiros. Calcule e imprima a quantidade de números ímpares e a quantidade de números.

int[] num = new int[6];

for (int i = 0; i < 6; i++)
{
    Console.WriteLine($"Informe o {i + 1}º número : ");
    num[i] = int.Parse(Console.ReadLine());

    if(num[i] % 2 == 0)
    {
       Console.WriteLine($"Par");
        
    }
    else
    {
        Console.WriteLine($"Ímpar");
        
    }
    
}

foreach (var item in num)
{
    
}