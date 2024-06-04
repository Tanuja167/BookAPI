using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace BookAPI.Models
{

    [Table("Student")]
    //Entity class or BO or POCO class
    public class Student
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? SName { get; set; }
        [Required]

        public int SPercentage { get; set; }
        [Required]

        public string? City { get; set; }
    }
}
