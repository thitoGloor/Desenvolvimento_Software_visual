using System.ComponentModel.DataAnnotations;

namespace Trabalho4SemestreApi.Models
{
    public class Pedido
    {
        //{
        // "id":1,
        //  "restaurante":"pizza norte",
        //  "data": 10/09/2022,
        //  "item": "pizza calabresa", "coca cola",
        // "valor": 119.00
        // }
        [Key]
        public int Id { get; set; }
        [Required]
        public string Restaurante { get; set; }
        [Required]
        public string Item { get; set; }      
       
        [Required]
        public int Valor { get; set; }
        public string Date { get; set; }

        public Pedido(int id, string restaurante, string item, int valor)

        {
            Id = id;
            Restaurante = restaurante;
            Item = item;
            Valor = valor;
            
        }
        public Pedido()
        {

        }
    }
}
