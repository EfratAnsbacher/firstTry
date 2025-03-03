using System.ComponentModel.DataAnnotations;

namespace les3.Models
{
    public class Donor
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public int userId { get; set; }
        public List<Gift> Gifts { get; set; }



    }
}
