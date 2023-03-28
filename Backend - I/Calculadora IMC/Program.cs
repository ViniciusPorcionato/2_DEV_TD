// Calculadora IMC

// Crie um programa para calcular o IMC

// entrada

string nome = "Vinicius";
float peso = 89.9f;
float altura = 1.80f;

// processamento 

float imc = peso / (altura * altura );

Console.WriteLine($"O IMC  do " + nome + " é de : " +Math.Round(imc,2));

