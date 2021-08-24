using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneraPassword
{
    public partial class Form1 : Form
    {
        password miPassword;

        public Form1()
        {
            InitializeComponent();

            if (txtLongitud.Text == "")
            {
                //Instanciar Class Paswword
                miPassword = new password();
            }
            else
            {
                int longitud = int.Parse(txtLongitud.Text);
                miPassword = new password(longitud);
            }

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string contrasena;
            contrasena = miPassword.contrasena;
            MessageBox.Show(contrasena);

        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            Boolean verificarPassword;
            verificarPassword = miPassword.esFuerte();
            if (miPassword.contrasena != "")
            {
                if (verificarPassword == true) MessageBox.Show("La contraseña es Fuerte");
                else MessageBox.Show("La contraseña es Debil");
            }
            else MessageBox.Show ("Debe generar primero un Password");
        }


    }
}