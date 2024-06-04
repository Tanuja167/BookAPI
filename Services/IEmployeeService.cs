using BookAPI.Models;

namespace BookAPI.Services
{
    public interface IEmployeeService
    {

        
            Task<IEnumerable<Employee>> GetEmployees();
            Task<Employee> GetEmployeeById(int id);
            Task<int> AddEmployee(Employee emp);
            Task<int> UpdateEmployee(Employee emp);
            Task<int> DeleteEmployee(int id);
        
    }
}
