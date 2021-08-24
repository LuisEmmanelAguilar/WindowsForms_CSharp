using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PedidoCompras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboCantidad.Items.Add(1);
            cboCantidad.Items.Add(2);
            cboCantidad.Items.Add(3);
            cboCantidad.Items.Add(4);
            cboCantidad.Items.Add(5);
            cboCantidad.Items.Add(6);
            cboCantidad.Items.Add(7);
            cboCantidad.Items.Add(8);
            cboCantidad.Items.Add(9);

            cboProducto.Items.Add("Sustratro Agricola");
            cboProducto.Items.Add("Filtro Ayuda");
            cboProducto.Items.Add("Carga para Construccion");

        }

        private void btnGenerarPedido_Click(object sender, EventArgs e)
        {
            //LEER VALORES DEL FORMULARIO
            string serie = txtSerie.Text;
            string numero = txtPedido.Text;
            string cliente = txtCliente.Text;
            string fecha = dtPicker.Value.ToString();
            string producto = cboProducto.Text;
            int cantidad = int.Parse(cboCantidad.Text);
            float precio = float.Parse(txtPrecio.Text);

            //INSTANCIAR LA CLASE
            pedido nuevoPedido = new pedido(cliente, serie, numero, fecha);
            pedido nuevoPedidoDetalle = new pedido(producto, precio, cantidad);

            string datosPedido;
            string datosPedidoDetalle;
            datosPedido = nuevoPedido.cadenaPedido();
            datosPedidoDetalle = nuevoPedidoDetalle.cadenaPedido();

            MessageBox.Show(datosPedido);
            MessageBox.Show(datosPedidoDetalle);

        }
    }
}
