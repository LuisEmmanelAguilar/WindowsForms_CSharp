using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RgAlumnosMVC.Models
{
    public class Curso
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }

        public virtual ICollection<Inscripcion> Inscripciones { get; set; }
    }
}