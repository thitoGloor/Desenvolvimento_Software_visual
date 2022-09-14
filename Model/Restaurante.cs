using System.ComponentModel.DataAnnotations;

namespace Trabalho4SemestreApi.Models
{
    public class Restaurante
    {
        [Key]
        public int RestauranteId { get; set; }
        [Required]
        public string Nome { get; set; }
        public string Endereco { get; set; }    
        public string TipoComida { get; set; }
        public string Whatsapp { get; set; }
        public string Pedido { get; set; }

        public Restaurante(int restauranteId, string nome, string endereco, string tipoComida, string whatsapp, string pedido)
        {
            RestauranteId = restauranteId;
            Nome = nome;
            Endereco = endereco;
            TipoComida = tipoComida;
            Whatsapp = whatsapp;
            Pedido = pedido;
        }
        public Restaurante()
        {

        }
    }
}
