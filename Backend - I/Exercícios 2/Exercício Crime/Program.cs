// Faça um programa que faça 5 perguntas para uma pessoa sobre um crime. As perguntas são:

// "Telefonou para a vítima?"

// "Esteve no local do crime?"

// "Mora perto da vítima?"

// "Devia para a vítima?"

// "Já trabalhou com a vítima?"

// O programa deve no final emitir uma classificação sobre a participação da pessoa no crime. Se a pessoa responder positivamente a 2 questões ela deve ser classificada como "Suspeita", entre 3 e 4 como "Cúmplice" e 5 como “Culpado“. Caso contrário, ele será classificado como "Inocente“.

Console.WriteLine($"Questionário : ");

int incremento = 0;

Console.WriteLine($"Telefonou para a vítima ? sim/não ");
string resposta1 = Console.ReadLine().ToUpper();
incremento += (resposta1 == "SIM") ? 1 : 0;


Console.WriteLine($"Esteve no local do crime ? sim/não ");
string resposta2 = Console.ReadLine().ToUpper();
incremento += (resposta2 == "SIM") ? 1 : 0;


Console.WriteLine($"Mora perto da vítima ? sim/não ");
string resposta3 = Console.ReadLine().ToUpper();
incremento += (resposta3 == "SIM") ? 1 : 0;


Console.WriteLine($"Devia para a vítima ? sim/não ");
string resposta4 = Console.ReadLine().ToUpper();
incremento += (resposta4 == "SIM") ? 1 : 0;


Console.WriteLine($"Já trabalhou com a vítima ? sim/não ");
string resposta5 = Console.ReadLine().ToUpper();
incremento += (resposta5 == "SIM") ? 1 : 0;
Console.WriteLine($"{incremento}");


if (incremento == 5)
{
    Console.WriteLine($"Culpado");

}
else if (incremento >= 3)
{
    Console.WriteLine($"Cumplice");
    
}
else if( incremento == 2)
{
    Console.WriteLine($"Suspeito");
    
}
else
{
    Console.WriteLine($"Inocente");
    
}






