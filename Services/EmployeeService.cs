using BookAPI.Models;
using BookAPI.Repository;

namespace BookAPI.Services
{
    
    public class EmployeeService : IEmployeeService
        {
            private readonly IEmployeeRepo repo;
            public EmployeeService(IEmployeeRepo repo)
            {
                this.repo = repo;
            }

            public async Task<int> AddEmployee(Employee emp)
            {
                return await repo.AddEmployee(emp);
            }

            public async Task<int> DeleteEmployee(int id)
            {
                return await repo.DeleteEmployee(id);
            }

            public async Task<Employee> GetEmployeeById(int id)
            {
                return await repo.GetEmployeeById(id);
            }

            public async Task<IEnumerable<Employee>> GetEmployees()
            {
                return await repo.GetEmployees();
            }

            public async Task<int> UpdateEmployee(Employee emp)
            {
                return await repo.UpdateEmployee(emp);
            }
        }
}
