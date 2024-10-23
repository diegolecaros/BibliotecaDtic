namespace BibliotecaDtiC.Models
{
    public class Libro
    {
        public int IdLibro { get; set; }
        public string Titulo { get; set; }
        public Autor autor { get; set; }
        public Clasificacion clasificacion { get; set; }
}

}
