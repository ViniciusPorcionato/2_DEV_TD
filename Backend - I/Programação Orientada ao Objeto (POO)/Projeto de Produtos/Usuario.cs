

namespace Projeto_de_Produtos
{
    public class Usuario
    {
        public int? Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        List<Usuario> ListaDeUsuarios = new List<Usuario>();


        public void Cadastrar()
        {
            Usuario usuarios = new Usuario();

            Console.WriteLine($"Informe o Código do Usuário :");
            usuarios.Codigo = int.Parse(Console.ReadLine()!);
            Console.WriteLine($"Informe o Nome de Usuário :");
            usuarios.Nome = Console.ReadLine();
            Console.WriteLine($"Informe o Email de Usuário :");
            usuarios.Email = Console.ReadLine();
            Console.WriteLine($"Informe a Senha :");
            usuarios.Senha = Console.ReadLine();
            Console.WriteLine($"Data do Cadastro : {usuarios.DataCadastro}");
            Console.WriteLine(@$"
            Conta Usuário :
            Código User : {this.Codigo}
            Nome : {this.Nome}
            Email : {this.Email}
            Senha : {this.Senha}
            ");

            ListaDeUsuarios.Add(usuarios);

        }

        public void Deletar()
        {

        }






    }
}