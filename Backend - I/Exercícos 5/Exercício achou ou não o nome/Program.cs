// Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
// lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
// pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
// entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.

string[] nomes = new string[10];

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Informe o {i + 1}º nome:");
    nomes[i] = Console.ReadLine().ToLower();
      
}

Console.Write($"Informe o nome que você deseja procurar: ");

string nomesProcurado = Console.ReadLine().ToLower();


    if(nomes.Contains(nomesProcurado))
{
        Console.WriteLine($"Nome encontrado !");}
else
{    
    Console.WriteLine($"Nome não encontrado !");}
    

    

