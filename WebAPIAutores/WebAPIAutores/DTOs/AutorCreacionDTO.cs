using System.ComponentModel.DataAnnotations;

namespace WebAPIAutores.DTOs
{
    public class AutorCreacionDTO
    {
        [Required(ErrorMessage = "El campo nombre es requerido")]
        public string Nombre { get; set; }

    }
}
