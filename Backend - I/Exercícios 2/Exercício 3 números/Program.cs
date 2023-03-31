Console.WriteLine($"Informe o valor 1 :");
double valor1 = double.Parse(Console.ReadLine());

Console.WriteLine($"Informe o valor 2 :");
double valor2 = double.Parse(Console.ReadLine());

Console.WriteLine($"Informe o valor 3 :");
double valor3 = double.Parse(Console.ReadLine());


double maiorNumero = new double[] {valor1, valor2, valor3}.Max();
double menorNumero = new double[] {valor1, valor2, valor3}.Min();

Console.WriteLine(@$"

Números: {valor1}, {valor2} e {valor3}
Valor máximo : {maiorNumero}
Valor minímo : {menorNumero}
");



