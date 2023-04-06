// 4. Uma certa empresa fez uma pesquisa de mercado com 10 pessoas para saber se elas gostaram um determinado
// produto lançado. Para isso forneceu o sexo do entrevistado e sua resposta (sim ou não). Faça um programa que calcule e imprima:
// A.O número de pessoas que responderam SIM.
// B.O número de pessoas que responderam NÃO;
// C.O número de mulheres que responderam SIM;
// D.A porcentagem de homens que responderam NÃO entre todos os homens analisados.

Console.WriteLine(@$"
------------
|Pesquisa !|
------------
");

int pessoasSim = 0;
int pessoasNao = 0;
int mulheresSim = 0;
int homensNao = 0;

Console.WriteLine($"Informe seu sexo M(Masculino) F(Feminino) :");
char sexo = char.Parse(Console.ReadLine().ToLower());




