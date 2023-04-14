// - Faça um algoritmo para ler 15 números e armazenar em um vetor. Após a leitura total dos
// 15 números, o algoritmo deve escrever esses 15 números lidos na ordem inversa da qual foi
// declarado.

float[] numeros = new float[15];

for (int i = 0; i < 15; i++)
{
    Console.WriteLine($"Informe o {i + 1}º número :");
    numeros[i] = float.Parse(Console.ReadLine());
    
    
}

foreach (float num in numeros.Reverse())
{
    Console.Write(num+" | ");
    
}

