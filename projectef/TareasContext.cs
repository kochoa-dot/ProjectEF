using Microsoft.EntityFrameworkCore;
using projectef.Models;

namespace projectef
{
    public class TareasContext : DbContext
    {
        // Hacemos este clase para que entity framework tome estos modelos como tablas de la db
        public DbSet<Categoria> Categorias { get; set; }// El modelo se llama en singular y la coleccion se llama en plural ya que representará todos los elementos de la tabla

        public DbSet<Tarea> Tareas { get; set; }

        //metodo base del ctor  de entity framework, recibimos las distintas opciones, metodo base le pasamos las opciones que estamos recibiendo
        public TareasContext(DbContextOptions<TareasContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>(categoria =>
            {
                categoria.ToTable("Categoria");
                categoria.HasKey(p => p.categoriaId);

                categoria.Property(p => p.nombre).IsRequired().HasMaxLength(150);

                categoria.Property(p => p.descripcion);
            });

            modelBuilder.Entity<Tarea>(tarea =>
            {
                tarea.ToTable("Tareas");
                tarea.HasKey(t => t.tareaId);
                
                tarea.Property(t => t.categoriaId);
                tarea.Property(t => t.titulo).IsRequired().HasMaxLength(200);
                tarea.Property(t =>t.descripcion).HasMaxLength(500);
                tarea.Property(t => t.prioridadTarea).IsRequired();
                tarea.Property(t => t.fechaCreacion);
            });
        }
    }
}
