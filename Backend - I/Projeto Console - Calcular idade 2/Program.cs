// Faça um programa que receba o ano do nascimento de uma pessoa e calcule a idade dessa pessoa em anos
// e semanas e imprima o resultado no console.

// nome
Console.WriteLine($"Informe seu nome");
string nome = Console.ReadLine();


Console.WriteLine($"Ano de nascimento");
int anoNascimento = int.Parse(Console.ReadLine());


int anos = DateTime.Now.Year - anoNascimento;
int semanas = anoNascimento * 52;

Console.WriteLine(@$"

Idade em anos : {anos}
Idade em semanas:  {semanas}

");


