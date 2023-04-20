using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Introdução_ao_POO
{
    public class Personagem
    {
         // Atributos
        // Nome, idade, armadura e IA
        public string nome;
        public int idade;
        public string armadura;
        public string ia;

        // Métodos
        // Atacar, defender e restaurar armadura

        public void Atacar() {
            Console.WriteLine($"O personagem atacou!");
        }

        public void Defender() {
            Console.WriteLine($"O personagem defendeu!");
        }

        public void RestaurarArmadura() {
            Console.WriteLine($"Armadura restaurada!");
    }
    }
}