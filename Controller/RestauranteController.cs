using Microsoft.AspNetCore.Mvc;
using Trabalho4SemestreApi.Models;

namespace Trabalho4SemestreApi.Controllers
{
    [ApiController]
    [Route("{Controller}")]
    public class RestauranteController : ControllerBase
    {
        private static List<Restaurante> restaurantes = new List<Restaurante>();
       
        [HttpPost]
        public void AddRestaurante([FromBody] Restaurante restaurante)
        {
            restaurantes.Add(restaurante);
        }
        [HttpGet]
        public IActionResult GetRestaurantes()
        {
            return Ok(restaurantes);
        }
        [HttpGet("{Id}")]
        public IActionResult GetRestaurantesById(int id)
        {
            Restaurante restaurante = restaurantes.FirstOrDefault (restaurante => restaurante.RestauranteId ==id);
            if (restaurante != null)
            {
                return Ok(restaurante);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
