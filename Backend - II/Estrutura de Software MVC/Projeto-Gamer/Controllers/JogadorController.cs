
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto_Gamer.Infra;
using Projeto_Gamer.Models;

namespace Projeto_Gamer.Controllers
{
    [Route("[controller]")]
    public class JogadorController : Controller
    {
        private readonly ILogger<JogadorController> _logger;

        public JogadorController(ILogger<JogadorController> logger)
        {
            _logger = logger;
        }

        Context context = new Context();

        [Route("Listar")]
        public IActionResult Index()
        {
            ViewBag.Jogador = context.Jogador.ToList();
            ViewBag.Equipe = context.Equipe.ToList();
            return View();
        }

        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {   

            Jogador novoJogador = new Jogador() ;
            novoJogador.Nome = form["Nome"].ToString();
            novoJogador.Email = form["Email"].ToString();
            novoJogador.Senha = form["Senha"].ToString();
            novoJogador.IdEquipe = int.Parse(form["IdEquipe"].ToString());

            context.Add(novoJogador);
            context.SaveChanges();
         
            return LocalRedirect("~/Jogador/Listar");
        }

        [Route("Excluir/{id}")]
        public IActionResult Excluir(int id){

            Jogador j = context.Jogador.First(j => j.IdJogador == id);
            context.Jogador.Remove(j);
            context.SaveChanges();

            return LocalRedirect("~/Jogador/Listar");
        }


        [Route("Editar/{id}")]
        public IActionResult Editar(int id){

            ViewBag.Jogador = context.Jogador.ToList();
            ViewBag.Equipe = context.Equipe.ToList();
            Jogador j = context.Jogador.First(j => j.IdJogador == id);
            ViewBag.Jogador = j;

             return View("Edit");

        }




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}