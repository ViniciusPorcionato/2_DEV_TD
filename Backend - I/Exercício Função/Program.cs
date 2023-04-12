// Criar metodo para somar dois números

static float Somar(float n1, float n2){
    return n1 + n2;

}
static float Subtrair(float n1, float n2){
    return n1 - n2;

}
static float Dividir(float n1, float n2){
    return n1 / n2;

}
static float Multiplicar(float n1, float n2){
    return n1 * n2;

}

Console.WriteLine($"Informe o 1º número :");
float n1 = float.Parse(Console.ReadLine());

Console.WriteLine($"Informe o 2º número");
float n2 = float.Parse(Console.ReadLine());

float results = Somar(n1 , n2);
Console.WriteLine($"Resultado soma : {results}");
results = Subtrair(n1 , n2);
Console.WriteLine($"Resultado Subtração : {results}");
results = Dividir(n1 , n2);
Console.WriteLine($"Resultado Divisão : {results}");
results = Multiplicar(n1 , n2);
Console.WriteLine($"Resultado Multiplicação : {results}");
