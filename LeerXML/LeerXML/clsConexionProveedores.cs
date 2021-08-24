﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace LeerXML
{
    class clsConexionProveedores
    {

        OleDbConnection conexion;
        string cadenaConexion;

        public clsConexionProveedores()
        {

            this.cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=L:\Debug\Pruebas.mdb";
            this.conexion = new OleDbConnection(this.cadenaConexion);

        }





        public DataTable obtenerDatos(string consulta)
        {

            DataTable resultados = new DataTable();
            OleDbCommand cmd = new OleDbCommand(consulta, this.conexion);
            OleDbDataAdapter adaptador = new OleDbDataAdapter(cmd);
            adaptador.Fill(resultados);
            return resultados;

        }





        public int ejecutarSQL(string consulta)
        {

            int resultados = 0;
            this.conexion.Open();
            OleDbCommand cmd = new OleDbCommand(consulta, this.conexion);
            resultados = cmd.ExecuteNonQuery();
            this.conexion.Close();
            return resultados;

        }

    }
}
