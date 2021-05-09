using System.Collections.Generic;
using System.Threading.Tasks;
using api.domain.models;

namespace api.business.interfaces
{
    public interface IEmployeesService
    {
        Task<List<Employee>> GetEmployeesAsync();
        Task<Employee> GetEmployeeByIdAsync(int id);
        Task<Employee> AddNewEmployeeAsync(Employee prospect);
        Task<Employee> UpdateExistingEmployeeAsync(Employee EmployeeToUpdate);
        Task<List<Employee>> GetEmployeesForHomeBuilderAsync(int id);
    }
}