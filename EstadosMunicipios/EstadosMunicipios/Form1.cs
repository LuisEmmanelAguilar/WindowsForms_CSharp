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

namespace EstadosMunicipios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conexionSQL conexionEstados = new conexionSQL();
            DataTable infoEstados = new DataTable();
            string cEstados = "SELECT idEstado, estado FROM Estados";
            infoEstados = conexionEstados.ObtenerDatos(cEstados);
            cboEstados.DataSource = infoEstados;
            cboEstados.DisplayMember = "estado";
            cboEstados.ValueMember = "idEstado";
        }


        private void cboEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            conexionSQL conexionMunicipios = new conexionSQL();
            DataTable infoMunicipios = new DataTable();
            string cMunicipios = "SELECT municipio, idMunicipio FROM Municipios WHERE idEstado ='" +
                                cboEstados.SelectedValue + "'";
            infoMunicipios = conexionMunicipios.ObtenerDatos(cMunicipios);
            cboMunicipios.DataSource = infoMunicipios;
            cboMunicipios.DisplayMember = "municipio";
            cboMunicipios.ValueMember = "idMunicipio";
        }


        private void btnMostrar_Click(object sender, EventArgs e)
        {
            conexionSQL conexionLocalidades = new conexionSQL();
            DataTable infoLocalidades = new DataTable();
            string cLoclidades = "SELECT L.idLocalidad, L.localidad, L.idMunicipio, L.idEstado " +
                                 "FROM localidades L, municipios M, estados E " +
                                 "WHERE L.idEstado=M.idEstado AND L.idMunicipio = M.idMunicipio " +
                                 "AND M.idEstado = E.idEstado " +
                                 "AND L.idEstado = '" + cboEstados.SelectedValue + "' " +
                                 "AND L.idMunicipio = '" + cboMunicipios.SelectedValue + "' ";
            infoLocalidades = conexionLocalidades.ObtenerDatos(cLoclidades);
            dgLocalidades.DataSource = infoLocalidades;                                
         }

    }
}
