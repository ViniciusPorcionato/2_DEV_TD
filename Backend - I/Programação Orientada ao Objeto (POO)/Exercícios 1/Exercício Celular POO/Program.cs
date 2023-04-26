// Faça em sua máquina utilizando os mesmos conceitos dado em aula.
// Crie uma Classe de um Celular, com as propriedades cor, modelo, tamanho, ligado(booleano).
// Com os métodos, ligar, desligar, fazer ligação, enviar mensagem.
// Só será possível executar tais métodos se o celular estiver ligado.
// Envie o link do repositório como entrega desta atividade.

using Exercício_Celular_POO;

Celular celular = new Celular();
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine($"Bem - Vindo ao Novo Cell! ");
Console.WriteLine($"Escolha o seu novo Celular com sua cara !");
Console.WriteLine($"Pressino <Enter> para continuar !");
Console.ReadLine();
Console.WriteLine($"Escolha o modelo do seu celular :");
celular.Modelo = Console.ReadLine()!;
Console.WriteLine($"Escolha a Cor do seu celular :");
celular.Cor = Console.ReadLine()!;
Console.WriteLine($"Escolha o tamanho do seu Celular :");
celular.Tamanho = Console.ReadLine()!;
Console.WriteLine($"");
Console.ResetColor();
celular.Ligado = false;

OpcaoInicial:
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine(@$"
Selecione uma das opções:

[1] Ligar Telefone
[0] Guardar Telefone
");
 Console.ResetColor();
string OpcaoInicial = Console.ReadLine()!;

while (celular.Ligado == false)
{
    switch (OpcaoInicial)
    {
        case "1":
            celular.Ligar();
            break;

        case "0":
            Console.WriteLine($"Celular Guardado !");
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine($"Opção Inválida !");
            goto OpcaoInicial;

    }
}

while (celular.Ligado == true)
{
    Console.ForegroundColor = ConsoleColor.DarkMagenta;
    Console.WriteLine(@$"
Selecione uma das Opções 

[1] Fazer Ligação
[2] Enviar Mensagem
[0] Desligar
    ");
    Console.ResetColor();
    string opcaoCell = Console.ReadLine()!;
    

    switch (opcaoCell)
    {
        case "1":
        celular.FazerLigacao();
            break;
        case "2":
        celular.EnviarMensagem();
            break;
        case "0":
        celular.Desligar();
            break;
        default:
            break;
    }
    
    
}














