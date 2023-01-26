using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Models
{
    public class producer : Person
    {
        [Key]
        public int Id { get; set; }
        public string propic { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
    }
}
