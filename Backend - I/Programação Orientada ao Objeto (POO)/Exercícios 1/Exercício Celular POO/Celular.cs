using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercício_Celular_POO
{
    public class Celular
    {
        // atributos / propriedades
        public string? Cor;
        public string? Modelo;
        public string? Tamanho;
        public bool Ligado = false;

        // métodos
        public void Ligar(){
        this.Ligado = true;
        }

        public void Desligar(){
        Console.WriteLine($"Celular Desligando ! Pressione <ENTER>");
        Console.ReadLine();
        this.Ligado = false;
        
        }

        public void FazerLigacao(){
        Console.WriteLine($"Insira o Número de telefone :");
        int NumeroTelefone = int.Parse(Console.ReadLine()!);
        Console.WriteLine($"Ligando...");
        }

        public void EnviarMensagem(){
            Console.WriteLine($"Digite a Mensagem :");
            string mensagem = Console.ReadLine()!;
            Console.WriteLine($"Mensagem Enviada !");            
            
        }



    }
}