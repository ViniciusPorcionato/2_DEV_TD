using Exercício_Console_MVC.Controller;
using Exercício_Console_MVC.Model;
using Exercício_Console_MVC.View;

Evento e = new Evento();

EventoController controller = new EventoController();

string opcao = "";

Console.WriteLine($"Informe a opção desejada :");

do
{
    Console.WriteLine(@$"
                <=><=><=><=><=><=><=><=><=><=>
                    [1] Cadastrar Evento
                    [2] Listar Eventos

                    [0] Finalizar Programa
                <=><=><=><=><=><=><=><=><=><=>
                ");

    opcao = Console.ReadLine()!;

    switch (opcao)
    {
        case "1":
            controller.CadastrarEventos();
            break;
        case "2":
            controller.ListarEventos();
            break;
        default:
            break;
    }
} while (opcao != "0");










