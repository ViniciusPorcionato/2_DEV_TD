//  Criar um programa que receba 5 numeros inteiros e ao final exiba o seu dobro

// Você deve utilizar a estrutura array com tamanho 5 para o armazenamento dos números, estrutura for para a leitura dos números e a estrutura foreach para exibi-los



int[] num = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Informe o {i + 1}º número : ");
    num[i] = int.Parse(Console.ReadLine());
    
}

foreach (int numero in num)
{
    Console.WriteLine($"O Número é: {numero} Seu dobro é :{numero * 2}");
    
}
