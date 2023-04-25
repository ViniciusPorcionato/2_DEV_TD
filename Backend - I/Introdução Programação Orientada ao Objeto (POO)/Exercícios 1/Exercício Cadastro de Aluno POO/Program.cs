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
Console.ForegroundColor=ConsoleColor.DarkGreen;
Console.WriteLine(@$"
Cadastro do Aluno !
Press <ENTER> para
Continuar
");
Console.ResetColor();
Console.ReadLine();

// formulário
Console.WriteLine($"Informe o Nome do aluno :");
cadastro.Nome = Console.ReadLine()!;
// formulário
Console.WriteLine($"Informe a Idade do Aluno :");
cadastro.Idade = int.Parse(Console.ReadLine()!);
// formulário
Console.WriteLine($"Informe a Cédula de Identidade (RG) : ");
cadastro.RG = Console.ReadLine()!;

Console.WriteLine($"Informe o Nome do Curso :");
cadastro.NomeCurso = Console.ReadLine()!;


Console.WriteLine($"Informe a Mensalidade do Aluno :");
cadastro.ValorMensalidade = float.Parse(Console.ReadLine()!);


// formulário
bolsa:
Console.WriteLine($"O aluno é Bolsista s(Sim) / n(Não): ");
char bolsaEstudantil = char.Parse(Console.ReadLine()!.ToLower());
switch (bolsaEstudantil)
{
    case 's':
    cadastro.Bolsista = true;
    Console.WriteLine($"O aluno é Bolsista !");
        break;
    case 'n':
    cadastro.Bolsista = false;
    Console.WriteLine($"O aluno não é Bolsista !");
        break;


    default:
    Console.WriteLine($"Opção Inválida ! Informe Novamente");
    goto bolsa;
    
}
// formulário
Console.WriteLine($"Informe a média final do Aluno :");
cadastro.MediaFinal = float.Parse(Console.ReadLine()!);



// resultado final / ficha do aluno
Console.WriteLine(@$"
___________________________________________________________
Ficha de Cadastro do aluno {cadastro.Nome} :
Nome : {cadastro.Nome}
Idade : {cadastro.Idade}
RG : {cadastro.RG}
Curso : {cadastro.NomeCurso}
Bolsista : {bolsaEstudantil}
___________________________________________________________
Média Final : {cadastro.VerMedia()}
Mensalidade : {cadastro.VerMensalidade().ToString("C", new CultureInfo("pt-BR"))}



");








