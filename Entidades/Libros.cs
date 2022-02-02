using System.ComponentModel.DataAnnotations;

namespace ProyectoBibliaApliaca1.Entidades
{

    public class Libros
    {
        [Key]

        public int LibroId { get; set; }
        
        public string Titulo { get; set; }
        public string Grupo { get; set; }

    }
}