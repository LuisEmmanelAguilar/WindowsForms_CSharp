using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividad
{
    class Fibonacci
    {
        public int calcular(int numero)
        {
            int resultado;

            if(numero == 0)
            {
                return 0;
            }
            else
            {
                if (numero == 1)
                {
                    return 1;
                }
                else
                {
                    resultado = calcular(numero - 1) + calcular(numero - 2);

                    return (resultado);
                }
            }

        }
    }
}
