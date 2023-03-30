// informar o lado 1
Console.WriteLine($"Informe o lado 1 :");
float lado1 = float.Parse(Console.ReadLine());
// informar o lado 2
Console.WriteLine($"Informe o lado 2 :");
float lado2 = float.Parse(Console.ReadLine());
// informar o lado 3
Console.WriteLine($"Informe o lado 3 :");
float lado3 = float.Parse(Console.ReadLine());
// comparar os três lados
if(lado1 == lado2 && lado2 == lado3)
{
    Console.WriteLine($"Triângulo Equilátero");
    
}
// camparar lados, porém apenas dois iguais
else if(lado1  == lado2 || lado2 == lado3 || lado1 == lado3)
{
    Console.WriteLine($"Triângulo Isóscele");
    
}
// comparar os lados, porëm nenhum igual
else
{
    Console.WriteLine($"Triângulo Escaleno");
    
}

