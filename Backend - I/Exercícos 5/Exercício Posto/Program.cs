// Um posto está vendendo combustíveis com a seguinte tabela de descontos:
// Álcool:
// . até 20 litros, desconto de 3% por litro Álcool
// . acima de 20 litros, desconto de 5% por litro
// Gasolina:
// . até 20 litros, desconto de 4% por litro Gasolina
// . acima de 20 litros, desconto de 6% por litro

// Escreva um algoritmo que leia o número de litros vendidos e o tipo de combustível (codificado
// da seguinte forma: A-álcool, G-gasolina), calcule e imprima o valor a ser pago pelo cliente
// sabendo-se que o preço do litro da gasolina é R$ 5,30 e o preço do litro do álcool é R$ 4,90.
// Dica: utilize switch case e funções/métodos para otimizar o algorítimo.

using System.Globalization;

float precoGasolina = 5.30f;
float precoAlcool = 4.90f;

Console.WriteLine(@$"
_____________________________________
|                                   |
|       Selecione                   |
|                                   |
|   [1] Álcool : Preço R$ 4,90      |
|                                   |
|   [2] Gasolina : Preço R$ 5,30    |
|                                   |
-------------------------------------
");

Console.Write($"Informe a opção de combustível :");
int combustivel = int.Parse(Console.ReadLine());

Console.Write($"Informe a quantidade em litros :");
int litros = int.Parse(Console.ReadLine());



switch (combustivel)
{
    case 1:
    if (litros <= 20)
    {
        precoAlcool -= precoAlcool * 0.03f;
    }
    else
    {
        precoAlcool -= precoAlcool * 0.05f;
    }
        break;

    case 2:

    if (litros <= 20)
    {
        precoGasolina -= precoGasolina * 0.04f;
    }
    else
    {
        precoGasolina -= precoGasolina * 0.06f;
    }
    break;
    
    default:
    Console.WriteLine($"Opção indisponível");
        break;
}

if( combustivel == 1){
Console.WriteLine($"{(litros * precoAlcool).ToString("C", new CultureInfo("pt-BR"))}");
}
else{
 Console.WriteLine($"{(litros * precoGasolina).ToString("C", new CultureInfo("pt-BR"))}");
}
