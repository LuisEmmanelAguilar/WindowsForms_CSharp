using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bienvenidos
{
    public partial class Form1 : Form
    {
        public string nombre;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            nombre = txtNombre.Text;
            MessageBox.Show("Hola " + nombre);

        }
    }
}
