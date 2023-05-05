using System.ComponentModel.DataAnnotations;

namespace JWTAuthenticationExample.Models
{
    public class Product
    {
        public int Id { get; set; }
        [MinLength(3,ErrorMessage ="Product name should be minimum 3 chars long")]
        public string Name { get; set; }
        [Range(1,30,ErrorMessage ="Invalid quantity range range")]
        public int Quantity { get; set; }
        [Required(ErrorMessage ="Price cannot be empty")]
        [Range(1,100,ErrorMessage ="Inavlid price range. Price has to be between 1 and 100")]
        public float Price { get; set; }
    }
}
