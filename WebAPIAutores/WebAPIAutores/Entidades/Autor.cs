using System.ComponentModel.DataAnnotations;

namespace WebAPIAutores.Entidades
{
    public class Autor
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El campo nombre es requerido")]
        public string Nombre { get; set;}
        public List<Libro> Libros { get; set; }
    }
}
