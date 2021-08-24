using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcuacionSegundoGrado
{
    public partial class Form1 : Form
    {
        public int A, B, C;
        public double raizPositiva, raizNegativa;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            A = int.Parse(txtValorA.Text);
            B = int.Parse(txtValorB.Text);
            C = int.Parse(txtValorC.Text);


            if(A == 0)
            {
                raizNegativa=-B / C;
                raizPositiva=-B / C;

            }
            else if ((B * B) -  4 * A * C < 0) 
            {

                MessageBox.Show("Las soluciones son imaginarias");

            }
            else
            {
                raizNegativa = (-B + (Math.Sqrt(B * B - 4 * A * C)) / 2 * A);
                raizPositiva = (-B - (Math.Sqrt(B * B - 4 * A * C)) / 2 * A);

                MessageBox.Show("Raiz Negativa es : " + raizNegativa);
                MessageBox.Show("Raiz Positiva es : " + raizPositiva);

            }
        }
    }
}
