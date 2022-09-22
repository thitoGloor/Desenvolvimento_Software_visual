using Microsoft.AspNetCore.Mvc;
using Trabalho4SemestreApi.Data;
using Trabalho4SemestreApi.Models;

namespace Trabalho4SemestreApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class RestauranteController : ControllerBase
    {
        private static List<Restaurante> restaurantes = new List<Restaurante>();
        private readonly Contexts _contexto;
        public RestauranteController(Contexts contexto)
        {
            _contexto = contexto;
        }

        [HttpPost]
        public void AddRestaurante([FromBody] Restaurante restaurante)
        {
            _contexto.Restaurante.Add(restaurante);
            _contexto.SaveChanges();
        }
        [HttpGet]
        public IActionResult GetRestaurantes()
        {
            return Ok(_contexto.Restaurante.ToList());
        }
        [HttpGet("{id}")]
        public ActionResult GetRestaurantesById(int id)
        {
            Restaurante restaurante = _contexto.Restaurante.FirstOrDefault (restaurante => restaurante.RestauranteId ==id);
            if (restaurante != null)
            {
                return Ok(restaurante);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpDelete("{id}")]
        public void DeletarRestaurante(int id)
        {
            var restaurante = _contexto.Restaurante.FirstOrDefault(restaurante => restaurante.RestauranteId == id);
            if(restaurante != null)
            {
                _contexto.Restaurante.Remove(restaurante);
                _contexto.SaveChanges();
            }
        }
    }
}
