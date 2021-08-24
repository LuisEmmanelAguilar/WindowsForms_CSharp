using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public string numeroUno;
        public string numeroDos;
        public string operacion;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtResultado.Text  = txtResultado.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtResultado.Text = txtResultado.Text + ".";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            numeroUno = txtResultado.Text;
            txtResultado.Text = "";
            operacion = "Suma";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            numeroUno = txtResultado.Text;
            txtResultado.Text = "";
            operacion = "Resta";
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            numeroUno = txtResultado.Text;
            txtResultado.Text = "";
            operacion = "Multiplicacion";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            numeroUno = txtResultado.Text;
            txtResultado.Text = "";
            operacion = "Division";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            numeroDos = txtResultado.Text;
            switch (operacion) { 
            
                case "Suma":
                    txtResultado.Text = (Double.Parse(numeroUno) + Double.Parse(numeroDos)).ToString() ;
                    break;
                case "Resta":
                    txtResultado.Text = (Double.Parse(numeroUno) - Double.Parse(numeroDos)).ToString() ;
                    break;
                case "Multiplicacion":
                    txtResultado.Text = (Double.Parse(numeroUno) * Double.Parse(numeroDos)).ToString();
                    break;
                case "Division":
                    txtResultado.Text = (Double.Parse(numeroUno) / Double.Parse(numeroDos)).ToString();
                    break;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }



        
    }
}
