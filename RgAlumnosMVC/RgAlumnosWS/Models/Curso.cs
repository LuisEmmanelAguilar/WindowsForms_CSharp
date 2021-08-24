namespace RgAlumnosWS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Curso")]
    public partial class Curso
    {
        public Curso()
        {
            Inscripcions = new List<Inscripcion>();
        }

        public int ID { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public double Precio { get; set; }

        public List<Inscripcion> Inscripcions { get; set; }
    }
}
