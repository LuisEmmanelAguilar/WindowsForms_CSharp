using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace LeerXML
{
    class clsFacturasMovimientosProveedores
    {

        string uuid;
        string rfcEmisor;
        string fecha;
        string claveProdServ;
        string noIdentificacion;
        string cantidad;
        string claveUnidad;
        string descripcion;
        string valorUnitario;
        string importe;

        string baseImporte;
        string impuesto;
        string tipoFactor;
        string tasaOCuota;
        string importeTras;

        string status;

        string fechaAlta = DateTime.Now.ToString();

        public clsFacturasMovimientosProveedores(string uuid, string rfcEmisor, string fecha, string claveProdServ, 
                                                 string noIdentificacion, string cantidad, string claveUnidad, 
                                                 string descripcion, string valorUnitario, string importe, 
                                                 string baseImporte, string impuesto, string tipoFactor, 
                                                 string tasaOCuota, string importeTras)
        {

            this.uuid = uuid;
            this.rfcEmisor = rfcEmisor;
            this.fecha = fecha;
            this.claveProdServ = claveProdServ;
            this.noIdentificacion = noIdentificacion;
            this.cantidad = cantidad;
            this.claveUnidad = claveUnidad;
            this.descripcion = descripcion;
            this.valorUnitario = valorUnitario;
            this.importe = importe;
            this.baseImporte = baseImporte;
            this.impuesto = impuesto;
            this.tipoFactor = tipoFactor;
            this.tasaOCuota = tasaOCuota;
            this.importeTras = importeTras;
            

        }


        
        /******************* METODOS *******************************/
        public void guardarFactura()
        {

            //clsConexionProveedores conexion = new clsConexionProveedores();

            /*
            string queryGuardar = "INSERT INTO FacturasMovimientosProveedores " +
                                  "(UUID, RFCEmisor, Fecha, ClaveProdServ, NoIdentificacion, Cantidad, " +
                                  "ClaveUnidad, Descripcion, ValorUnitario, Importe, BaseImporte, " +
                                  "Impuesto, TipoFactor, TasaOCuota, ImporteTraslado, Status, FechaAlta) " +
                                  "VALUES ('" + uuid + "', '" + rfcEmisor + "','" + fecha + "' ,'" + claveProdServ + "', " +
                                  "'" + noIdentificacion + "', '" + cantidad + "', '" + claveUnidad + "', " +
                                  "'" + descripcion + "', '" + valorUnitario + "', '" + importe + "', '" + baseImporte + "', " +
                                  "'" + impuesto + "' ,'" + tipoFactor + "','" + tasaOCuota + "', '" + importeTras + "', " +
                                  "'S', '" + fechaAlta+ "')";
            */

            clsConexionSigma conexion = new clsConexionSigma();

            string queryGuardar = "INSERT INTO Remisiones " +
                                  "(NombreCliente) VALUES('"+ uuid +"')";

            int execute = conexion.ejecutarSQL(queryGuardar);

        }



    }
}
