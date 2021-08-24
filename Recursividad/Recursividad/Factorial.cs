using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad
{
    class Factorial
    {
        /*
        public factorial()
        {
        }
        */
        public int calcular(int numero)
        {
            int resultado;
            
            if (numero == 0)
                return 1;
            else
                resultado = numero * calcular(numero - 1);

            return (resultado);
        }

    }
}
