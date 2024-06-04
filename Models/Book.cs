using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookAPI.Models
{
    
        [Table("book")]
        //Entity class or BO or POCO class
        public class Book
        {
            [Key]
            public int Id { get; set; }
            [Required]
            public string? Name { get; set; }
            [Required]

            public string? Author { get; set; }
            [Required]

            public int Price { get; set; }
        }
}
