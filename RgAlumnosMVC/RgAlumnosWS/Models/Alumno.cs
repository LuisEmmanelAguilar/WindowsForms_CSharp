namespace RgAlumnosWS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Alumno")]
    public partial class Alumno
    {
        public Alumno()
        {
            Inscripcions = new List<Inscripcion>();
        }

        public int ID { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string Curp { get; set; }

        public string Genero { get; set; }

        public int Edad { get; set; }

        public List<Inscripcion> Inscripcions { get; set; }
    }
}
