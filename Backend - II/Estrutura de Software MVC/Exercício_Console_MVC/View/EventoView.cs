using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercício_Console_MVC.Controller;
using Exercício_Console_MVC.Model;

namespace Exercício_Console_MVC.View
{
    public class EventoView
    {
        EventoController controller = new EventoController();
        public void Listar(List<Evento> evento)
        {
            foreach (var item in evento)
            {
                Console.WriteLine($"\nNome do evento : {item.Nome}");
                Console.WriteLine($"Descrição do evento : {item.Descricao}");
                Console.WriteLine($"Data do evento : {item.Data}");

            }
        }


        public Evento Cadastrar()
        {
            Evento novoEvento = new Evento();

            Console.WriteLine($"Informe o Nome do evento :");
            novoEvento.Nome = Console.ReadLine()!;
            Console.WriteLine($"Informe a descrição do evento :");
            novoEvento.Descricao = Console.ReadLine();
            Console.WriteLine($"Informe a data do evento :");
            novoEvento.Data = DateTime.Parse(Console.ReadLine()!);

            return novoEvento;
        }

        public void GerarMenu()
        {
            
        }
    }
}