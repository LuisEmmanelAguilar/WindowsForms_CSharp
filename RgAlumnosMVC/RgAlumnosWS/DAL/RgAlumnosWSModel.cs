namespace RgAlumnosWS
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class RgAlumnosWSModel : DbContext
    {
        public RgAlumnosWSModel()
            : base("name=RgAlumnosWSModel")
        {
        }

        public virtual DbSet<Alumno> Alumnoes { get; set; }
        public virtual DbSet<Curso> Cursoes { get; set; }
        public virtual DbSet<Inscripcion> Inscripcions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>()
                .HasMany(e => e.Inscripcions)
                .WithOptional(e => e.Alumno)
                .HasForeignKey(e => e.Alumno_ID);

            modelBuilder.Entity<Curso>()
                .HasMany(e => e.Inscripcions)
                .WithOptional(e => e.Curso)
                .HasForeignKey(e => e.Curso_ID);
        }
    }
}
