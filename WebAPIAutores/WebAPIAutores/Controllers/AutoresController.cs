using Microsoft.AspNetCore.Mvc;
using WebAPIAutores.Entidades;

namespace WebAPIAutores.Controllers
{
    [ApiController]
    [Route("api/autores")]
    public class AutoresController: ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Autor>> Get()
        {
            return new List<Autor>()
            {
                new Autor() { Id = 1, Nombre = "Gerson"},
                new Autor() { Id = 2,Nombre = "Felix"},
                new Autor() { Id = 3,Nombre = "Si"}
            };
        }
    }
}
