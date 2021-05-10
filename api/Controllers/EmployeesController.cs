using System.Collections.Generic;
using System.Threading.Tasks;
using api.domain.models;
using HomeBuilders.Api.Requests;
using api.business.interfaces;
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

        /// <summary>
        /// REST API Controller to manage the Employees resource.
        /// </summary>
        /// <param name="logger">Dependency that implements the ILogger interface.</param>
        /// <param name="service">Detpendency that implements the IEmployeesService</param>
        public EmployeesController(ILogger<EmployeesController> logger, IEmployeesService service)
        {
            _logger = logger;
            _service = service;
        }

        /// <summary>
        /// Gets a list of all employees
        /// </summary>
        /// <returns>IEnumerable of Employee domain model type.</returns>
        [HttpGet]
        [Route("/Employees")]
        public async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {
            return await _service.GetEmployeesAsync();
        }

        /// <summary>
        /// Gets a single instance of Employee for the id passed in.
        /// </summary>
        /// <param name="id">Unique identifier for an Employees resource.</param>
        /// <returns>The instance of Employee that matches the unique identifier</returns>
        [HttpGet]
        [Route("/Employees/{id}")]
        public async Task<Employee> GetEmployeeByIdAsync(int id)
        {
            return await _service.GetEmployeeByIdAsync(id);
        }

        /// <summary>
        /// Adds a new instance of Employee to the permanent data store.
        /// </summary>
        /// <param name="EmployeeRequest">A well-formed request to persist a new instance of Employee</param>
        /// <returns>The instance of Employee which was created, including the identifier</returns>
        [HttpPost]
        [Route("/Employees")]
        public async Task<Employee> AddNewEmployee([FromBody] NewEmployeeRequest EmployeeRequest)
        {
            return await _service.AddNewEmployeeAsync(EmployeeRequest.NewHire);
        }

        /// <summary>
        /// Updates an existing Employees resource
        /// </summary>
        /// <param name="EmployeeRequest">A well-formed ExistingEmployeeRequest</param>
        /// <returns>The Employee instance that was updated.</returns>
        [HttpPut]
        [Route("/Employees")]
        public async Task<Employee> UpdateExistingEmployee([FromBody] ExistingEmployeeRequest EmployeeRequest)
        {
            return await _service.UpdateExistingEmployeeAsync(EmployeeRequest.EmployeeToUpdate);
        }
    }
}