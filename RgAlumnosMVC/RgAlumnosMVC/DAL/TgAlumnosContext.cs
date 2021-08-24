using RgAlumnosMVC.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace RgAlumnosMVC.DAL
{
    public class TgAlumnosContext : DbContext
    {
        /// <summary>
        /// Constructor para definir la conexion a base de datos que usara EntityFramework
        /// </summary>
        public TgAlumnosContext() : base("name=TgAlumnosConnection")
        {

        }

        /// <summary>
        /// Modelos que se generaran a traves de la forma CodeFirts de EF
        /// </summary>
        public DbSet<Alumno> Alumno { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Inscripcion> Inscripcion { get; set; }

        /// <summary>
        /// Define la configuracion al momento de crear la conexion con EF
        /// Defiimos no usar pluralizacion en el nombre de las tablas que seran generadas
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}