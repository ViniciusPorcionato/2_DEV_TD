// Faça um algoritmo para ler: a descrição do produto (nome), a quantidade adquirida e o
// preço unitário. Calcular e escrever o total (total = quantidade adquirida * preço unitário), o
// desconto e o total a pagar (total a pagar = total - desconto), sabendo-se que:
// - Se quantidade <= 5 o desconto será de 2%
// - Se quantidade > 5 e quantidade <=10 o desconto será de 3%
// - Se quantidade > 10 o desconto será de 5%
// Dica: utilize if / else if / else

using System.Globalization;

Console.WriteLine($"Informe o nome do produto:");
string nomeProduto = Console.ReadLine();

Console.WriteLine($"Informe a quantidade: ");
int quantidadeProduto = int.Parse(Console.ReadLine());

Console.WriteLine($"Preço unitário :");
float precoUnitario = float.Parse(Console.ReadLine());

float precoProduto = quantidadeProduto * precoUnitario;

if (quantidadeProduto <= 5)
{
    precoProduto -= precoProduto * 0.02f;
}
else if(quantidadeProduto > 5 && quantidadeProduto <= 10)
{
    precoProduto -= precoProduto * 0.03f;
}
else
{
   precoProduto -= precoProduto * 0.05f; 
}

Console.WriteLine(@$"
Produto : {nomeProduto}
Quantidade : {quantidadeProduto}
{precoProduto.ToString("C", new CultureInfo("pt-BR"))}
");



