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
    public partial class Edicion : Form
    {
        public Edicion()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string criterio = txtCriterio.Text;
            conexionSQL bEmpleado = new conexionSQL();
            string consulta = "SELECT * FROM Empleado " +
                              "WHERE EmpleadoNombre LIKE '%"+ txtCriterio.Text +"%' " +
                              "UNION " +
                              "SELECT * FROM Empleado " +
                              "WHERE EmpleadoApPaterno LIKE '%" + txtCriterio.Text + "%' " +
                              "UNION " +
                              "SELECT * FROM Empleado " +
                              "WHERE EmpleadoApMaterno LIKE '%" + txtCriterio.Text + "%' ";

            DataTable resultados;
            //Variable = Objeto.Metodo (Parametro)
            resultados = bEmpleado.ObtenerDatos(consulta);
            dgDatos.DataSource = resultados;

        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            conexionSQL gEmpleado = new conexionSQL();
            // guardara el resultado de la consulta
            // regresa un numero de registros afectados
            int registros;

            //se posiciona o muestra en que registro estamos
            int registro = dgDatos.SelectedCells[0].RowIndex;
            
            // renglon especifico donde me encuentre tome el valor de la celda
            string id = dgDatos.Rows[registro].Cells[0].Value.ToString();
            string nombre = dgDatos.Rows[registro].Cells[1].Value.ToString();
            string aPaterno = dgDatos.Rows[registro].Cells[2].Value.ToString();
            string aMaterno = dgDatos.Rows[registro].Cells[3].Value.ToString();

            //Query
            string guardarEmpleado = "UPDATE Empleado SET " +
                                     "EmpleadoNombre = '" + nombre + "'," +
                                     "EmpleadoApPaterno = '" + aPaterno + "'," +
                                     "EmpleadoApMaterno = '" + aMaterno + "' " +
                                     "WHERE IdEmpleado = " + id;
            
            // Ejecutar SQL y pasar el string con que hara la consulta
            registros = gEmpleado.EjecutarSQL(guardarEmpleado);
            MessageBox.Show("Se actualizaron" + registros.ToString() + " registros");

        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            DataTable resultados = (DataTable)dgDatos.DataSource;
            exportarExcel info = new exportarExcel(resultados);
        }
    }
}
