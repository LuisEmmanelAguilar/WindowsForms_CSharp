namespace RgAlumnosWS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Inscripcion")]
    public partial class Inscripcion
    {
        public int ID { get; set; }

        public DateTime FechaInscripcion { get; set; }

        public double Descuento { get; set; }

        public double Total { get; set; }

        public int? Alumno_ID { get; set; }

        public int? Curso_ID { get; set; }

        public Alumno Alumno { get; set; }

        public Curso Curso { get; set; }
    }
}
