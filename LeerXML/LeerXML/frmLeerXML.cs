using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;


namespace LeerXML
{
    public partial class frmLeerXML : Form
    {



        public frmLeerXML()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }



        private void button1_Click(object sender, EventArgs e)
        {

            string rutaDirectorio = string.Empty;
            FolderBrowserDialog browserDirectorio = new FolderBrowserDialog();

            if (browserDirectorio.ShowDialog() == DialogResult.OK)
            {
                rutaDirectorio = browserDirectorio.SelectedPath;
            }

            txtRutaDirectorio.Text = rutaDirectorio + "\\";
            LBArchivos.Items.Clear();

            /***** AÑADE EL PATH AL LIST BOX *****/
            //LBArchivos.Items.Add(rutaDirectorio);


            if(rutaDirectorio.Trim() != string.Empty)
            {
                DirectoryInfo directorio = new DirectoryInfo(@rutaDirectorio);

                foreach (var archivo in directorio.GetFiles("*xml*"))
                {
                    LBArchivos.Items.Add(archivo.Name);
                }

            }


        }




        /// <summary>
        /// BOTON PARA LEER EL XML QUE SE INDICA
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeerXML_Click(object sender, EventArgs e)
        {
            
            string ruta = txtRutaDirectorio.Text;
            DirectoryInfo directorio = new DirectoryInfo(@ruta);


            //string archivoName = this.LBArchivos.SelectedItem.ToString();
            //string rutaCompleta = @ruta + archivoName;

            string rutaCompleta;

            foreach(string archivo in LBArchivos.Items)
            {

                //archivoName = this.LBArchivos.SelectedItem.ToString();
                rutaCompleta = @ruta + archivo;

                leeXML(rutaCompleta);

                MessageBox.Show("ARCHIVO : " + rutaCompleta);

            }

            //MessageBox.Show("Archivo elegido: " + rutaCompleta, "Archivo Elegido");
    
        }



