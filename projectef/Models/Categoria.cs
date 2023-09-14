using System.ComponentModel.DataAnnotations;

namespace projectef.Models
{
    public class Categoria
    {
        //[Key]
        public Guid categoriaId {  get; set; }

        //[Required]
        //[MaxLength(150)] se comentan ya que los atributos ahora los crean a traves de fluent api en tareascontexty este tiene prioridad
        public string nombre { get; set; }

        public string descripcion { get; set; }

        public virtual ICollection<Tarea> Tareas { get; set; }
    }
}
