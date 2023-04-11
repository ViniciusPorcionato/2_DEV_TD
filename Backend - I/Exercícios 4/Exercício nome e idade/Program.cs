// escreva um programa que receba e imprima o nome e idade de 5 pessoas

// personalizar cores: a resposta do nome em azul e a resposta da idade em verde (cor de fonte)

string[] nome = new string[5];
int[] idade = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Informe o {i + 1}º nome:");
    nome[i] = Console.ReadLine();

    Console.WriteLine($"Informe a idade da {i + 1}º pessoa:");
    idade[i] = int.Parse(Console.ReadLine());
    


}

for (int i = 0; i < 5; i++)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine($"{i + 1}) Nome: {nome[i]}");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"Idade: {idade[i]} anos ");
    Console.ResetColor();
    Console.WriteLine($"");
    

}
