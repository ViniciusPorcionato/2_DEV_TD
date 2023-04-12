// As maçãs custam R$ 0,30 cada se forem compradas menos do que uma dúzia, e R$ 0,25 se forem compradas pelo menos doze. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o valor    total    da compra.

Console.WriteLine($"Informe o número de maçã desejadas :");
int quantidadeMaca = int.Parse(Console.ReadLine());

float valor = quantidadeMaca * (float)(quantidadeMaca >= 12 ? 0.30 : 0.25);

Console.WriteLine($" Preço : R$ {valor} ");



