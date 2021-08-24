using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSQLServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerDatos_Click(object sender, EventArgs e)
        {
            conexionSQL miConexion= new conexionSQL();
            DataTable datos = new DataTable();

            // Las consultas deben ir en Procedimientos Almacenados
            // o en archivos separados como un txt o xml
            string Estados = "SELECT * FROM Estados";
            datos = miConexion.ObtenerDatos(Estados);
            dgDatos.DataSource = datos;

        }
    }
}
