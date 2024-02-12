﻿using System.ComponentModel.DataAnnotations;

namespace WebAPIAutores.Entidades
{
    public class Libro
    {
        public int Id { get; set; }
        [StringLength(maximumLength: 250)]
        [Required]
        public string Titulo { get; set; }
        public List<Comentario> Comentarios { get; set; }
        public List<AutorLibro> AutoresLibros { get; set;}
    }
}
