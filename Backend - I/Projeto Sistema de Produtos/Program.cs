// Nesta aula vamos aplicar o seguinte projeto para gerenciamento de 10 produtos pelo console:
// Os produtos terão os seguintes atributos:
// string Nome
// float Preco
// bool Promocao (se está em promoção ou não)

// O sistema deverá ter as seguintes funcionalidades:
// CadastrarProduto
// ListarProdutos
// MostrarMenu
// Crie função(ões) para otimizar o código.
// Incremente o que achar necessário. Utilize sua lógica e sua criatividade.


using System.Globalization;

// const senha
const int senha = 12345678;

// FUNÇÃO LOGIN PARA A PESSOA LOGAR USANDO USUÁRIO E SENHA
static void Login()
{

    string nomeUsuario = "";



    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine(@$"

_____________________________
|                           |
|     Pressione <ENTER>     |       
|           para            |
|      Efetuar Login        |
_____________________________

");
    Console.ResetColor();
    Console.ReadLine();



    Console.Write($"Informe o nome de usuário :");
    nomeUsuario = Console.ReadLine()!;

senha:

    Console.Write($"Informe a Senha :");
    int senhaLogin = int.Parse(Console.ReadLine()!);


    if (senha == senhaLogin)
    {
        Console.WriteLine($"Login com sucesso");

    }
    else
    {
        Console.WriteLine($"Senha Incorreta ! ");
        goto senha;
    }
}

string[] NomeProduto = new string[10];
int[] QuantidadeProduto = new int[10];
char maisProdutos = ' ';
string[] PromocaoProdutos = new string[10];
float[] PrecoProduto = new float[10];
bool Promocao = true;

// ****************************************************************

Login();

Menu:

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine(@$"

SELECIONE UMA DAS OPÇÕES !
_____________________________
|           MENU            |
|                           |
|   [1] Cadastrar Produto   |
|                           |              
|   [2] Listar Produto      |
|                           |
|   [0] Sair                |
|                           |
-----------------------------

");
Console.ResetColor();

Console.Write($"Selecione uma das opções :");
string opcaoMenu = Console.ReadLine();

switch (opcaoMenu)
{
    case "1":
        CadastrarMaisProdutos:
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Informe o Nome do {i + 1}º Produto :");
            NomeProduto[i] = Console.ReadLine();

            Console.WriteLine($"Informe o Preço do {i + 1}º Produto :");
            PrecoProduto[i] = float.Parse(Console.ReadLine());


            Promocao:
            Console.WriteLine(@$"
                O Produto está em Promoção ?
                Informe:

                [sim] - Está em Promoção
                [não] - Não está em Promoção");
            PromocaoProdutos[i] = Console.ReadLine().ToLower();


            switch (PromocaoProdutos[i])
            {
                case "sim":
                    Promocao = true;
                    break;
                case "não":
                    Promocao = false;
                    break;
                default:
                    Console.WriteLine($"Opção Inválida !");
                    goto Promocao;
            }

        }



        MaisProdutos:
        Console.WriteLine($"Deseja cadastrar mais produtos ? S(Sim) / N(Não)");
        maisProdutos = char.Parse(Console.ReadLine().ToLower());
        if (maisProdutos == 's')
        {
            Console.WriteLine($"Cadastre mais Produtos !");

            goto CadastrarMaisProdutos;
        }
        else if (maisProdutos == 'n')
        {
            goto Menu;
        }
        else
        {
            Console.WriteLine($"Opção Inválida ! Informe novamente");
            goto MaisProdutos;
        }

    case "2":

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine(@$"
                Nome do {i + 1}º Produto : {NomeProduto[i]}
                Preço do {i + 1}º Produto : {PrecoProduto[i].ToString("C", new CultureInfo("pt-BR"))}
                {i + 1}º Produto em Promoção : {PromocaoProdutos[i]}
                ");
        }
        break;

    case "0":
        Console.WriteLine($"Fim do Programa !");
        break;

    default:
        Console.WriteLine($"Opção Inválida");
        goto Menu;

}


