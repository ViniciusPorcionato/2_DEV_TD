// Faça um programa que carregue um array de tamanho 6 com números inteiros. Calcule e imprima a quantidade de números ímpares e a quantidade de números.

int[] num = new int[6];

int numPares = 0;
int numImpar = 0;

for (int i = 0; i < 6; i++)
{
    Console.WriteLine($"Informe o {i + 1}º número : ");
    num[i] = int.Parse(Console.ReadLine());

    if(num[i] % 2 == 0)
    {
       Console.WriteLine($"O número é Par");
        numPares +=1;
        Console.WriteLine($"");

    }
    else
    {
        Console.WriteLine($"O número é Ímpar");
        numImpar +=1;
        Console.WriteLine($"");

    }

    
}


Console.WriteLine(@$"
Quantidade de números Par: {numPares}
Quantidade de números Ímpares: {numImpar}

");
    
