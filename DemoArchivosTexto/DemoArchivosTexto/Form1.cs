using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DemoArchivosTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                string datos;
                archivoTexto miArchivo = new archivoTexto();
                datos = miArchivo.leerArchivo("c:\\Pruebas\\pruebas.txt");
                txtContenido.Text = datos;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }


        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string contenido="";
            archivoTexto miArchivo = new archivoTexto();
            contenido = txtContenido.Text;
            miArchivo.escribirArchivo("c:\\Pruebas\\prueba2.txt", contenido);

        }
    }
}
