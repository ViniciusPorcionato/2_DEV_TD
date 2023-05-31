using Microsoft.AspNetCore.Mvc;
using Projeto_Gamer.Infra;
using Projeto_Gamer.Models;

namespace Projeto_Gamer.Controllers
{
    public class EquipeController : Controller
    {
        private readonly ILogger<EquipeController> _logger;

        public EquipeController(ILogger<EquipeController> logger)
        {
            _logger = logger;
        }
        // Instância do objeto da classe Context : Acessa o banco de dados
        Context context = new Context();
        //Controller/Action
        [Route("Listar")] // https://localhost/Equipe/Listar
        public IActionResult Index()
        {
            // A ViewBag é uma "bolsa" para guardar instâncias do objeto Equipe, como uma lista
            ViewBag.Equipe = context.Equipe.ToList();
            // Retorna a View de equipe
            return View();
        }


        [Route("Cadastrar")]
        public IActionResult Cadastrar(IFormCollection form)
        {
            Equipe novaEquipe = new Equipe();

            novaEquipe.Nome = form["Nome"].ToString();

            // vem como string, o que precisamos é imagem
            // novaEquipe.Imagem = form["Imagem"].ToString();

            // lógica do upload de imagem
            if (form.Files.Count > 0)
            {
                var file = form.Files[0];
                // variavel criando combinações de caminhos
                var folder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/img/Equipes");

                if (!Directory.Exists(folder))
                {
                    Directory.CreateDirectory(folder);
                }

                var path = Path.Combine(folder, file.FileName);

                // using é o bloco de codigo onde após de terminar ele se encerra
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                novaEquipe.Imagem = file.FileName;

            }
            else
            {
                novaEquipe.Imagem = "padrao.png";
            }
            // fima da lógica de upload

            context.Equipe.Add(novaEquipe);
            // c.Add(novaEquipe) - Isso também funciona

            context.SaveChanges();

            return LocalRedirect("~/Listar");

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}