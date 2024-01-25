namespace WebAPIAutores.Entidades
{
    public class Comentario
    {
        public int Id { get; set; }
        public string comentario { get; set; }
        public int LibroId { get; set; }
        public Libro libro { get; set; }
    }
}
