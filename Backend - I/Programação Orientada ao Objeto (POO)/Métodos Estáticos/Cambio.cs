using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Métodos_Estáticos
{
    public class Cambio
    {

        // propriedade estática
        public static float valor { get; set; }



        public static float RealToDolar (float real){

        valor = real;
        float Dolar = valor / 4.99f;
        return Dolar;
        
        }

        public static float DolarToReal (float dolar){

        valor = dolar;
        float Real = valor * 4.99f;
        return Real;
        
        }

    }
}