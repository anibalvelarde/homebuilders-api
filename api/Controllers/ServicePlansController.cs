using System.Collections.Generic;
using System.Threading.Tasks;
using HomeBuilders.Api.Domain.Models;
using HomeBuilders.Api.Requests;
using HomeBuilders.Api.Services.Interfaces;
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
            return await _service.UpdateExistingServicePlan(ServicePlanRequest.ServicePlanToUpdate);
        }
    }
}