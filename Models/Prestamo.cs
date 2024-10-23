using System;
using System.ComponentModel.DataAnnotations;

namespace BibliotecaDtiC.Models
{
    public class Prestamo
    {
        public int Id { get; set; }
        [Display(Name = "Identificador libro")]
        public int IdLibro { get; set; }

        [Required(ErrorMessage = "El nombre de usuario es obligatorio.")]
        [Display(Name = "Nombre de usuario")]
        public string NombreUsuario { get; set; }

        [Display(Name = "Fecha de préstamo")]
        [DataType(DataType.Date)]
        public DateTime FechaPrestamo { get; set; }

        [Display(Name = "Fecha de devolución")]
        [DataType(DataType.Date)]
        public DateTime? FechaDevolucion { get; set; }

        [Display(Name = "Estado del libro")]
        public string? EstadoLibro { get; set; }

    }
}
