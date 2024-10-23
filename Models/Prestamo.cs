namespace BibliotecaDtiC.Models
{
    public class Prestamo
    {
        public int IdPrestamo { get; set; }
        public int IdLibro { get; set; }
        public string NombreUsuario { get; set; }
        public string FechaPrestamo { get; set; }
        public string? FechaDevolucion { get; set; }
        public string? EstadoLibro { get; set; }
    }
}
