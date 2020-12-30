using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeBuilders.Api.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HomeBuilders.Api.Services.Interfaces;

namespace HomeBuilders.Api.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class HomeBuildersController : ControllerBase
    {
        private IHomeBuildersService _hbService;
        private readonly ILogger<HomeBuildersController> _logger;

        public HomeBuildersController(ILogger<HomeBuildersController> logger, IHomeBuildersService hbService)
        {
            _logger = logger;
            _hbService = hbService;
        }

        [HttpGet]
        [Route("/homebuilders")]
        public async Task<IEnumerable<HomeBuilder>> GetHomeBuildersAsync()
        {
            return await _hbService.GetHomeBuilderListAsync();
        }

        [HttpGet]
        [Route("/homebuilders/{id}")]
        public async Task<HomeBuilder> GetHomeBuilderByIdAsync(int id)
        {
            return await _hbService.GetHomeBuilderByIdAsync(id);
        }

        [HttpGet]
        [Route("/homebuilders/{id}/clients")]
        public async Task<List<Client>> GetClientsAsync(int id)
        {
            return await _hbService.GetClientsForBuilderAsync(id);
        }

        [HttpGet]
        [Route("/homebuilders/{id}/projects")]
        public async Task<List<Project>> GetProjectsAsync(int id)
        {
            return await _hbService.GetProjectsForBuilderAsync(id);
        }

        [HttpGet]
        [Route("/homebuilders/{id}/employees")]
        public async Task<List<Employee>> GetEmployeesAsync(int id)
        {
            return await _hbService.GetEmployeesForBuilderAsync(id);
        }

        [HttpGet]
        [Route("/homebuilders/{id}/service-plan")]
        public async Task<ServicePlan> GetServicePlanAsync(int id)
        {
            return await _hbService.GetServicePlansForBuilderAsync(id);
        }

        [HttpGet]
        [Route("/homebuilders/{id}/stats")]
        public async Task<Stats> GetStatsAsync(int id)
        {
            return await _hbService.GetStatsForBuilderAsync(id);
        }

        [HttpGet]
        [Route("/homebuilders/{id}/pending-workorders")]
        public async Task<List<WorkOrder>> GetPendingWorkOrdersAsync(int id)
        {
            return await _hbService.GetPendingWorkOrdersForBuilderAsync(id);
        }
    }
}
