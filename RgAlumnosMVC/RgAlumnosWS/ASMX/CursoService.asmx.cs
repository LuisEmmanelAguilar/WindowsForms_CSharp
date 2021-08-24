using RgAlumnosWS.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;

namespace RgAlumnosWS.ASMX
{
    /// <summary>
    /// Summary description for CursoService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CursoService : System.Web.Services.WebService
    {
        private CursoController cursoController = new CursoController();

        [WebMethod]
        public string Descripcion()
        {
            return "Web Service de Cursos - V1. Soap accesible en GET y POST";
        }

        [WebMethod]
        public List<Curso> ListarCursos()
        {
            return cursoController.GetCurso().ToList();
        }

        [WebMethod]
        public Curso BuscarPorId(int idCurso)
        {
            return cursoController.GetCurso(idCurso);
        }

        [WebMethod]
        public void GuardarCurso(Curso nuevoCurso)
        {
            cursoController.PostCurso(nuevoCurso);
        }
    }
}
