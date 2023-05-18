

namespace Projeto_de_Produtos
{
    public class Marca
    {
        public int Codigo { get; set; }
        public string? NomeMarca { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;

        List<Marca> ListaDeMarcas = new List<Marca>();


        public void Cadastrar()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Marca marcas = new Marca();

            Console.WriteLine($"Informe o Código da Marca :");
            marcas.Codigo = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Informe o Nome da Marca :");
            marcas.NomeMarca = Console.ReadLine();
            Console.WriteLine($"Data do Cadastro : {marcas.DataCadastro}");

            ListaDeMarcas.Add(marcas);

            Console.WriteLine($"Marca Adicionado na Lista !");
            Console.ResetColor();


        }

        public void Listar()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            if (ListaDeMarcas.Any())
            {
               foreach (var item in ListaDeMarcas)
            {
                Console.WriteLine(@$"
                == Marca Cadastrado ==
                Código : {item.Codigo}
                Nome : {item.NomeMarca}
                Data do Cadastro : {item.DataCadastro}
                ");

            } 
            }
            else
            {
                Console.WriteLine($"Lista vazia !");
                
            }
             Console.ResetColor();
        }

        public void Deletar(int codigo2){
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Informe o Código da marca que deseja Remover :");
            codigo2 = int.Parse(Console.ReadLine()!);
            
            
            Marca marcaBuscado = ListaDeMarcas.Find(x => x.Codigo == codigo2)!;
            ListaDeMarcas.Remove(marcaBuscado);
            Console.ResetColor();
        }



    }
}