using Microsoft.EntityFrameworkCore;
using ProyectoBibliaApliaca1.Entidades;

public class Contexto:DbContext
{
    public DbSet<Libros> Libros { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        optionsBuilder.UseSqlite(@"Data Source=Data\Libros.db");
    }

}
