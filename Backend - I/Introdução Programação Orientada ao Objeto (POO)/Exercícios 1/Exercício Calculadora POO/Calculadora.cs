using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercício_Calculadora_POO
{
    public class Calculadora
    {
        //  Atributos
        // N'umero 1 e número 2
       public float num1; 
       public float num2; 

    //    Métodos
    // Multiplicar, dividir, somar e subtrair

    public float Somar(){
    return this.num1 + this.num2;
    }
    public float Subtrair(){
    return this.num1 - this.num2;
    }
    public float Multiplicar(){
    return this.num1 * this.num2;
    }
    public float Dividir(){
    return this.num1 / this.num2;
    }

    }
}