using System.Collections.Generic;
using System.Threading.Tasks;
using api.domain.models;
using HomeBuilders.Api.Requests;
using api.business.interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HomeBuilders.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServicePlansController
    {
        private ILogger<ServicePlansController> _logger;
        private IServicePlansService _service;

        public ServicePlansController(ILogger<ServicePlansController> logger, IServicePlansService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        [Route("/ServicePlans")]
        public async Task<List<ServicePlan>> GetServicePlansAsync()
        {
            return await _service.GetServicePlansAsync();
        }

        [HttpGet]
        [Route("/ServicePlans/{id}")]
        public async Task<ServicePlan> GetServicePlanById(int id)
        {
            return await _service.GetServicePlanByIdAsync(id);
        }

        [HttpPost]
        [Route("/ServicePlans")]
        public async Task<ServicePlan> AddNewServicePlan([FromBody] NewServicePlanRequest ServicePlanRequest)
        {
            return await _service.AddNewServicePlanAsync(ServicePlanRequest.NewPlan);
        }

        [HttpPut]
        [Route("/ServicePlans")]
        public async Task<ServicePlan> UpdateExistingServicePlan([FromBody] ExistingServicePlanRequest ServicePlanRequest)
        {
            return await _service.UpdateExistingServicePlanAsync(ServicePlanRequest.ServicePlanToUpdate);
        }
    }
}