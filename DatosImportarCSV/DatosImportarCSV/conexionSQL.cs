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
            this.cadenaConexion = "Data Source=LEAZLAPTOP-PC\\SQLEXPRESS;" +
                                  "Initial Catalog=Empleados;" +
                                  "Integrated Security=true";
            this.conexion = new SqlConnection(this.cadenaConexion);
        }


        public DataTable ObtenerDatos(string consulta)
        {
            DataTable resultados= new DataTable();
            this.conexion.Open();
            SqlCommand comando = new SqlCommand(consulta, this.conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            adaptador.Fill(resultados);
            return resultados;
        }


        public int EjecutarSQL(string consulta)
        {
            int resultados = 0;
            this.conexion.Open();
            SqlCommand comando = new SqlCommand(consulta, this.conexion);
            resultados = comando.ExecuteNonQuery();
            return resultados;
        }

    
    }
}
