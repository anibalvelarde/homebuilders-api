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
        public Task<Employee> AddNewEmployeeAsync(Employee newHire)
        {
            return Task.FromResult(new Employee(newHire));
        }

        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            var employees = await this.GetEmployeesAsync();
            return employees.Find(e => e.Id.Equals(id));
        }

        public Task<List<Employee>> GetEmployeesAsync()
        {
            var employees = new List<Employee>();
            for (int i = 0; i < 5; i++)
            {
                employees.Add(MakeFakeEmployee(i));
            }
            return Task.FromResult(employees);
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

        public Task<Employee> UpdateExistingEmployeeAsync(Employee employeeToUpdate)
        {
            return Task.FromResult(employeeToUpdate);
        }

        private Employee MakeFakeEmployee(int id, bool isForHomeBuilder = false)
        {
            var newHire = new Employee()
            {
                Name = $"Fake-EE-Name-{id}",
                Role = id.Equals(0) ? EmployeeRole.CompanyOwner : EmployeeRole.AdminStaff,
                Email = isForHomeBuilder ? $"hb-{id}-Email@hb.com" : "some-email@homebuilder.com"
            };
            return new Employee(newHire);
        }

    }
}