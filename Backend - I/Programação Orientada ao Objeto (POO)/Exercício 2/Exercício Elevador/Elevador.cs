using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            Console.WriteLine($"Quantas Pessoas estão dentro do elevador ?");
            Console.WriteLine($"{ this.PessoasElevador}");
            Console.WriteLine($"Saindo do elevador.....");

            this.PessoasElevador--;
            Console.WriteLine($"Total de pessoas :{this.PessoasElevador}");

        }

    }

}