        private void leeXML(string archivo)
        {
            /**************AQUI CARGA EL XML ******************/
            XmlDocument xmlArchivo = new XmlDocument();
            xmlArchivo.Load(archivo);

            /// El NameSpaceManager es para especificar el ESPACIO DE NOMBRES
            /// de lo contrario no seleccionaria ningun nodo
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(xmlArchivo.NameTable);
            nsmgr.AddNamespace("cfdi", "http://www.sat.gob.mx/cfd/3");

            XmlNamespaceManager nsTfd = new XmlNamespaceManager(xmlArchivo.NameTable);
            nsTfd.AddNamespace("tfd", "http://www.sat.gob.mx/cfd/3");

            /// AQUI COMIENZA LA LECTURA DEL CFDI
            /// ESTE LECTURA ESTA BASADA EN LA ESTRUCTURA VERSION CFDI V 2
            /// SE INICIO LA PROGRAMACION EL 4 DE AGOSTO DEL 2017


            /************* ABRE EL XML Y LEE EL NODO DEL COMPROBANTE *****************/
            XmlNode xmlComprobante = xmlArchivo.DocumentElement;

            /************* XML ELEMENT DEL COMPROBANTE ********************/
            XmlElement eXmlComprobante = (XmlElement)xmlComprobante;
            XmlAttribute attrSello = eXmlComprobante.GetAttributeNode("Sello");
            XmlAttribute attrCertificado = eXmlComprobante.GetAttributeNode("Certificado");
            XmlAttribute attrNoCertificado = eXmlComprobante.GetAttributeNode("NoCertificado");
            XmlAttribute attrTipoDeComprobante = eXmlComprobante.GetAttributeNode("TipoDeComprobante");
            XmlAttribute attrTotal = eXmlComprobante.GetAttributeNode("Total");
            //XmlAttribute attrDescuento = eXmlComprobante.GetAttributeNode("Descuento");
            XmlAttribute attrSubtotal = eXmlComprobante.GetAttributeNode("SubTotal");
            XmlAttribute attrFormaDePago = eXmlComprobante.GetAttributeNode("FormaPago");
            XmlAttribute attrFecha = eXmlComprobante.GetAttributeNode("Fecha");
            XmlAttribute attrFolio = eXmlComprobante.GetAttributeNode("Folio");
            //XmlAttribute attrNumCtaPago = eXmlComprobante.GetAttributeNode("NumCtaPago");
            XmlAttribute attrLugarExp = eXmlComprobante.GetAttributeNode("LugarExpedicion");
            XmlAttribute attrMetodoPago = eXmlComprobante.GetAttributeNode("MetodoPago");
            XmlAttribute attrSerie = eXmlComprobante.GetAttributeNode("Serie");
            XmlAttribute attrVersion = eXmlComprobante.GetAttributeNode("Version");
            XmlAttribute attrSchemaLoc = eXmlComprobante.GetAttributeNode("xsi:schemaLocation");



            /******************** COMPLEMENTOS ******************************************************/
            XmlNodeList xmlComplementos = xmlArchivo.SelectNodes("/cfdi:Comprobante/cfdi:Complemento", nsmgr);
            //XmlNode xmlComplementos = xmlArchivo.DocumentElement.LastChild;
            XmlNode xmlTimbreFiscalDigital = xmlComplementos.Item(0).LastChild;

            XmlAttribute attrTFDVersion = xmlTimbreFiscalDigital.Attributes["Version"];
            XmlAttribute attrTFDUUID = xmlTimbreFiscalDigital.Attributes["UUID"];
            XmlAttribute attrTFDRfcProvCertif = xmlTimbreFiscalDigital.Attributes["RfcProvCertif"];
            XmlAttribute attrTFDFechaTimbrado = xmlTimbreFiscalDigital.Attributes["FechaTimbrado"];
            XmlAttribute attrTFDSelloCFD = xmlTimbreFiscalDigital.Attributes["SelloCFD"];
            XmlAttribute attrTFDSelloSat = xmlTimbreFiscalDigital.Attributes["SelloSAT"];
            XmlAttribute attrTFDNoCertificadoSAT = xmlTimbreFiscalDigital.Attributes["NoCertificadoSAT"];


            /******************** EMISOR ***************************/
            XmlNodeList xmlEmisor = xmlArchivo.SelectNodes("/cfdi:Comprobante/cfdi:Emisor", nsmgr);
            XmlNode xmlNodeEmisor = xmlEmisor.Item(0);

            XmlAttribute attrEmisorNombre = xmlNodeEmisor.Attributes["Nombre"];
            XmlAttribute attrEmisorRFC = xmlNodeEmisor.Attributes["Rfc"];
            XmlAttribute attrEmisorRegimenFiscal = xmlNodeEmisor.Attributes["RegimenFiscal"];


            /****************************** RECEPCTOR **********************************/
            XmlNodeList xmlReceptor = xmlArchivo.SelectNodes("/cfdi:Comprobante/cfdi:Receptor", nsmgr);
            XmlNode xmlNodeReceptor = xmlReceptor.Item(0);

            XmlAttribute attrReceptorNombre = xmlNodeReceptor.Attributes["Nombre"];
            XmlAttribute attrReceptorRFC = xmlNodeReceptor.Attributes["Rfc"];
            XmlAttribute attrReceptorUsoCFDI = xmlNodeReceptor.Attributes["UsoCFDI"];


            //************* IMPUESTOS TRASLADADOS **********************************************************
            XmlNodeList xmlImpuestos = xmlArchivo.SelectNodes("/cfdi:Comprobante/cfdi:Impuestos", nsmgr);
            //XmlNodeList xmlImpuestosTraslados = xmlArchivo.SelectNodes("/cfdi:Comprobante/cfdi:Impuestos/cfdi:Traslados/cfdi:Traslado", nsmgr);
            XmlNode xmlNodeImpuesto = xmlImpuestos.Item(0);

            XmlAttribute attrImpuestosTrasladados = xmlNodeImpuesto.Attributes["ImpuestosTrasladados"];
            


            //************** COMPROBANTE *************************************
            string sello = attrSello.Value.ToString();
            string certificado = attrCertificado.Value.ToString();
            string noCertificado = attrNoCertificado.Value.ToString();
            string tipoDeComprobante = attrTipoDeComprobante.Value.ToString();
            string total = attrTotal.Value.ToString();
            string subtotal = attrSubtotal.Value.ToString();
            string formaDePago = attrFormaDePago.Value.ToString();
            string fecha = attrFecha.Value.ToString();
            string folio = attrFolio.Value.ToString(); ;
            string lugarExp = attrLugarExp.Value.ToString();
            string metodoPago = attrMetodoPago.Value.ToString();
            string serie = attrSerie.Value.ToString();
            string version = attrVersion.Value.ToString();

            //******************* COMPLEMENTOS ***************************
            string tfdVersion = attrTFDVersion.Value.ToString();
            string tfdUUID = attrTFDUUID.Value.ToString();
            string tfdRFCProveCertif = attrTFDRfcProvCertif.Value.ToString();
            string tfdFechaTimbrado = attrTFDFechaTimbrado.Value.ToString();
            string tfdSelloCFD = attrTFDSelloCFD.Value.ToString();
            string tfdSelloSAT = attrTFDSelloSat.Value.ToString();
            string tfdNoCertificadoSAT = attrTFDNoCertificadoSAT.Value.ToString();

            //************ EMISOR ***************
            string emisorNombre = attrEmisorNombre.Value.ToString();
            string emisorRFC = attrEmisorRFC.Value.ToString();
            string emisorRegimenFiscal = attrEmisorRegimenFiscal.Value.ToString();

            //********** RECEPTOR *****************
            string receptorNombre = attrReceptorNombre.Value.ToString();
            string receptorRFC = attrReceptorRFC.Value.ToString();
            string receptorUsoCFDI = attrReceptorUsoCFDI.Value.ToString();

            //********* IMPUESTOS TRASLADADOS **************
            string impuestosTrasladados;
            if(attrImpuestosTrasladados == null)
            {
                impuestosTrasladados = "0";
            
            }
            else
            {
                impuestosTrasladados = attrImpuestosTrasladados.Value.ToString();
            }



            /******************************* CONCEPTOS ********************************/
            XmlNodeList xmlConceptos = xmlArchivo.SelectNodes("/cfdi:Comprobante/cfdi:Conceptos", nsmgr);
            XmlNodeList xmlConcepto = xmlArchivo.SelectNodes("/cfdi:Comprobante/cfdi:Conceptos/cfdi:Concepto", nsmgr);
            //XmlNodeList xmlImpuestoTraslado = xmlArchivo.SelectNodes("/cfdi:Comprobante/cfdi:Conceptos/cfdi:Concepto/cfdi:Impuestos/cfdi:Traslados/cfdi:Traslado", nsmgr);

            foreach (XmlNode xmlNodeConcepto in xmlConcepto)
            {

                XmlAttribute attrClaveProdServ = xmlNodeConcepto.Attributes["ClaveProdServ"];
                XmlAttribute attrNoIdentificacion = xmlNodeConcepto.Attributes["NoIdentificacion"];
                XmlAttribute attrCantidad = xmlNodeConcepto.Attributes["Cantidad"];
                XmlAttribute attrClaveUnidad = xmlNodeConcepto.Attributes["ClaveUnidad"];
                XmlAttribute attrDescripcion = xmlNodeConcepto.Attributes["Descripcion"];
                XmlAttribute attrValorUnitario = xmlNodeConcepto.Attributes["ValorUnitario"];
                XmlAttribute attrImporte = xmlNodeConcepto.Attributes["Importe"];

                XmlNode xmlImpuestosTraslados = xmlNodeConcepto.LastChild.LastChild.LastChild;

                XmlAttribute attrBase = xmlImpuestosTraslados.Attributes["Base"];
                XmlAttribute attrImpuesto = xmlImpuestosTraslados.Attributes["Impuesto"];
                XmlAttribute attrTipoFactor = xmlImpuestosTraslados.Attributes["TipoFactor"];
                XmlAttribute attrTasaOCuota = xmlImpuestosTraslados.Attributes["TasaOCuota"];
                XmlAttribute attrImporteImpTras = xmlImpuestosTraslados.Attributes["Importe"];

                string claveProdSer = attrClaveProdServ.Value.ToString();
                string noIdentificacion = attrNoCertificado.Value.ToString();
                string cantidad = attrCantidad.Value.ToString();
                string claveUnidad = attrClaveUnidad.Value.ToString();
                string descripcion = attrDescripcion.Value.ToString();
                string valorUnitario = attrValorUnitario.Value.ToString();
                string importe = attrImporte.Value.ToString();

                string baseImporte = attrBase.Value.ToString();
                string impuestoTrasladado = attrImporteImpTras.Value.ToString();
                string tipoFactor = attrTipoFactor.Value.ToString();
                string tasaOCuota = attrTasaOCuota.Value.ToString();
                string impuestoTraslado = attrImporteImpTras.Value.ToString();

                clsFacturasMovimientosProveedores clsMovimientos = new clsFacturasMovimientosProveedores(tfdUUID, emisorRFC, fecha, claveProdSer, noIdentificacion, cantidad, claveUnidad, descripcion, valorUnitario, importe, baseImporte, impuestoTrasladado, tipoFactor, tasaOCuota, impuestosTrasladados);

                clsMovimientos.guardarFactura();


                
                

            }



            /* XmlNodeList nodeEmisorDomicilioFiscal = eXmlEmisor.SelectNodes("/cfdi:Comprobante/cfdi:Emisor/cfdi:DomicilioFiscal", nsmgr);
            XmlNodeList nodeEmisorExpedidoEn = eXmlEmisor.SelectNodes("/cfdi:Comprobante/cfdi:Emisor/cfdi:ExpedidoEn", nsmgr);
            XmlNodeList nodeEmisorRegimenFiscal = eXmlEmisor.SelectNodes("/cfdi:Comprobante/cfdi:Emisor/cfdi:RegimenFiscal", nsmgr);

            XmlNodeList nodeReceptor = eXmlEmisor.SelectNodes("/cfdi:Comprobante/cfdi:Receptor", nsmgr);
            XmlNodeList nodeReceptorDomicilio = eXmlEmisor.SelectNodes("/cfdi:Comprobante/cfdi:Receptor/cfdi:Domicilio", nsmgr);
            
            XmlNodeList nodeImpuestos = eXmlEmisor.SelectNodes("/cfdi:Comprobante/cfdi:Impuestos", nsmgr);
            XmlNodeList nodeImpuestosTraslados = eXmlEmisor.SelectNodes("/cfdi:Comprobante/cfdi:Impuestos/cfdi:Traslados/cfdi:Traslado", nsmgr);
            */

        }



        private void btnLeerCfdiNomina_Click(object sender, EventArgs e)
        {

            clsConexionProveedores conexion = new clsConexionProveedores();

            string query = "SELECT * FROM FacturasProveedores";

            DataTable dtPruebas = new DataTable();

            dtPruebas = conexion.obtenerDatos(query);

            if(dtPruebas.Rows.Count > 0)
            {

                MessageBox.Show("CONSULTA GENERADA");
            }

        }




    }

}




