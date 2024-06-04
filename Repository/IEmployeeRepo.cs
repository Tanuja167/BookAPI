using BookAPI.Models;

namespace BookAPI.Repository
{
    
        public interface IEmployeeRepo
        {
            Task<IEnumerable<Employee>> GetEmployees();
            Task<Employee> GetEmployeeById(int id);
            Task<int> AddEmployee(Employee emp);
            Task<int> UpdateEmployee(Employee emp);
            Task<int> DeleteEmployee(int id);
        }
    
}
