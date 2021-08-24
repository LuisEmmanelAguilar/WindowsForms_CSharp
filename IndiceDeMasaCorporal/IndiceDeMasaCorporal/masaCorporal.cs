using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndiceDeMasaCorporal
{
    class masaCorporal
    {
        // ------------------------------ ATRIBUTOS --------------------------------------
        // Todos los atributos son de tipo Private cuando se omite su Modificador de Acceso
        string nombre;
        int edad;
        string sexo;
        float peso;
        float altura;
        double DNI;

        //Atributo adicional para devolver el IMC
        float imc;

        // -------------------------- CONSTRUCTORES-----------------------------------------
        //CONSTRUCTOR POR DEFECTO - SIN PARAMETROS
        public masaCorporal()
        {
            this.nombre = "";
            this.edad = 0;
            this.sexo = "H";
            this.peso = 0;
            this.altura = 0;
        }

        // CONSTRUCTOR CON NOMBRE, EDAD Y SEXO COMO PARAMETROS
        // EL RESTO DE ATRIBUTOS POR DEFECTO
        public masaCorporal(string nombre, int edad, string sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.peso = 0;
            this.altura = 0;
        }

        //CONSTRUCTOR CON TODOS LOS ATRIBUTOS COMO PARAMETRO
        public masaCorporal(string nombre, int edad, string sexo, float peso, float altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }


        //---------------------------- METODOS ------------------------------------- 
        // METODO PARA CALCULAR IMC
        public int calcularIMC() 
        {
            int resultado=1;

            this.imc = this.peso / (this.altura * this.altura);

            if (this.imc < 20) resultado = -1;
            if (this.imc >= 20 || imc <= 25) resultado = 0;
            return resultado;
        }


        //METODO ES MAYOR DE EDAD
        public Boolean esMayorEdad()
        {
            Boolean resultado = true;
            if (this.edad < 18) resultado = false;
            // else resultado = true;
            return resultado;
        }

        //METODO COMPROBAR SEXO
        private string comprobarSexo()
        {
            //Se coloca el valor predeterminado
            string resultado = "H";
            //if (this.sexo == "H") resultado = this.sexo;
            if (this.sexo == "M") resultado = this.sexo;

            return resultado;
        }

        // METODO "toSring"
        // PARA DEVOLVER TODA LA INFO DE LA PERSONA
        public string toString()
        {
            string resultado;

            this.generaDNI(); // INVOCA METODO GENERADOR DE DNI
            this.comprobarSexo(); // INVOCA METODO PARA COMPROBAR SEXO
            Boolean mayorEdad = this.esMayorEdad(); // INVOCA METODO PARA VERIFICAR EDAD
            int resultadoIMC = this.calcularIMC();

            resultado = "Hola " + this.nombre + " tu edad es " + this.edad +
                        ", Sexo : " + this.sexo + " Altura : " + this.altura +
                        ", Tu Indice de Masa Corporal es : " + (this.imc).ToString() +
                        ", DNI : " + this.DNI;

            if (mayorEdad == true) resultado = resultado + ", Eres Mayor de Edad";
            else resultado = resultado + " Eres Menor de Edad";
            if (resultadoIMC == -1) resultado = resultado + " Estas bajo de peso";
            if (resultadoIMC == 0) resultado = resultado + " Estas en tu peso ideal";
            if (resultadoIMC == 1) resultado = resultado + " Tienes sobrepeso";

            return resultado;
        }


        // METODO DNI
        private void generaDNI()
        {
            Random na = new Random();
            this.DNI = na.Next(10000000, 99999999);
        }




    }


}
