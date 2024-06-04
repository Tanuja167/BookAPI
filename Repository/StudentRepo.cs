using BookAPI.Data;
using BookAPI.Models;
using BookAPI.Repository;

using Microsoft.EntityFrameworkCore;

namespace BookWebAPI.Repositories
{
    public class StudentRepo : IStudentRepo
    {
        private readonly ApplicationDbContext db;

        public StudentRepo(ApplicationDbContext db)
        {
            this.db = db;
        }
        public async Task<int> AddStudent(Student student)
        {
            int result = 0;
            await db.Students.AddAsync(student);
            result = await db.SaveChangesAsync();
            return result;
        }

        public async Task<int> DeleteStudent(int id)
        {
            int result = 0;
            var student = await db.Students.Where(x => x.Id == id).FirstOrDefaultAsync();
            if (student != null)
            {
                db.Students.Remove(student);
                result = await db.SaveChangesAsync();
            }
            return result;
        }

        public async Task<Student> GetStudentById(int id)
        {
            var student = await db.Students.Where(x => x.Id == id).FirstOrDefaultAsync();
            return student;
        }

        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await db.Students.ToListAsync();
        }

        public async Task<int> UpdateStudent(Student student)
        {
            int result = 0;
            var b = await db.Students.Where(x => x.Id == student.Id).FirstOrDefaultAsync();
            if (b != null)
            {
                b.SName = student.SName;
                b.SPercentage = student.SPercentage;
                b.City = student.City;
                result = await db.SaveChangesAsync();
            }
            return result;
        }
    }
}