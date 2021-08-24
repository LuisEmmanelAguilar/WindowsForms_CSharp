using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recursividad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Factorial fac = new Factorial();
            int numero = Convert.ToInt32(textBox1.Text);
            int resultado = fac.calcular(numero);
            textBox2.Text = Convert.ToString(resultado).ToString();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Fibonacci fibo = new Fibonacci();
            int numero = Convert.ToInt32(textBox1.Text);
            int resultado = fibo.calcular(numero);
            textBox2.Text = Convert.ToString(resultado).ToString();

        }


    }
}
