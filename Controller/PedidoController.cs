using Microsoft.AspNetCore.Mvc;
using Trabalho4SemestreApi.Data;
using Trabalho4SemestreApi.Models;

namespace Trabalho4SemestreApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class PedidoController : ControllerBase
    {

        private static List<Pedido> pedidos = new List<Pedido>();
        public readonly Contexts _contexto;
        public PedidoController(Contexts contexto)
        {
            _contexto = contexto;
        }


        [HttpPost]
        public void AddPedido([FromBody] Pedido pedido)
        {
            _contexto.Pedido.Add(pedido);
            _contexto.SaveChanges();

        }
        [HttpGet]
        public IActionResult GetPedidos()
        {
            return Ok(_contexto.Pedido.ToList());
        }
        [HttpGet("{id}")]
        public ActionResult GetPedidosById(int id)
        {
            Pedido pedido = _contexto.Pedido.FirstOrDefault(pedido => pedido.Id == id);
            if (pedido != null)
            {
                return Ok(pedido);
            }
            else
            {
                return NotFound();
            }
        }
        [HttpDelete("{id}")]
        public void DeletarPedido(int id)
            {
            
            
                var pedido = _contexto.Pedido.FirstOrDefault(pedido => pedido.Id == id);
            if (pedido != null)
            { 
                _contexto.Pedido.Remove(pedido);
                _contexto.SaveChanges();
            }
            }
        


    }
}

