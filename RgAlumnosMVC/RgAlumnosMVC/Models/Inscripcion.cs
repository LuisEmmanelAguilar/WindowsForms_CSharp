using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RgAlumnosMVC.Models
{
    public class Inscripcion
    {
        public int ID { get; set; }
        public DateTime FechaInscripcion { get; set; }
        public double Descuento { get; set; }
        public double Total { get; set; }

        public virtual Curso Curso { get; set; }
        public virtual Alumno Alumno { get; set; }
    }
}