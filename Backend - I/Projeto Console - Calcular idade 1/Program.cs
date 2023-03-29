// Calculadora de idade


// Faça um programa que receba a idade de uma pessoa e calcule a idade em meses, dias, horas e minutos. Imprima o resultado no console.

// Criar um programa para mostrar a idade em meses, dias, horas e minutos.


Console.WriteLine($"Informe seu nome : ");
string nome = Console.ReadLine();

Console.WriteLine($"Idade em anos");
int idadeAnos = int.Parse(Console.ReadLine());



int idadeMeses = idadeAnos * 12;
int idadeDias = idadeMeses * 30;
int idadeHoras = idadeDias * 24;
int idadeMinutos = idadeHoras * 60;

Console.WriteLine(@$"

idade em Meses : {idadeMeses}
idade em Dias : {idadeDias}
idade em Horas : {idadeHoras}
idade em Minutos : {idadeMinutos}


");












