using BookAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Data
{
    public class ApplicationDbContext:DbContext 
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> op) : base(op)
        {
            //holds configuration options for database
        }

        public DbSet<Book> Books { get; set; }   //used to query and save instance of class

        public DbSet<Student> Students { get; set; }

        public DbSet<Employee> Employees { get; set; }

        //DbSet represents a collection of Book entities mapped to a database table.
    }
}
