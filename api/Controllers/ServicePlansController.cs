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
    /// Handles management of ServicePlan resources
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class ServicePlansController
    {
        private ILogger<ServicePlansController> _logger;
        private IServicePlansService _service;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="logger">A logger service</param>
        /// <param name="service">A ServicePlan Manager service</param>
        public ServicePlansController(ILogger<ServicePlansController> logger, IServicePlansService service)
        {
            _logger = logger;
            _service = service;
        }

        /// <summary>
        /// Gets a list of all Service Plans in the platform
        /// </summary>
        /// <param name="pageItemCount">Max items returned in a single request. Pagination is required to extract other items></param>
        /// <returns>The next n (where n = pageItemCount) items in the list of Service Plan resources</returns>
        [HttpGet]
        [Route("/ServicePlans")]
        public async Task<List<ServicePlan>> GetServicePlansAsync(int pageItemCount = 15)
        {
            return await _service.GetServicePlansAsync();
        }

        /// <summary>
        /// Gets a single ServicePlan resource
        /// </summary>
        /// <param name="id">Unique identifier for a Service Plan resource</param>
        /// <returns>An instance of ServicePlan resource</returns>
        [HttpGet]
        [Route("/ServicePlans/{id}")]
        public async Task<ServicePlan> GetServicePlanById(int id)
        {
            return await _service.GetServicePlanByIdAsync(id);
        }

        /// <summary>
        /// Creates a new Service Plan resource
        /// </summary>
        /// <param name="ServicePlanRequest">Well-formed info to create a Service Plan resource</param>
        /// <returns>The ServicePlan resource that was added to the platform</returns>
        [HttpPost]
        [Route("/ServicePlans")]
        public async Task<ServicePlan> AddNewServicePlan([FromBody] NewServicePlanRequest ServicePlanRequest)
        {
            return await _service.AddNewServicePlanAsync(ServicePlanRequest.NewPlan);
        }

        /// <summary>
        /// Updates an existing Service Plan resource
        /// </summary>
        /// <param name="ServicePlanRequest">Well-formed info to update an existing Service Plan resource</param>
        /// <returns>The Service Plan resource that was updated</returns>
        [HttpPut]
        [Route("/ServicePlans")]
        public async Task<ServicePlan> UpdateExistingServicePlan([FromBody] ExistingServicePlanRequest ServicePlanRequest)
        {
            return await _service.UpdateExistingServicePlanAsync(ServicePlanRequest.ServicePlanToUpdate);
        }
    }
}