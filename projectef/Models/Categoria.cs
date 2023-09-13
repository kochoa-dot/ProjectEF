using System.ComponentModel.DataAnnotations;

namespace projectef.Models
{
    public class Categoria
    {
        [Key]
        public Guid categoriaId {  get; set; }

        [Required]
        [MaxLength(150)]
        public string nombre { get; set; }

        public string descripcion { get; set; }

        public virtual ICollection<Tarea> Tareas { get; set; }
    }
}
