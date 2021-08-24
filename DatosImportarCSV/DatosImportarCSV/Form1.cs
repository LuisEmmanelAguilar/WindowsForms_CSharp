using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoSQLServer;
using DemoArchivosTexto;

namespace DatosImportarCSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            archivoTexto contenido = new archivoTexto();   
            string datos;
            datos = contenido.leerArchivo("c:\\Pruebas\\pruebaCSV.csv");
            txtInfo.Text = datos;
            var informacion = datos.Split(',');
            conexionSQL importar = new conexionSQL();

            string consulta = "";
            string valores = "";
            int contador = 1;
            
            foreach (string campo in informacion) 
            {
                valores = valores + "'" + campo + "',";

                if (contador<=6)
                {
                    consulta = "INSERT INTO Info_Paso (campo1, campo2, campo3, campo4, campo5, campo6, campo7)  " +
                              "VALUES (" + valores;
                }
                else
                {
                    consulta = consulta.Substring(0,consulta.Length - 2) + ");";
                    importar.EjecutarSQL(consulta);
                    contador = 1;
                    valores = "";
                }
            }

            MessageBox.Show("Datos Importados");
            
        }
    }
}
