using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.domain.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using api.business.interfaces;

namespace HomeBuilders.Api.Controllers
{
    /// <summary>
    /// Handles management of HomeBuilder resources
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class HomeBuildersController : ControllerBase
    {
        private IHomeBuildersService _hbService;
        private readonly ILogger<HomeBuildersController> _logger;

        /// <summary>
        /// Cosntructor
        /// </summary>
        /// <param name="logger">Reference to a Logger service instance</param>
        /// <param name="hbService">Reference to a HomeBuilderService instance</param>
        public HomeBuildersController(ILogger<HomeBuildersController> logger, IHomeBuildersService hbService)
        {
            _logger = logger;
            _hbService = hbService;
        }

        /// <summary>
        /// Retrieves all HomeBuilders registered in the system
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/homebuilders")]
        public async Task<IEnumerable<HomeBuilder>> GetHomeBuildersAsync()
        {
            return await _hbService.GetHomeBuilderListAsync();
        }

        /// <summary>
        /// Retrieves a singly HomeBuilder resource by unique Id
        /// </summary>
        /// <param name="id">Unique identifier for a HomeBuilder</param>
        /// <returns></returns>
        [HttpGet]
        [Route("/homebuilders/{id}")]
        public async Task<HomeBuilder> GetHomeBuilderByIdAsync(int id)
        {
            return await _hbService.GetHomeBuilderByIdAsync(id);
        }

        /// <summary>
        /// Retrieves the list of Client resources associated to a HomeBuilder resource
        /// </summary>
        /// <param name="id">Unique identifier for a HomeBuilder</param>
        /// <returns></returns>
        [HttpGet]
        [Route("/homebuilders/{id}/clients")]
        public async Task<List<Client>> GetClientsAsync(int id)
        {
            return await _hbService.GetClientsForBuilderAsync(id);
        }

        /// <summary>
        /// Retrieves the list of Project resources associated to a HomeBuilder resource
        /// </summary>
        /// <param name="id">Unique identifier for a HomeBuilder</param>
        /// <returns></returns>
        [HttpGet]
        [Route("/homebuilders/{id}/projects")]
        public async Task<List<Project>> GetProjectsAsync(int id)
        {
            return await _hbService.GetProjectsForBuilderAsync(id);
        }

        /// <summary>
        /// Retrieves the list of Employee resources associated to a HomeBuilder resource
        /// </summary>
        /// <param name="id">Unique identifier for a HomeBuilder</param>
        /// <returns></returns>
        [HttpGet]
        [Route("/homebuilders/{id}/employees")]
        public async Task<List<Employee>> GetEmployeesAsync(int id)
        {
            return await _hbService.GetEmployeesForBuilderAsync(id);
        }

        /// <summary>
        /// Retrieves tha list of Service Plan resources that have ever been associated to a HomeBuilder resource
        /// </summary>
        /// <param name="id">Unique identifier for a HomeBuilder</param>
        /// <returns></returns>
        [HttpGet]
        [Route("/homebuilders/{id}/service-plan")]
        public async Task<ServicePlan> GetServicePlanAsync(int id)
        {
            return await _hbService.GetServicePlansForBuilderAsync(id);
        }

        /// <summary>
        /// Retrieves an instance of Stats resource that is associated to a HomeBuilder
        /// </summary>
        /// <param name="id">Unique identifier for a HomeBuilder</param>
        /// <returns></returns>
        [HttpGet]
        [Route("/homebuilders/{id}/stats")]
        public async Task<Stats> GetStatsAsync(int id)
        {
            return await _hbService.GetStatsForBuilderAsync(id);
        }

        /// <summary>
        /// Retrieves a list of pending WorkOrder resources that are associated to a HomeBuilder
        /// </summary>
        /// <param name="id">Unique identifier for a HomeBuilder</param>
        /// <returns></returns>
        [HttpGet]
        [Route("/homebuilders/{id}/pending-workorders")]
        public async Task<List<WorkOrder>> GetPendingWorkOrdersAsync(int id)
        {
            return await _hbService.GetPendingWorkOrdersForBuilderAsync(id);
        }
    }
}
