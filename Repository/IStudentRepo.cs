using BookAPI.Models;

namespace BookAPI.Repository
{
    public interface IStudentRepo
    {
        Task<IEnumerable<Student>> GetStudents();
        Task<Student> GetStudentById(int id);
        Task<int> AddStudent(Student student);
        Task<int> UpdateStudent(Student student);
        Task<int> DeleteStudent(int id);
    }
}
