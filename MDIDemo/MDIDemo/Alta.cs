using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoSQLServer;

namespace MDIDemo
{
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conexionSQL aEmpleado = new conexionSQL();
            //Sirve para guardar el resultado del metodo que viene en la clase  conexionslq
            //metodo es EjecutarSQL
            int rConsulta = 0;
            string nombre = txtNombre.Text;
            string aPaterno = txtApPaterno.Text;
            string aMaterno = txtApMaterno.Text;

            //INVOCAR METODO validarDatos para verificar que hay datos en los txt
            Boolean resultado;
            resultado = this.validarDatos(nombre, aPaterno, aMaterno);
            if (resultado)
            {
                string agregarEmpleado = "INSERT INTO Empleado " +
                                         "(EmpleadoNombre, EmpleadoApPaterno, EmpleadoApMaterno) " +
                                         "VALUES ('" + nombre + "', '" + aPaterno + "','" + aMaterno + "')";
                rConsulta = aEmpleado.EjecutarSQL(agregarEmpleado);

            }
            else MessageBox.Show("Datos Incorrectos, Verifique");
        }



        private Boolean validarDatos(string nombre, string aPaterno, string aMaterno) 
        {
            Boolean resultado = true;
            if (nombre == "") resultado = false;
            if (aPaterno == "") resultado = false;
            if (aMaterno == "") resultado = false;
            return resultado;

        }
    }
}
