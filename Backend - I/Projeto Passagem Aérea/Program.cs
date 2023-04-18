// Criar uma aplicação para uma agência de turismo, no qual deveremos registrar passagens aéreas com os seguintes dados: Nome do passageiro, Origem, Destino e Data do Voo de 5 passageiros.

// Antes de entrar no sistema faça um esquema do qual o usuário só possa acessar o menu se a senha for igual à 123456.
// O sistema deve exibir um menu com as seguintes opções:

// 1- Cadastrar passagem
// 2- Listar Passagens
// 0- Sair
// Observação :  Criar ao menos uma função (Efetuar Login).

// Ao cadastrar uma passagem ao final o sistema deverá perguntar se gostaria de cadastrar uma nova passagem caso contrário voltar ao menu anterior(S/N).



// ALGORITMO

// Fazer login e senha
// Se a senha for diferente a senha cadastrada, ent fazer novamente
// Após entrar menu

// Cadastrar passagem = nome do passageiro, origem, destino e data de voo de 5 passageiros

// const senha
const int senha = 123456;

// FUNÇÃO LOGIN PARA A PESSOA LOGAR USANDO USUÁRIO E SENHA
static void Login()
{

    string nomeUsuario = "";



    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine(@$"

_____________________________
|                           |
|     Pressione <ENTER>     |       
|           para            |
|      Efetuar Login        |
|                           |
-----------------------------

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


// CHAMAR FUNÇÃO*************************
Login();


string[] NomePassageiro = new string[5];
string[] OrigemPassageiro = new string[5];
string[] DestinoPassageiro = new string[5];
string[] DataVoo = new string[5];

Menu:
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@$"

SELECIONE UMA DAS OPÇÕES !
_____________________________
|           MENU            |
|                           |
|   [1] Cadastrar Passagem  |
|                           |              
|   [2] Listar Passagens    |
|                           |
|   [0] Sair                |
|                           |
-----------------------------

");
Console.ResetColor();

Console.Write($"Insira a Opção Desejada:");
string opcoesMenu = Console.ReadLine()!;


string MaisOpcoes = " ";

switch (opcoesMenu)
{

    case "1":
    Cadastro:
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Informe o Nome do {i + 1}º Passageiro :");
            NomePassageiro[i] = Console.ReadLine()!.ToLower();
            Console.WriteLine($"Informe a Origem do {i + 1}º Passageiro :");
            OrigemPassageiro[i] = Console.ReadLine()!.ToLower();
            Console.WriteLine($"Informe o Destino do {i + 1}º Passageiro :");
            DestinoPassageiro[i] = Console.ReadLine()!.ToLower();
            Console.WriteLine($"Informe a Data do Voo do {i + 1}º Passageiro (dd/mm/aaaa) :");
            DataVoo[i] = Console.ReadLine()!.ToLower();
        }

    MaisPassagens:
        Console.WriteLine($"Deseja Cadastrar mais Passagem ? S(Sim) ou N(Não)");
        MaisOpcoes = Console.ReadLine()!.ToLower();
        if (MaisOpcoes == "s")
        {
            goto Cadastro;
        }
        else if (MaisOpcoes == "n")
        {

            goto Menu;
        }
        else
        {
            Console.WriteLine($"Opção Inválida !");
            goto MaisPassagens;
        }



    case "2":
        for (int i = 0; i < 5; i++)

        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(@$"
               Nome do {i + 1}º Passageiro: {NomePassageiro[i]}
               Origem do {i + 1}º Passageiro: {OrigemPassageiro[i]}
               Destino do {i + 1}º Passageiro: {DestinoPassageiro[i]}
               Data do Voo do {i + 1}º Passageiro: {DataVoo[i]}
               ");
            Console.ResetColor();
        }
        break;

    case "0":
     return;


    default:
        Console.WriteLine($"Opção Inválida ! Selecione outra Opção:");
        goto Menu;

}
