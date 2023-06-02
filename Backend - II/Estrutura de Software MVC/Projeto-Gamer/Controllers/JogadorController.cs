
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto_Gamer.Infra;

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



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}