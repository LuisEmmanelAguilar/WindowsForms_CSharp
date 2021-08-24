using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DemoSQLServer
{
    class conexionSQL
    {
        // ATRIBUTOS
        SqlConnection conexion;
        string cadenaConexion;

        //CONSTRUCTOR POR DEFECTO
        public conexionSQL ()
        {
            //*************************Definir cadena de conexion*************************************
            // 1- nobre del servidor al que deseo conectarme Local o Externo (Data Source) // IP Seguida por instancia
            // 2- Nombre de base de datos al que se conectara (Initial Catalog)
            // 3- Usuario (Autenticacion de Windows o Usuario de SQL) (Integrated Security, dos valores, TRUE(Usuario Windwos) o FALSE(SQL Server))
            // 4- Contraseña

                                                        // Colocar otra diagonal invertida
                                                        // ya que sirve de escape
            //Se recomienda tener un archivo externo puede ser TXT o XML Encriptado para
            // que en cualquier eventualidad que cambian el nombre, tabla, ect!
            this.cadenaConexion = "Data Source=LEAZLAPTOP-PC\\SQLEXPRESS;" +
                                  "Initial Catalog=momentum;" +
                                  "Integrated Security=true";

            /*
            // ***************** Autenticacion de SQL Server ***********************************
            this.cadenaConexion = "Data Source=LEAZLAPTOP-PC\\SQLEXPRESS;" +
                                  "Initial Catalog=momentum;" +
                                  "Integrated Security=false;" +
                                  "UID=SA; Password=ejemplocontraseña";
            */

            this.conexion = new SqlConnection(this.cadenaConexion);
        }


        public DataTable ObtenerDatos(string consulta)
        {
            DataTable resultados= new DataTable();

            //Abrir conexion
            this.conexion.Open();

            //Ejecutar Consulta SQL
            SqlCommand comando = new SqlCommand(consulta, this.conexion);

            //Guardar resultado de la consultar en el adaptador
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            //Llenar DataTable
            adaptador.Fill(resultados);

            return resultados;
        }
    }
}
