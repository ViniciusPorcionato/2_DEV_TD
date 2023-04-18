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


const int senha = 123456;

// FUNÇÃO LOGIN PARA A PESSOA LOGAR USANDO USUÁRIO E SENHA
static void Login(){

string nomeUsuario = "";


Login:

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
int senhaLogin = int.Parse( Console.ReadLine()!);
        

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
int opcoesMenu = int.Parse(Console.ReadLine()!);

string[] NomePassageiro = new string[5];
string[] OrigemPassageiro = new string[5];
string[] DestinoPassageiro = new string[5];
string[] DataVoo = new string[5];

switch (opcoesMenu)
{
     case 1:
     for (int i = 0; i < 6; i++)
     {
          Console.WriteLine($"Informe o Nome do {i + 1}º Passageiro :");
          NomePassageiro[i] = Console.ReadLine()!.ToLower();
          Console.WriteLine($"Informe a Origem do {i + 1}º Passageiro :");
          OrigemPassageiro[i] = Console.ReadLine()!.ToLower();
          Console.WriteLine($"Informe o Destino do {i + 1}º Passageiro :");
          DestinoPassageiro[i] = Console.ReadLine()!.ToLower();
          Console.WriteLine($"Informe a Data do Voo do {i + 1}º Passageiro :");
          DataVoo[i] = Console.ReadLine()!.ToLower();
          
          
     }

          break;

          case 2:
          
          break;

          // case 0:

          // Console.WriteLine($"Ir para tela de login !");
          // goto Login;


     default:
     Console.WriteLine($"Opção Inválida ! Selecione outra Opção:");
     goto Menu;
          
}
