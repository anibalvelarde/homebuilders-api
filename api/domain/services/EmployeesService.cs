using HomeBuilders.Api.Services.Interfaces;
using HomeBuilders.Api.Domain.Models;
using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Linq;
using HomeBuilders.Api.Domain.Models.Enums;

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

        public Task<List<Employee>> GetEmployeesForHomeBuilderAsync(int id)
        {
            var employees = new List<Employee>();
            for (int i = 0; i < 5; i++)
            {
                employees.Add(MakeFakeEmployee(i, isForHomeBuilder: true));
            }
            return Task.FromResult(employees);
        }

        public Task<Employee> UpdateExistingEmployeeAsync(Employee EmployeeToUpdate)
        {
            throw new NotImplementedException();
        }

        private Employee MakeFakeEmployee(int id, bool isForHomeBuilder = false)
        {
            return new Employee()
            {
                Id = Guid.NewGuid(),
                Name = $"Fake-EE-Name-{id}",
                Role = id.Equals(0) ? EmployeeRole.CompanyOwner : EmployeeRole.AdminStaff,
                Email = isForHomeBuilder ? $"hb-{id}-Email@hb.com" : "some-email@homebuilder.com"
            };
        }

    }
}