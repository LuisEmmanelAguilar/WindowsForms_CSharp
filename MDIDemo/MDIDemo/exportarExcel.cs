using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Office.Interop.Excel;

namespace MDIDemo
{
    //LA HACEMOS PUBLICA PARA PODER ACCESARLA EN TODO EL PROYECTO
    public class exportarExcel
    {   
        public exportarExcel(System.Data.DataTable datos) // CONSTRUCTOR
        {
            this.exportaExcel(datos);

        }

        public void exportaExcel(System.Data.DataTable datos) 
        {
            //OBJETO QUE PERMITE INTERACTUAR CON EXCEL
            Application xlsApp = new Application(); // Crear una aplicacion de excel a nivel codigo
            xlsApp.DisplayAlerts = false; // deshabilitar  alertas
            Workbook xlsBook; // genera un libro
            Worksheet xlsSheet; // genera una hoja
            xlsApp.Visible = false; // la aplicacion no es visible
            xlsBook = xlsApp.Workbooks.Add(true); // añade el libro a la aplicacion
            xlsSheet = (Worksheet)xlsBook.ActiveSheet; // activa la hoja para el libro
            int ren = 1;
            int col = 1;

            foreach (DataRow registro in datos.Rows)  // barre  los registros
            {

                foreach (DataColumn campo in datos.Columns) // barre las columnas
                {
                    // variable generica
                    var dato = registro[campo].ToString(); // guarda el valor de cada celda
                    xlsSheet.Cells[4+ren, 1+col] = dato; // volcar el valor de dato en la hoja
                    col++;
                }
                ren++;
                col = 1;    
            }

            xlsApp.Visible = true;
        }
    }
}
