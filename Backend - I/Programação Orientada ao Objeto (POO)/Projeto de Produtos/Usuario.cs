

namespace Projeto_de_Produtos
{
    public class Usuario
    {
        public int? Codigo { get; set; }
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
        public List<Usuario> ListaDeUsuarios = new List<Usuario>();



        public void Cadastrar()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;

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
            Código User : {usuarios.Codigo}
            Nome : {usuarios.Nome}
            Email : {usuarios.Email}
            Senha : {usuarios.Senha}
            ");

            ListaDeUsuarios.Add(usuarios);
            Console.ResetColor();
        }

        public void Listar()
        {
            foreach (var item in ListaDeUsuarios)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(@$"
                === Usuário Cadastrado ==

                Código do Usuário : {item.Codigo}
                Nome do Usuário : {item.Nome}
                Email do Usuário : {item.Email}
                Senha do Usuário : {item.Senha}
                ");
                Console.ResetColor();

            }
        }



        public void Deletar(int codigo3)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Informe o Código da marca que deseja Remover :");
            codigo3 = int.Parse(Console.ReadLine()!);


            Usuario usuarioBuscado = ListaDeUsuarios.Find(x => x.Codigo == codigo3)!;
            ListaDeUsuarios.Remove(usuarioBuscado);
            Console.ResetColor();
        }

    }
}