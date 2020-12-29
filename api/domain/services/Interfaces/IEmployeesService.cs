using System.Collections.Generic;
using System.Threading.Tasks;
using HomeBuilders.Api.Domain.Models;

namespace HomeBuilders.Api.Services.Interfaces
{
    public interface IEmployeesService
    {
        Task<List<Employee>> GetEmployeesAsync();
        Task<Employee> GetEmployeeByIdAsync(int id);
        Task<Employee> AddNewEmployeeAsync(Employee prospect);
        Task<Employee> UpdateExistingEmployee(Employee EmployeeToUpdate);
    }
}