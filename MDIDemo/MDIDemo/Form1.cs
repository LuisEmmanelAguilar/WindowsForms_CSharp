using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIDemo
{
    public partial class Form1 : Form
    {
        // Variables para trabajar con formularios  MDI
        Alta eAlta;
        Edicion eEdicion;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void altaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eAlta = new Alta();
            eAlta.MdiParent = this;
            eAlta.Show();
            //eAlta.WindowState = FormWindowState.Maximized 
            // PARA MAXIMIZAR LA VENTANA

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eEdicion = new Edicion();
            eEdicion.MdiParent = this;
            eEdicion.Show();
        }
    }
}
