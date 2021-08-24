﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RgAlumnosMVC.Models
{
    public class Alumno
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Curp { get; set; }
        public string Genero { get; set; }
        public int Edad { get; set; }

        public virtual ICollection<Inscripcion> Inscripciones { get; set; }
    }
}