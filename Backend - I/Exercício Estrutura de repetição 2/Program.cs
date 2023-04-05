//Faça um programa que leia e valide as seguintes informações:

// 1. Nome: diferente de vazio;

// 2. Idade: entre 0 e 100 anos;

// 3. Salário: maior que zero;

// 4. Estado Civil: 's'(solteiro(a)), 'c'(casado(a)), 'v'(viúvo(a)), 'd'(divorciado(a));



// NOME
Console.WriteLine($"Informe seu nome :");
string nome = Console.ReadLine();

do
{
if (nome == "")
{
    Console.WriteLine($"Informe seu nome novamente :");
    nome = Console.ReadLine();    
}
Console.WriteLine($"Prossiga !");
}while (nome == "");


// IDADE**************************

Console.WriteLine($"Informe sua idade :");
int idade = int.Parse(Console.ReadLine());

do
{
   if(idade > 100)
   {

    Console.WriteLine($"Informe sua idade novamente !");
    idade = int.Parse(Console.ReadLine());
    
   }
   Console.WriteLine($"Prossiga !");
}while (idade > 100);

// SALÁRIO***********************

Console.WriteLine($"Informe seu salário");
float salario = float.Parse( Console.ReadLine());

do
{
    if(salario <= 0)
    {

    Console.WriteLine($"Informe seu salário novamente !");
    idade = int.Parse(Console.ReadLine());
    }
    else
    {
   Console.WriteLine($"Prossiga !");
    }
    
}while (salario <= 0);


// ESTADO CIVI;

Console.WriteLine($"Insira seu estado civil :");
char estadoCivil = char.Parse(Console.ReadLine().ToLower());

do
{

   if(estadoCivil == 's' || estadoCivil == 'c' || estadoCivil == 'v' || estadoCivil == 'd')
   {
    Console.WriteLine($"Prossiga !");
    
   }
   else
   {
    Console.WriteLine($"Informe seu Estado Civil novamente !");
    estadoCivil = char.Parse(Console.ReadLine().ToLower());
   }

} while (estadoCivil != 's' && estadoCivil != 'c' && estadoCivil != 'v' && estadoCivil != 'd');

Console.WriteLine(@$"
Resultado:
Nome : {nome}
Idade : {idade}
Salário : {salario}
Estado Civil: {estadoCivil}
Parabéns Cadastro concluído !!!
");






