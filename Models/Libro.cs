using System.ComponentModel.DataAnnotations;

namespace BibliotecaDtiC.Models
{
    public class Libro
    {
        [Display(Name = "Identificador")]
        public int Id { get; set; }
        [Display(Name = "Título")]
        [Required(ErrorMessage = "El titulo del libro es obligatorio.")]
        [StringLength(20, ErrorMessage = "El nombre de usuario no puede exceder los 20 caracteres.")]
        public string Titulo { get; set; }
        [Display(Name = "Autor")]
        public Autor autor { get; set; }
        [Display(Name = "Clasificación")]
        public Clasificacion clasificacion { get; set; }
    }

}
