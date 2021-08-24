using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DemoArchivosTexto
{
    public class archivoTexto
    {
        //CONSTRUCTOR
        public archivoTexto() 
        {
          //  this.leerArchivo(ruta);
        }

        // METODO ************************USO DE LA CLASE "STREAMREADER" **************************
        public string leerArchivo (string ruta)
        {
            string resultado = "";
            StreamReader archivo = new StreamReader(ruta, System.Text.ASCIIEncoding.UTF7);
            string datos="";

            while (datos != null)
            {
                datos = archivo.ReadLine();
                resultado = resultado + datos;
            }
            archivo.Close();
            
            
            return resultado;
        
        }


        // METODO ************************USO DE LA CLASE "STREAMWRITTER" **************************
        public void escribirArchivo(string ruta, string contenido) 
        {
            StreamWriter archivo = new StreamWriter(ruta, true);
            archivo.WriteLine(contenido);
            archivo.Close();

        }
    }
}
