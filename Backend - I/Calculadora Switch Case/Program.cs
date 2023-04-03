// Calculadora

// Algoritmo
// 1. Informar a operacao
// 2. Informar o primeiro numero
// 3. Informar o segundo numero
// 4. Processar os dados
// 5. Exibir o resultado


// entrada

Console.WriteLine(@$"

------------------------------
|   Programa de calculadora |
|                           |
|   Informe a operação      |
|                           |
|   (+) soma                |
|   (-) subtração           |
|   (*) multiplicação       |
|   (/) divisão             |
|                           |
------------------------------

");

Console.WriteLine($"Informe a opração : (+ , - , * e /)");

char operacao = char.Parse(Console.ReadLine());
if (operacao != '+') {
    Console.WriteLine($"Erro !");
    return;
}
else if (operacao != '-') {
    Console.WriteLine($"Erro !");
    return;
}
else if (operacao != '*') {
    Console.WriteLine($"Erro !");
    return;
}
else if (operacao != '/') {
    Console.WriteLine($"Erro !");
    return;
}



Console.WriteLine($"Informe o primeiro número : ");
double num1 = double.Parse(Console.ReadLine());

Console.WriteLine($"Informe o segundo número : ");
double num2 = double.Parse(Console.ReadLine());

double resultado = 0;


// processamento 
// saída

switch (operacao)
{
    case '+':
        resultado = (num1 + num2);
        Console.WriteLine($"O resultado da soma é igual {resultado}");
        
        break;
    case '-':
        resultado = (num1 - num2);
        Console.WriteLine($"O resultado da subtração é igual {resultado}");
        break;
    case '*':
        resultado = (num1 * num2);
        Console.WriteLine($"O resultado da multiplicação é igual {resultado}");
        break;
    case '/':
        resultado = (num1 / num2);
        Console.WriteLine($"O resultado da divisão é igual {resultado}");
        break;
    default:
    Console.WriteLine($"Erro !");
    
        break;
}


