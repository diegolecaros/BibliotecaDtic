using Microsoft.EntityFrameworkCore;
using BibliotecaDtiC.Models;

namespace BibliotecaDtiC.Data
{
    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options)
        {
        }

        public DbSet<Libro> Libros { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }

    }
}
