using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancosLayout
{
    class clsLayoutBanco1
    {
        /*** Atributos *****/

        string UUID;
        string RFC;
        string RazonSocial;
        string CuentaPago;
        string CuentaOrigen;
        string ReferenciaPago;

        /*** Constructor ***/
        public clsLayoutBanco1(string uuid, string rfc, string razonSocial, string cuentaPago, string cuentaOrigen, string referenciaPago )
        {
            this.UUID = uuid;
            this.RFC = rfc;
            this.RazonSocial = razonSocial;
            this.CuentaPago = cuentaPago;
            this.CuentaOrigen = cuentaOrigen;
            this.ReferenciaPago = referenciaPago;

        }


        /*** CREAR LAYOUT ***/
        public string[] archivoBanco1 ()
        {

        }

    }
}
