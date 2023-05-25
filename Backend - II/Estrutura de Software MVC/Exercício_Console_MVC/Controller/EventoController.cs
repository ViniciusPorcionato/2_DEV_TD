using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercício_Console_MVC.Model;
using Exercício_Console_MVC.View;

namespace Exercício_Console_MVC.Controller
{
    public class EventoController
    {
        Evento evento = new Evento();
        EventoView eventoView = new EventoView();

        public void ListarEventos()
        {
            List<Evento> eventos = evento.Ler();
            eventoView.Listar(eventos);
        }

        public void CadastrarEventos()
        {
            Evento novoEvento = eventoView.Cadastrar();
            evento.Inserir(novoEvento);
        }



    }


}