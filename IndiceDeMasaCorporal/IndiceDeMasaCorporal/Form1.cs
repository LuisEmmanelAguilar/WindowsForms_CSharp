using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndiceDeMasaCorporal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            // LEER VALORES DEL FORMULARIO
            string nombre = txtNombre.Text;
            int edad = int.Parse(txtEdad.Text);
            string sexo = txtSexo.Text;
            float peso = float.Parse(txtPeso.Text) ;
            float altura = float.Parse(txtAltura.Text);


            //INSTANCIACION DE LA CLASE (CONSTRUCCION DEL OBJETO)
            masaCorporal nuevaPersona = new masaCorporal(nombre, edad, sexo, peso, altura);

            string datos;
            datos = nuevaPersona.toString();

            MessageBox.Show(datos);


        }



    }
}
