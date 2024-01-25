using System.ComponentModel.DataAnnotations;

namespace WebAPIAutores.DTOs
{
    public class LibroCreacionDTO
    {
        [StringLength(maximumLength: 250)]
        public string Titulo { get; set; }
    }
}
