
Console.WriteLine($"Informe seu salário: ");

float salario = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe seus gastos: ");

float gastos = float.Parse(Console.ReadLine());

if(salario > gastos)
{
Console.WriteLine($"Gastos dentro do orçamento ! ");

}
else
{
    Console.WriteLine($"Orçamento estourado !");
    
}