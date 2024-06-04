using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookAPI.Models
{
   
        [Table("employee1")]
        public class Employee
        {
            [Key]//pk in col in DB
            public int Id { get; set; }
            [Required]
            public string? Name { get; set; }
            [Required]
           
           
            public int Salary { get; set; }
           [Required]

           public string? City { get; set; }
        }
}
