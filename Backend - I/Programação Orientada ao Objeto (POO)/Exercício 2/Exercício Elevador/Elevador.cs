
namespace Exercício_Elevador
{
    public class Elevador
    {
        public int AndarAtual { get; set; } = 0;
        public int TotalAndares { get; set; }
        public int CapacidadeElevador { get; set; }
        public int PessoasElevador { get; set; }


        public void Inicializar()
        {

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"== INICIALIZAR ELEVADOR ==");
            Console.WriteLine($"Press <ENTER> para continuar...");
            Console.ReadLine();
            Console.Clear();
            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"Cadastre as informações seguintes :");

            do
            {
                Console.WriteLine($"Total de Andares do edifício");
                TotalAndares = int.Parse(Console.ReadLine()!);

                if (TotalAndares < 0)
                {
                    Console.WriteLine($"Opção Inválida, informe novamente !");

                }
            } while (TotalAndares < 0);


            Console.WriteLine($"Capacidade de Pessoas do Elevador");
            CapacidadeElevador = int.Parse(Console.ReadLine()!);


            Console.ResetColor();


            Console.WriteLine(@$"
    Capacidade do Elevador : {this.CapacidadeElevador}
    Total Andares : {this.TotalAndares}
        ");
        }

        public void Entrar()
        {

            Console.WriteLine($"Quantas Pessoas estão dentro do elevador ?");
            this.PessoasElevador = int.Parse(Console.ReadLine()!);

            Opcao:
            Console.WriteLine($"Deseja entrar no elevador s(sim) / n(não) ?");
            char opcao = char.Parse(Console.ReadLine()!);

            switch (opcao)
            {
                case 's':
                    if (this.PessoasElevador < this.CapacidadeElevador)
                    {
                        this.PessoasElevador++;
                        Console.WriteLine($"Total de pessoas :{this.PessoasElevador}");
                    }
                    else
                    {
                        Console.WriteLine($"Elevador Cheio !");
                    }
                    break;
                case 'n':
                    break;
                default:
                    Console.WriteLine($"Opção Inválida ! Informe Novamente !");
                    goto Opcao;
            }


        }

        public void Sair()
        {
            Console.WriteLine($"Pessoas que estão dentro do elevador");
            Console.WriteLine($"{ this.PessoasElevador}");
            Console.WriteLine($"Saindo do elevador.....");

            this.PessoasElevador--;
            Console.WriteLine($"Total de pessoas :{this.PessoasElevador}");

        }

        public void Subir(){
            
        }
        public void Descer(){
            Console.WriteLine($"== Descer Elevador ==");
            Console.WriteLine($"Para qual deseja ir ?");
            for (int i = AndarAtual; i >= 0; i--)
            {
                if (i < this.AndarAtual && i == 0)
                {
                    Console.WriteLine($"[{i}] Térreo");
                }
                else if(i < this.AndarAtual)
                {
                    Console.WriteLine($"[{i}] {i}º Andar");  
                }            
            }  

            Console.WriteLine($"Digite a opção que deseja ir ?");
            int Andar = int.Parse(Console.ReadLine()!); 
        }

    }

}
