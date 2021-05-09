using System.Collections.Generic;
using System.Threading.Tasks;
using HomeBuilders.Api.Domain.Models;
using HomeBuilders.Api.Requests;
using HomeBuilders.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HomeBuilders.Api.Controllers
{
    /// <summary>
    /// Maintains information about Employees
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class EmployeesController
    {
        private ILogger<EmployeesController> _logger;
        private IEmployeesService _service;

        public EmployeesController(ILogger<EmployeesController> logger, IEmployeesService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        [Route("/Employees")]
        public async Task<List<Employee>> GetEmployeesAsync()
        {
            return await _service.GetEmployeesAsync();
        }

        [HttpGet]
        [Route("/Employees/{id}")]
        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _service.GetEmployeeByIdAsync(id);
        }

        [HttpPost]
        [Route("/Employees")]
        public async Task<Employee> AddNewEmployee([FromBody] NewEmployeeRequest EmployeeRequest)
        {
            return await _service.AddNewEmployeeAsync(EmployeeRequest.NewHire);
        }

        [HttpPut]
        [Route("/Employees")]
        public async Task<Employee> UpdateExistingEmployee([FromBody] ExistingEmployeeRequest EmployeeRequest)
        {
            return await _service.UpdateExistingEmployeeAsync(EmployeeRequest.EmployeeToUpdate);
        }
    }
}