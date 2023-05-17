

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
            Marca marcas = new Marca();

            Console.WriteLine($"Informe o Código da Marca :");
            marcas.Codigo = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Informe o Nome da Marca :");
            marcas.NomeMarca = Console.ReadLine();
            Console.WriteLine($"Data do Cadastro : {marcas.DataCadastro}");

            ListaDeMarcas.Add(marcas);

            Console.WriteLine($"Produto Adicionado na Lista !");


        }

        public void Listar()
        {
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
        }

        public void Deletar(int codigo2){

        }



    }
}