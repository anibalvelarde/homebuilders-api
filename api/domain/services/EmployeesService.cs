using HomeBuilders.Api.Services.Interfaces;
using HomeBuilders.Api.Domain.Models;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace HomeBuilders.Api.Services
{
    public class EmployeesService : IEmployeesService
    {
        public Task<Employee> AddNewEmployeeAsync(Employee prospect)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployeeByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Employee>> GetEmployeesAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> UpdateExistingEmployee(Employee EmployeeToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}