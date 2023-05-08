using System.ComponentModel.DataAnnotations;

namespace ConsumeService.Models
{
    public class Product
    {
        public int Id { get; set; }
      
        public string Name { get; set; }
      
        public int Quantity { get; set; }
        
        public float Price { get; set; }
    }
}
