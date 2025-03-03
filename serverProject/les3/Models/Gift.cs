using System.ComponentModel.DataAnnotations;

namespace les3.Models
{
    public class Gift
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public int DonorId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int NumOfBuyers { get; set; }
        [Required]
        public string Image { get; set; }


    }
}
