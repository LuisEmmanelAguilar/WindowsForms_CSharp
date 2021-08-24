using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial
{
    public partial class Form1 : Form
    {
        public double factorial = 1;
        public string numero;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            numero = txtNumero.Text;

            for (int contador = 1; contador <= int.Parse(numero); contador++) 
            {
                factorial = factorial * contador;
            }

            MessageBox.Show("El factorial es " + factorial);

            factorial = 1;
        }
    }
}
