using System.ComponentModel.DataAnnotations;

namespace HomeCine.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int Id { get; set; }


        public Movie Movie { get; set; }
        public int Amouunt { get; set; }

        public string ShoppingCartId { get; set; }
    }
}
