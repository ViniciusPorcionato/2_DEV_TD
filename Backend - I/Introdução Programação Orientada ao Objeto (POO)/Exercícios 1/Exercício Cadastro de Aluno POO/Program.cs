// Nesta aula vamos fazer um pequeno sistema de cadastro de alunos, em um projeto de console no VsCode.

// Vamos desenvolver um programa que cadastre e mostre os dados de um aluno.

// Crie uma classe Aluno com as seguintes propriedades:

// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 
// Também teremos os métodos: 

// VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.

// obs:
// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// outros casos a mensalidade será integral
// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.




// instanciar a classe

using System.Globalization;
using Exercício_Cadastro_de_Aluno_POO;

Aluno cadastro = new Aluno();
// menu login
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@$"
Cadastro do Aluno !
Press <ENTER> para
Continuar
");
Console.ResetColor();
Console.ReadLine();

// formulário nome
Console.WriteLine($"Informe o Nome do aluno :");
cadastro.Nome = Console.ReadLine()!;
// formulário idade
Console.WriteLine($"Informe a Idade do Aluno :");
cadastro.Idade = int.Parse(Console.ReadLine()!);
// formulário RG
Console.WriteLine($"Informe a Cédula de Identidade (RG) : ");
cadastro.RG = Console.ReadLine()!;
// formulário nome do curso
Console.WriteLine($"Informe o Nome do Curso :");
cadastro.NomeCurso = Console.ReadLine()!;


Console.WriteLine($"Informe a Mensalidade do Aluno :");
cadastro.ValorMensalidade = float.Parse(Console.ReadLine()!);


// formulário bolsista
bolsa:
Console.WriteLine($"O aluno é Bolsista s(Sim) / n(Não): ");
char bolsaEstudantil = char.Parse(Console.ReadLine()!.ToLower());
if(bolsaEstudantil == 's')
{
    cadastro.Bolsista = true;
}
else if (bolsaEstudantil == 'n')
{
    cadastro.Bolsista = false;
}
else
{
    Console.WriteLine($"Opção Inválida !");
    goto bolsa;
}

// formulário
Console.WriteLine($"Informe a média final do Aluno :");
cadastro.MediaFinal = float.Parse(Console.ReadLine()!);

Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine(@$"
*****Menu*****

[1]- Mostrar Média
[2]- Mostrar Mensalidade
[3] - Ficha de Cadastro

[0]- Sair
");
Console.ResetColor();
opcao:
Console.WriteLine($"Informe uma das opções :");
string opcao = Console.ReadLine()!;

Console.ForegroundColor = ConsoleColor.DarkYellow;

switch (opcao)
{
    case "1":
    Console.WriteLine(@$"
    Aluno : {cadastro.Nome}
    Média Final : {cadastro.VerMedia()}
    ");
    goto opcao;

    case "2":
    Console.WriteLine(@$"
    Aluno : {cadastro.Nome}
    Mensalidade : {cadastro.VerMensalidade().ToString("C", new CultureInfo("pt-BR"))}
    ");
    goto opcao;

    case "3":

    Console.WriteLine(@$"
    Ficha de Cadastro do aluno {cadastro.Nome} :
    Nome : {cadastro.Nome}
    Idade : {cadastro.Idade}
    RG : {cadastro.RG}
    Curso : {cadastro.NomeCurso}
    Bolsista : {bolsaEstudantil}
    ");
    goto opcao;

    case "0":
    Console.WriteLine($"Sessão Encerrada !");
    break;

    default:
    Console.WriteLine($"Opção Inválida !");
        break;
}
    Console.ResetColor();







// resultado final / ficha do aluno
// imprimir









