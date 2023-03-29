// Faç um programa que receba 5 notas de um aluno e calcule a média aritmética. Imprimir a resposta console



Console.WriteLine($"Informe o nome da pessoa: ");
string nome = Console.ReadLine();

Console.WriteLine($"Infome a nota 1 : ");
float nota1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Infome a nota 2 : ");
float nota2 = float.Parse(Console.ReadLine());

Console.WriteLine($"Infome a nota 3 : ");
float nota3 = float.Parse(Console.ReadLine());

Console.WriteLine($"Infome a nota 4 : ");
float nota4 = float.Parse(Console.ReadLine());

Console.WriteLine($"Infome a nota 5 : ");
float nota5 = float.Parse(Console.ReadLine());

float media = (nota1 + nota2 + nota3 + nota4 + nota5) /5;


Console.WriteLine(@$"

Nota 1 : {nota1}
Nota 2 : {nota2}
Nota 3 : {nota3}
Nota 4 : {nota4}
Nota 5 : {nota5}

Média do aluno: {media}

");





