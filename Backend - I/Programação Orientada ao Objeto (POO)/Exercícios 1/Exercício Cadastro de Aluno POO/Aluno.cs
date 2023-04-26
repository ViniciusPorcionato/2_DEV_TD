using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercício_Cadastro_de_Aluno_POO
{
    public class Aluno
    {
        // Atributos
        public string Nome;
        public int Idade;
        public string RG;
        public string NomeCurso;

        public bool Bolsista;
        public float MediaFinal;
        public float ValorMensalidade;

        public float VerMedia()
        {
            return MediaFinal;
        }


        // IF ENCADEADO
        public float VerMensalidade(){
            if (this.Bolsista == true && this.MediaFinal >= 8)
            {
                this.ValorMensalidade -= (float)(this.ValorMensalidade * 0.50);
            }
            else if(this.Bolsista == true &&  this.MediaFinal > 6)
            {
                this.ValorMensalidade -= (float)(this.ValorMensalidade * 0.30);
            }
            else if(this.Bolsista == true &&  this.MediaFinal <= 5 )
            {                
            }
            else if (this.Bolsista == false)
            {                
            }

            return ValorMensalidade;
        }


    }
}