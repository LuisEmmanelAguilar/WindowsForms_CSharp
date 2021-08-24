using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AprendiendoClases
{
    public partial class Form1 : Form
    {
        double lado;
        double Base;
        double altura;
        public double resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string figura="";

            switch (cmbTipoFigura.Text)
            {
                case "Cuadrado":
                    figura = cmbTipoFigura.Text;
                    lado = double.Parse(txtDato1.Text);
                    Base = 0;
                    altura = 0;
                    break;

                case "Triangulo":
                    figura = cmbTipoFigura.Text;
                    Base = double.Parse(txtDato1.Text);
                    altura = double.Parse(txtDato2.Text);
                    break;
            }

            areaPoligono misPoligonos = new areaPoligono(figura, lado, Base, altura);


            txtResultado.Text = misPoligonos.resultado.ToString();


        }

    }
}
