using System.Data.Entity;

namespace sistema_biblioteca
{

    public class BibliotecaContext : DbContext
    {
        public BibliotecaContext() : base("name=BibliotecaBDConnectionString") { }

        public DbSet<libro> libros { get; set; }
        public DbSet<usuario> usuarios { get; set; }
        public DbSet<prestamo> prestamos { get; set; }
        public DbSet<revista> revistas { get; set; } 
        public DbSet<DVD> DVDs { get; set; } 
    }
}

