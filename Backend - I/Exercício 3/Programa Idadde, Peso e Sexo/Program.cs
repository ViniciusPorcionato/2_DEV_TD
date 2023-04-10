// 5. Faça um programa que receba a idade, o peso e o sexo de 10 pessoas. Calcule e imprima:
      
// A.Total de Homens;      
// B.Total de Mulheres;      
// C.Média de idade dos Homens;      
// D.Média de idade das mulheres.



// Algoritmo

// Saber idade do entrevistado
// Saber peso do entrevistado
// Saber sexo do entrevistado

// Calcular total de homens
// Calcular idade média dos homens

// Calcular total de mulheres
// Calcular idade média dos mulheres

// Declarar variáveis

int idade;
float peso ;
char sexo ;

int totalHomem = 0;
int idadeHomem = 0;

int totalMulher = 0;
int idadeMulher = 0;

for (int i = 0; i <= 10; i++)
{
    Console.WriteLine($"Informe sua idade :");
    idade = int.Parse(Console.ReadLine());

    Console.WriteLine($"Informe seu peso :");
    peso = float.Parse(Console.ReadLine());

    Console.WriteLine(@$"Informe seu sexo:
    (M) - Masculino
    (F) - Feminino");
    // sexo = char.Parse(Console.ReadLine());

do
{
     sexo = char.Parse(Console.ReadLine());
    if (sexo == 'f')
    {
        totalMulher++;
        idadeMulher+= idade;
    }
    else if(sexo == 'm')
    {
        totalHomem++;
        idadeHomem+= idade;
    }
    else
    {
        Console.WriteLine($"Sexo incorreto ! Informe novamente");
        
    }

} while (sexo != 'f' && sexo != 'm');


}


Console.WriteLine(@$"
Total de Homens: {totalHomem}
Total de Mulheres: {totalMulher}
---------------------------------
Média idade homens : {idadeHomem / totalHomem} anos
Média idade homens : {idadeMulher / totalMulher} anos

");
