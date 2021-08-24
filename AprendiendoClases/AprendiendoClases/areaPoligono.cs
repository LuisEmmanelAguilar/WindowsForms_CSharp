using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AprendiendoClases
{
    public class areaPoligono
    {
        // ATRIBUTOS
        string tipoPoligono;
        double lado;
        double Base;
        double altura;
        public double resultado;

        //CONSTRUCTOR. Nunca regresa el tipo de dato
        public areaPoligono(string TipoPoligono, double lado,double Base, double altura) 
        {
            //TipoPoligono viene del exterior, sirve para darle valor
            //al Atributo tipoPoligono

            this.tipoPoligono = TipoPoligono;
            this.lado = lado;
            this.Base = Base;
            this.altura = altura;
            // this es un operador para referirse a Atributos o Metodos 
            // de una clase y es opcional.
            // Es buena practica ponerlo para hacerlo legible
            // Nos referimos al atributo o metodo de la clase

            if (this.tipoPoligono == "Cuadrado")
            {
                this.areaCuadrado();
            }
            else areaTriangulo();
        }

    //METODOS
        public double areaTriangulo()
        {
            
            this.resultado = this.Base * this.altura / 2;
            return resultado;
        }


        public double areaCuadrado()
        {
            this.resultado = this.lado * this.lado;
            return resultado;
        }



    }
}
