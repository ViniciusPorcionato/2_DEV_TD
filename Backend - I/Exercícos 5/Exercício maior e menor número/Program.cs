// Faça um programa que leia 10 valores digitados pelo usuário e no final, escreva o maior e o
// menor valor lido.

Console.WriteLine($"Informe valores 10 vezes");
float[] numeros = new float[10];

for (int i = 0; i <= 9; i++)
{
    Console.WriteLine($"Informe o {i + 1}º valor :");
    numeros[i] = float.Parse(Console.ReadLine());
    
}

    Console.WriteLine(@$"
    Maior número informado : {numeros.Max()}
    Menor número informado : {numeros.Min()}
    ");
    

