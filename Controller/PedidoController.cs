using Microsoft.AspNetCore.Mvc;
using Trabalho4SemestreApi.Models;

namespace Trabalho4SemestreApi.Controllers
{
    [ApiController]
    [Route("{Controller}")]
    public class PedidoController : ControllerBase
    {
        private static List<Pedido> pedidos = new List<Pedido>();
        [HttpPost]
        public void AddPedido([FromBody] Pedido pedido)
        {
            pedidos.Add(pedido);

        }
        [HttpGet]
        public IActionResult GetPedidos()
           {
            return Ok(pedidos);
            }
        [HttpGet ("{id}")]
        public IActionResult GetPedidosById(int id)
        {
            Pedido pedido = pedidos.FirstOrDefault(pedido =>pedido.Id == id);
            if(pedido != null)
            {
                return Ok(pedido);
            }
            else
            {
                return NotFound();
            }
        }
        


    }
}
