using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneraPassword
{
    public class password
    {

        //-----------------------ATRIBUTOS-----------------------------------
        public int longitud;
        public string contrasena;

        
        //------------------------CONSTRUCTORES-----------------------------
        // CONSTRUCTOR POR DEFECTO
        public password()
        {   
            this.longitud=8;
            this.contrasena = "";
            this.generarPassword();
        }

        //CONSTRUCTOR LONGITUD USUARIO
        public password (int longitud)
        {
            
            this.longitud = longitud;
            this.contrasena = "";
            this.generarPassword();
        }


        //-----------------------------METODOS-----------------------------------
        public void generarPassword()
        {
            // INVOCA LOS 3 METODOS (MAYUSCULAS, MINUSCULAS, NUMEROS)
            //letras mayusculas - se invoca para que sean 2 letras mayusculas
            for (int contador=1; contador <=2; contador++)
            {
                this.contrasena = this.contrasena + this.letraMayuscula();
            }

            //letras minuculas se invoca solo para una letra
            this.contrasena = this.contrasena + this.letraMinuscula();

            //numeros
            int numVeces = this.longitud - 3;
            for (int contador = 1; contador <= numVeces; contador++) 
            {
                this.contrasena = this.contrasena + (this.numero()).ToString();
            }

        }


        //METODO PARA OBTENER UNA MAYUSCULA MEDIANTE ASCCI
        private string letraMayuscula()
        {
            Random codigo = new Random();// genera numero aleatoria
            int codigoAscII = codigo.Next(65,90); // limito el rango del aleatorio
            string letra = "";
            //Recibe un codigo ASCII y lo convierte en letra
            var a = Char.ConvertFromUtf32(codigoAscII); // AscII para generar en mayuscula
            letra = a;
            return letra;
        }


        //METODO PARA OBTENER UNA MINUSCULA MEDIANTE ASCCI
        private string letraMinuscula()
        {
            Random codigo = new Random();
            int codigoAscII = codigo.Next(97, 122);
            string letra = "";
            var b = Char.ConvertFromUtf32(codigoAscII);
            letra = b;
            return letra;
        }

        //METODO PARA NUMEROS ALEATORIOS
        private int numero()
        {
            int numero;
            Random codigo = new Random();
            numero = codigo.Next(0,9);
            return numero;
        }




        // METODO VERIFICAR SI ES FUERTE
        public Boolean esFuerte()
        {
            Boolean resultado=false;

            //---------Encontrar letras Mayusculas---------------
            int vecesMayusculas = 0;
            int vecesMinusculas = 0;
            int vecesNumeros = 0;
            string letra = "";

            // Aqui hace un barrido a la contraseña
            // Y va detectando con cuales son mayusculas
            for (int contador = 0; contador <= this.contrasena.Length-1; contador++)
            {
                // hace el barrido
                letra = contrasena.Substring(contador, 1);
                // Si la letra la pasa a Upper y es igual, incrementa
                // de lo contrario no incrementa
                if (letra==letra.ToUpper()) vecesMayusculas++; 
            }


            //---------Encontrar letras Minusculas---------------
            for (int contador = 0; contador <= this.contrasena.Length-1; contador++)
            {
                letra = contrasena.Substring(contador, 1);
                // Si la letra la pasa a Lower y es igual, incrementa
                // de lo contrario no incrementa
                if (letra == letra.ToLower()) vecesMinusculas++;
            }

            //ENCONTRAR NUMEROS
            for (int contador = 0; contador <= this.contrasena.Length-1; contador++)
            {
                int n;
                letra = contrasena.Substring(contador, 1);
                if (int.TryParse(letra, out n)== true) vecesNumeros++;
            }


            if (vecesMayusculas >= 2 && vecesMinusculas >= 1 && vecesNumeros >= 5)
            {
                resultado = true;
            }

            return resultado;
        }


    }


}