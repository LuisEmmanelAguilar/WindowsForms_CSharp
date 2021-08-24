using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidoCompras
{
    class pedido
    {
        //--------------------------- ATRIBUTOS DE LA CLASE ------------------------
        string nombreCliente;
        string serie;
        string numeroPedido;
        string fecha;
        string producto;
        int cantidad;
        float precio;
        float total;
        

        //----------------------------- CONSTRUCTORES ------------------------------
        // PEDIDO CON PARAMETROS DEL PEDIDO
        public pedido(string cliente, string serie, string numero, string fecha)
        {
            this.nombreCliente = cliente;
            this.serie = serie;
            this.numeroPedido = numero;
            this.fecha = fecha;
        }


        //PEDIDO CON PARAMETROS DE LOS PRODUCTOS EN EL PEDIDO
        public pedido(string producto, float precio, int cantidad)
        {
            this.producto = producto;
            this.precio = precio;
            this.cantidad = cantidad;
        }



        //------------------------------- METODOS ---------------------------------
        // METODO PARA CALCULAR TOTALES (PRECIO POR CANTIDAD)
        public float totales()
        {
            float total;
            float subtotal;
            float iva;
            subtotal = this.cantidad * this.precio;
            iva = subtotal * 16 / 100;
            this.total = subtotal + iva;

            return subtotal;
            return iva;
            return total;
        }


        // CADENA PARA MESSAGE BOX DEL PEDIDO
        public string cadenaPedido()
        {
            string datosPedido;

            float iva = this.totales();
            float subtotal = this.totales();
            float total = this.totales();

            datosPedido = "Numero de Pedido: " + this.serie + this.numeroPedido +
                          "  Del Cliente: " + this.nombreCliente +
                          "  Fecha : " + this.fecha + 
                          "  Su Producto: " + this.producto +
                          "  Cantidad: " + this.cantidad +
                          "  Total: " + this.total;

            return datosPedido;
        }


    }


}
