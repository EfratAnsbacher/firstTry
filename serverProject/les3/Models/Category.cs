using System.ComponentModel.DataAnnotations;

namespace les3.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
       

    }
}
